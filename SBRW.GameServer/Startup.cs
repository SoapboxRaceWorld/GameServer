using System;
using System.Linq;
using System.Threading.Tasks;
using CoreLibraries.ModuleSystem;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SBRW.Core;
using SBRW.Core.Auth;
using SBRW.GameServer.Middleware;
using SBRW.GameServer.Services;
using SBRW.GameServer.Services.Attrib;

namespace SBRW.GameServer
{
    public class Startup : CoreStartupBase
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            // authorization

            // jwt wire up
            // Get options from app settings
            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = SecurityKey,

                RequireExpirationTime = true,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(configureOptions =>
            {
                configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
                configureOptions.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        if (context.Request.Headers.TryGetValue("securityToken", out StringValues sv)
                            && sv.Any())
                        {
                            context.Token = sv[0];
                        }

                        return Task.CompletedTask;
                    }
                };
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("SoapServicePlayer",
                    policyBuilder =>
                    {
                        policyBuilder.RequireAuthenticatedUser();
                        //policyBuilder.RequireClaim(AuthClaimIdentifiers.Rol, AuthClaims.PlayerAccess);
                    });
            });

            services.AddControllers();
            services.AddMvc()
                .AddXmlDataContractSerializerFormatters()
                .AddXmlSerializerFormatters()
                .AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddSession();
            services.AddDistributedRedisCache(options =>
            {
                options.Configuration = Configuration.GetConnectionString("RedisDB");
                options.InstanceName = "master";
            });

            services.AddSingleton(new ModuleLoader());

            services.AddScoped<ISessionService, SessionService>();
            services.AddSingleton<ISettingsService, SettingsService>();
            services.AddSingleton<GameplayVault>();
            services.AddSingleton<IAttribService, AttribService>();
            services.AddSingleton<ICarClassesService, CarClassesService>();
            services.AddScoped<IPersonaCarService, PersonaCarService>();
            services.AddScoped<IPersonaService, PersonaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ModuleLoader moduleLoader,
            IAttribService attribService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<BlackboxMiddleware>();

            //            app.UseHttpsRedirection();

            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            moduleLoader.Load();
            attribService.LoadAttribData();
        }
    }
}