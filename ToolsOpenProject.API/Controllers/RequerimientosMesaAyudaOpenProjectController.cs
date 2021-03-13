using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Services;

namespace ToolsOpenProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequerimientosMesaAyudaOpenProjectController : ControllerBase
    {
        private readonly IRequerimientosMesaAyudaOpenProjectService _requerimientosMesaAyudaOpenProjectService;
        public RequerimientosMesaAyudaOpenProjectController(IRequerimientosMesaAyudaOpenProjectService requerimientosMesaAyudaOpenProjectService)
        {
            _requerimientosMesaAyudaOpenProjectService = requerimientosMesaAyudaOpenProjectService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _requerimientosMesaAyudaOpenProjectService.GetRequerimientosMesaAyudaOpenProjectAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string requerimientos)
        {
            var result = await _requerimientosMesaAyudaOpenProjectService.SetRequerimientosFromJson(requerimientos);
            return Ok(result);
        }
    }
}
