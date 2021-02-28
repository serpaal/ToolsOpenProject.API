using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToolsOpenProject.Infrastructure;

namespace ToolsOpenProject.API.Extensions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection AddToolsMesaAyudaContext(this IServiceCollection services, string connectionString)
        {
            return services
                .AddDbContext<ToolsMesaAyudaContext>(contextOptions =>
                {
                    contextOptions.UseNpgsql(
                        connectionString,
                        serverOptions => {
                            serverOptions.MigrationsAssembly(typeof(Startup).Assembly.FullName);
                        });
                });
        }
    }
}
