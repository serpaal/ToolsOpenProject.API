using System.Collections.Generic;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Entities;

namespace ToolsOpenProject.Domain.Repositories
{
    public interface IRequerimientosMesaAyudaOpenProjectRepository : IRepository
    {
        Task<IEnumerable<RequerimientosMesaAyudaOpenProject>> GetAsync();
        Task<RequerimientosMesaAyudaOpenProject> GetAsync(int id);
        RequerimientosMesaAyudaOpenProject Add(RequerimientosMesaAyudaOpenProject record);
        RequerimientosMesaAyudaOpenProject Update(RequerimientosMesaAyudaOpenProject record);
        Task<int> SetRequerimientosFromJson(string json);
    }
}
