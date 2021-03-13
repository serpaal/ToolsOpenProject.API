using System.Collections.Generic;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Responses;

namespace ToolsOpenProject.Domain.Services
{
    public interface IRequerimientosMesaAyudaOpenProjectService
    {
        Task<IEnumerable<RequerimientosMesaAyudaOpenProjectResponse>> GetRequerimientosMesaAyudaOpenProjectAsync();
        Task<int> SetRequerimientosFromJson(string json);
    }
}
