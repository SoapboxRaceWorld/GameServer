using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SBRW.Data;
using SBRW.Data.Entities;
using SBRW.GameServer.Auth;
using SBRW.GameServer.Middleware;

namespace SBRW.GameServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc()
                .AddXmlDataContractSerializerFormatters()
                .AddXmlSerializerFormatters()
                .AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddDbContext<GameDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("MainDB"),
                    b => b.MigrationsAssembly(typeof(GameDbContext).Assembly.FullName));
            });
            services.AddAutoMapper(typeof(Startup));

            // add identity
            var builder = services.AddIdentityCore<AppUser>(o =>
            {
                // configure identity options
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
            });
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
            builder.AddEntityFrameworkStores<GameDbContext>().AddDefaultTokenProviders();

            // authorization
            services.AddAuthorization(options =>
            {
                options.AddPolicy("SoapServicePlayer",
                    policyBuilder =>
                    {
                        policyBuilder.RequireClaim(AuthClaimIdentifiers.Role, AuthClaims.PlayerAccess);
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseMiddleware<BlackboxMiddleware>();

//            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
