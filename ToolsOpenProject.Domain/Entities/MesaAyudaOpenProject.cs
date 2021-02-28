using System;

namespace ToolsOpenProject.Domain.Entities
{
    public class MesaAyudaOpenProject
    {
        public int Id { get; set; }
        public string MesaAyudaId { get; set; }
        public string OpenProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
