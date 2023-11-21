using Microsoft.AspNetCore.Mvc;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Models.Request.Parametrization;
using MonsterSlayersAPI.BLL.Models.Security;
using System.Reflection.PortableExecutable;

namespace MonsterSlayersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IBattleService battleService;
        public GameController(IBattleService battleService) 
        {
            this.battleService = battleService;
        }

        [HttpPost]
        [Route("GetBattleById")]
        public async Task<IActionResult> GetBattleByIdAsync([FromBody] GetBattleByIdModel model)
        {
            var zones = await battleService.GetBattleByIdAsync(model);
            return Ok(zones);
        }

        [HttpPost]
        [Route("GetZoneMonsters")]
        public async Task<IActionResult> GetMonstersByZoneId([FromBody] GetMonstersByZoneIdModel model)
        {
            var zones = await battleService.GetMonstersByZoneId(model);
            return Ok(zones);
        }

        [HttpPost]
        [Route("GoToZone")]
        public async Task<IActionResult> GoToZone([FromBody] SetCharacterZoneIdModel model)
        {
            var zones = await battleService.SetCharacterZoneId(model);
            return Ok(zones);
        }

        [HttpPost]
        [Route("StartBattle")]
        public async Task<IActionResult> StartBattle([FromBody] StartBattleModel model)
        {
            var zones = await battleService.StartBattle(model);
            return Ok(zones);
        }

        [HttpPost]
        [Route("Attack")]
        public async Task<IActionResult> UseHability([FromBody] UseHabilityModel model)
        {
            var zones = await battleService.UseHability(model);
            return Ok(zones);
        }

        [HttpPost]
        [Route("EndTurn")]
        public async Task<IActionResult> EndTurn([FromBody] EndTurnModel model)
        {
            var zones = await battleService.EndTurn(model);
            return Ok(zones);
        }
    }
}
