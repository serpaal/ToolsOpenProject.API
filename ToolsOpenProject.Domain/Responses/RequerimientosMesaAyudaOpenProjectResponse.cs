using System;

namespace ToolsOpenProject.Domain.Responses
{
    public class RequerimientosMesaAyudaOpenProjectResponse
    {
        public int Id { get; set; }
        public string NroReq { get; set; }
        public DateTime FechaSol { get; set; }
        public string NombComp { get; set; }
        public string DescripReq { get; set; }
        public string Justific { get; set; }
        public string CodURbl { get; set; }
        public string Observ { get; set; }
        public string ArchAdj { get; set; }
        public string Estado { get; set; }
        public string OpenProjectId { get; set; }
        public string OpenProjectTitle { get; set; }
        public string OpenProjectStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Username { get; set; }
    }
}
