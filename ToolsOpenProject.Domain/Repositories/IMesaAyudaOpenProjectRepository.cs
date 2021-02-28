using System.Collections.Generic;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Entities;

namespace ToolsOpenProject.Domain.Repositories
{
    public interface IMesaAyudaOpenProjectRepository : IRepository
    {
        Task<IEnumerable<MesaAyudaOpenProject>> GetAsync();
        Task<MesaAyudaOpenProject> GetAsync(int id);
        MesaAyudaOpenProject Add(MesaAyudaOpenProject record);
        MesaAyudaOpenProject Update(MesaAyudaOpenProject record);
    }
}
