using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Services;

namespace MonsterSlayersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : ControllerBase
    {
        private IMonsterService monsterService;
        public MonsterController(IMonsterService monsterService)
        {
            this.monsterService = monsterService;
        }

        [HttpPost]
        [Route("get-zone-monsters")]
        public async Task<IActionResult> GetMonstersByZoneId([FromBody] GetMonstersByZoneIdModel model)
        {
            var response = await monsterService.GetMonstersByZoneId(model);
            return Ok(response);
        }
    }
}
