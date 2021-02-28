using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ToolsOpenProject.Domain.Entities;

namespace ToolsOpenProject.Infrastructure.SchemaDefinitions
{
    public class MesaAyudaOpenProjectEntitySchemaDefinition : IEntityTypeConfiguration<MesaAyudaOpenProject>
    {
        public void Configure(EntityTypeBuilder<MesaAyudaOpenProject> builder)
        {
            builder.ToTable("mesa_ayuda_open_project", ToolsMesaAyudaContext.DEFAULT_SCHEMA);
            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.CreatedAt)
                .HasColumnName("created_at")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(e => e.MesaAyudaId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("mesa_ayuda_id");

            builder.Property(e => e.OpenProjectId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("open_project_id");

            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
