using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToolsOpenProject.Domain.Entities;
using ToolsOpenProject.Domain.Repositories;
using ToolsOpenProject.Infrastructure.SchemaDefinitions;

namespace ToolsOpenProject.Infrastructure
{
    public class ToolsMesaAyudaContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "public";
        public DbSet<MesaAyudaOpenProject> MesaAyudaOpenProjects { get; set; }

        public ToolsMesaAyudaContext(DbContextOptions<ToolsMesaAyudaContext> options)
            : base(options)
        {
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MesaAyudaOpenProjectEntitySchemaDefinition());
            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
