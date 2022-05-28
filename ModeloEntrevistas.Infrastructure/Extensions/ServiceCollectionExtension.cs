using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using ModeloEntrevistas.Core.Interfaces;
using ModeloEntrevistas.Infrastructure.Data;
using ModeloEntrevistas.Infrastructure.Repositories;
using System;
using System.IO;

namespace ModeloEntrevistas.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ModeloEntrevistasContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("ModeloEntrevistas"))
           );

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(doc =>
            {
                doc.SwaggerDoc("v1", new OpenApiInfo { Title = "Modelo Entrevistas API", Version = "v1" });
            });

            return services;
        }
    }
}
