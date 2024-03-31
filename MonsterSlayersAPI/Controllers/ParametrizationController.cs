using Microsoft.AspNetCore.Mvc;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models.Request.Base;
using MonsterSlayersAPI.BLL.Models.Request.Parametrization;

namespace MonsterSlayersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrizationController : ControllerBase
    {
        private IParametrizationService paramService;
        public ParametrizationController(IParametrizationService paramService)
        {
            this.paramService = paramService;
        }

        [HttpGet]
        [Route("alive")]
        public async Task<IActionResult> Alive()
        {
            var zones = await paramService.Alive();
            return Ok(zones);
        }

        [HttpGet]
        [Route("get-all-zones")]
        public async Task<IActionResult> GetAllZones(BaseRequestModel model)
        {
            var zones = await paramService.GetAllZonesAsync(model);
            return Ok(zones);
        }

        [HttpGet]
        [Route("get-zone-by-id")]
        public async Task<IActionResult> GetZoneById([FromBody] GetZoneByIdModel model)
        {
            var zones = await paramService.GetZoneByIdAsync(model);
            return Ok(zones);
        }

        [HttpPost]
        [Route("create-zone")]
        public async Task<IActionResult> CreateZone([FromBody] CreateZoneModel model)
        {
            var zones = await paramService.CreateZoneAsync(model);
            return Ok(zones);
        }
    }
}
