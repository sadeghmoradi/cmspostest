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

namespace Extensions
{
    public static class ServerExtensions
    {
        public static void ConfigureCore(this IServiceCollection services)
        {
            services.AddCors(police => police.AddPolicy("PolicyCore", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials()));
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

        public static void ConfigureWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

    }
}
