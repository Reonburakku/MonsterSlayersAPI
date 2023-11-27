using Azure;
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
            var response = await battleService.GetBattleByIdAsync(model);
            return Ok(response);
        }

        [HttpPost]
        [Route("StartBattle")]
        public async Task<IActionResult> StartBattle([FromBody] StartBattleModel model)
        {
            var response = await battleService.StartBattle(model);
            return Ok(response);
        }

        [HttpPost]
        [Route("Attack")]
        public async Task<IActionResult> UseAbility([FromBody] UseAbilityModel model)
        {
            var response = await battleService.UseAbility(model);
            return Ok(response);
        }

        [HttpPost]
        [Route("EndTurn")]
        public async Task<IActionResult> EndTurn([FromBody] EndTurnModel model)
        {
            var response = await battleService.EndTurn(model);
            return Ok(response);
        }
    }
}
