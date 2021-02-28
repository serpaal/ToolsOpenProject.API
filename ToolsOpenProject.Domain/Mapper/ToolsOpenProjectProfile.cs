using AutoMapper;
using ToolsOpenProject.Domain.Entities;
using ToolsOpenProject.Domain.Responses;

namespace ToolsOpenProject.Domain.Mapper
{
    public class ToolsOpenProjectProfile : Profile
    {
        public ToolsOpenProjectProfile()
        {
            CreateMap<MesaAyudaOpenProject, MesaAyudaOpenProjectResponse>();
        }
    }
}
