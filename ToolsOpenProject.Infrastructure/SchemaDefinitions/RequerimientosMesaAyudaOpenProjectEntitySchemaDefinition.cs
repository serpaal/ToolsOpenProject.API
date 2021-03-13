using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ToolsOpenProject.Domain.Entities;

namespace ToolsOpenProject.Infrastructure.SchemaDefinitions
{
    public class RequerimientosMesaAyudaOpenProjectEntitySchemaDefinition : IEntityTypeConfiguration<RequerimientosMesaAyudaOpenProject>
    {
        public void Configure(EntityTypeBuilder<RequerimientosMesaAyudaOpenProject> entity)
        {
            entity.ToTable("requerimientos_mesa_ayuda_open_project");

            entity.HasIndex(e => new { e.NroReq, e.OpenProjectId }, "requerimientos_mesa_ayuda_open_proj_nro_req_open_project_id_key")
                .IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.ArchAdj).HasColumnName("arch_adj");

            entity.Property(e => e.CodURbl)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("cod_u_rbl");

            entity.Property(e => e.CreatedAt)
                .HasColumnName("created_at")
                .HasDefaultValueSql("now()");

            entity.Property(e => e.DescripReq)
                .HasMaxLength(25)
                .HasColumnName("descrip_req");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("estado");

            entity.Property(e => e.FechaSol).HasColumnName("fecha_sol");

            entity.Property(e => e.Justific)
                .IsRequired()
                .HasColumnName("justific");

            entity.Property(e => e.NombComp)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("nomb_comp");

            entity.Property(e => e.NroReq)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("nro_req");

            entity.Property(e => e.Observ).HasColumnName("observ");

            entity.Property(e => e.OpenProjectId)
                .HasMaxLength(25)
                .HasColumnName("open_project_id");

            entity.Property(e => e.OpenProjectStatus)
                .HasMaxLength(25)
                .HasColumnName("open_project_status");

            entity.Property(e => e.OpenProjectTitle)
                .HasMaxLength(250)
                .HasColumnName("open_project_title");

            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.Property(e => e.Username)
                .HasMaxLength(25)
                .HasColumnName("username")
                .HasDefaultValueSql("\"session_user\"()");
        }
    }
}
