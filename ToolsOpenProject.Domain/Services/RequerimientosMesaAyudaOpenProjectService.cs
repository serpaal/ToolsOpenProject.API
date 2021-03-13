using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Entities;
using ToolsOpenProject.Domain.Repositories;
using ToolsOpenProject.Domain.Responses;

namespace ToolsOpenProject.Domain.Services
{
    public class RequerimientosMesaAyudaOpenProjectService : IRequerimientosMesaAyudaOpenProjectService
    {
        private readonly IRequerimientosMesaAyudaOpenProjectRepository _requerimientosMesaAyudaOpenProjectRepository;
        private readonly IMapper _mapper;
        
        public RequerimientosMesaAyudaOpenProjectService(IRequerimientosMesaAyudaOpenProjectRepository requerimientosMesaAyudaOpenProjectRepository, IMapper mapper)
        {
            _requerimientosMesaAyudaOpenProjectRepository = requerimientosMesaAyudaOpenProjectRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<RequerimientosMesaAyudaOpenProjectResponse>> GetRequerimientosMesaAyudaOpenProjectAsync()
        {
            var result = await _requerimientosMesaAyudaOpenProjectRepository.GetAsync();
            return result.Select(x => _mapper.Map<RequerimientosMesaAyudaOpenProjectResponse>(x));
        }

        public async Task<int> SetRequerimientosFromJson(string json){
            return await _requerimientosMesaAyudaOpenProjectRepository.SetRequerimientosFromJson(json);
        }
    }
}
