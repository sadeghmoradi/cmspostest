using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDB;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using IRepository;
using Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Extensions
{
    public static class ServerExtensions
    {
        public static void ConfigureCore(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddCors();
            //services.AddCors(police => { police.AddPolicy("PolicyCore", builder => { builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials(); }); });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(option =>
            {

            });
        }

        public static void ConfigureSqlContext(this IServiceCollection services , IConfiguration configuration)
        {
            var connectionString = configuration["sqlConnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(connectionString));
        }
        public static void ConfigureSqlIdentity(this IServiceCollection services ,IConfiguration configuration)
        {
            var connectionString = configuration["sqlConnection:connectionString"];
            services.AddDbContext<UserDBContext>(o => o.UseSqlServer(connectionString));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<UserDBContext>();
        }

        public static void ConfigurAuthentication(this IServiceCollection services)
        {
            var SigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is the secret phrase"));
            services.AddAuthentication(opstions =>
                {
                    opstions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    opstions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters()
                    {
                        IssuerSigningKey = SigningKey,
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        ValidateLifetime = false,
                        ValidateIssuerSigningKey = true
                    };
                });
        }

        public static void ConfigureWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapperBase, RepositoryWrapperBase>();
            
        }

    }
}
