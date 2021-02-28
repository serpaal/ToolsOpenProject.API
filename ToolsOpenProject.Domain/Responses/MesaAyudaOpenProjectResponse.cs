using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsOpenProject.Domain.Responses
{
    public class MesaAyudaOpenProjectResponse
    {
        public int Id { get; set; }
        public string MesaAyudaId { get; set; }
        public string OpenProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
