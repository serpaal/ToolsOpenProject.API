using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Entities;
using ToolsOpenProject.Domain.Repositories;
using ToolsOpenProject.Domain.Responses;

namespace ToolsOpenProject.Domain.Services
{
    public class MesaAyudaOpenProjectService : IMesaAyudaOpenProjectService
    {
        private readonly IMesaAyudaOpenProjectRepository _mesaAyudaOpenProjectRepository;
        private readonly IMapper _mesaAyudaOpenProjectMapper;
        
        public MesaAyudaOpenProjectService(IMesaAyudaOpenProjectRepository mesaAyudaOpenProjectRepository, IMapper mesaAyudaOpenProjectMapper)
        {
            _mesaAyudaOpenProjectRepository = mesaAyudaOpenProjectRepository;
            _mesaAyudaOpenProjectMapper = mesaAyudaOpenProjectMapper;
        }
        public async Task<IEnumerable<MesaAyudaOpenProjectResponse>> GetMesaAyudaOpenProjectAsync()
        {
            var result = await _mesaAyudaOpenProjectRepository.GetAsync();
            return result.Select(x => _mesaAyudaOpenProjectMapper.Map<MesaAyudaOpenProjectResponse>(x));
        }
    }
}
