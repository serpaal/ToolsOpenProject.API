using System.Collections.Generic;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Responses;

namespace ToolsOpenProject.Domain.Services
{
    public interface IMesaAyudaOpenProjectService
    {
        Task<IEnumerable<MesaAyudaOpenProjectResponse>> GetMesaAyudaOpenProjectAsync();
    }
}
