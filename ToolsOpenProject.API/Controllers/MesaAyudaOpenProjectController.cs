using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Services;

namespace ToolsOpenProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaAyudaOpenProjectController : ControllerBase
    {
        private readonly IMesaAyudaOpenProjectService _mesaAyudaOpenProjectService;
        public MesaAyudaOpenProjectController(IMesaAyudaOpenProjectService mesaAyudaOpenProjectService)
        {
            _mesaAyudaOpenProjectService = mesaAyudaOpenProjectService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mesaAyudaOpenProjectService.GetMesaAyudaOpenProjectAsync();
            return Ok(result);
        }
    }
}
