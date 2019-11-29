// This file is part of SBRW.Core by heyitsleo.
// 
// Created: 11/29/2019 @ 10:32 AM.

using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SBRW.Core.Auth;
using SBRW.Data;
using SBRW.Data.Entities;

namespace SBRW.Core
{
    /// <summary>
    /// Base implementation of the typical <c>Startup</c> class.
    /// Configures ASP.NET Core Identity and database access.
    /// </summary>
    public abstract class CoreStartupBase
    {
        protected SymmetricSecurityKey SecurityKey { get; private set; }

        protected CoreStartupBase(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public virtual void ConfigureServices(IServiceCollection services)
        {
            // Set up encryption
            SecurityKey =
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetValue<string>("Encryption:Key")));

            // DB setup
            services.AddDbContext<GameDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("MainDB"),
                    b => b.MigrationsAssembly(typeof(GameDbContext).Assembly.FullName));
            });

            // Auth setup
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
        }
    }
}