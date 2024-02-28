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
        private IParametrizationService zoneService;
        public ParametrizationController(IParametrizationService zoneService)
        {
            this.zoneService = zoneService;
        }

        [HttpGet]
        [Route("get-all-zones")]
        public async Task<IActionResult> GetAllZones(BaseRequestModel model)
        {
            var zones = await zoneService.GetAllZonesAsync(model);
            return Ok(zones);
        }

        [HttpGet]
        [Route("get-zone-by-id")]
        public async Task<IActionResult> GetZoneById([FromBody] GetZoneByIdModel model)
        {
            var zones = await zoneService.GetZoneByIdAsync(model);
            return Ok(zones);
        }

        [HttpPost]
        [Route("create-zone")]
        public async Task<IActionResult> CreateZone([FromBody] CreateZoneModel model)
        {
            var zones = await zoneService.CreateZoneAsync(model);
            return Ok(zones);
        }
    }
}
