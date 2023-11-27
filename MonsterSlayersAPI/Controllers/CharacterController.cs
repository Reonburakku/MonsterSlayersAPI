using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Services;

namespace MonsterSlayersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private ICharacterService characterService;
        public CharacterController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }

        [HttpPost]
        [Route("GoToZone")]
        public async Task<IActionResult> GoToZone([FromBody] SetCharacterZoneIdModel model)
        {
            var response = await characterService.SetCharacterZoneId(model);
            return Ok(response);
        }
    }
}
