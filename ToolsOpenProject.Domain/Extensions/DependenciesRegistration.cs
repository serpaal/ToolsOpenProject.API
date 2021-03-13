using Microsoft.Extensions.DependencyInjection;
using System;
using ToolsOpenProject.Domain.Services;

namespace ToolsOpenProject.Domain.Extensions
{
    public static class DependenciesRegistration
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }


        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services
                .AddScoped<IRequerimientosMesaAyudaOpenProjectService, RequerimientosMesaAyudaOpenProjectService>()
                .AddScoped<IMesaAyudaOpenProjectService, MesaAyudaOpenProjectService>();
           
            return services;
        }
    }
}
