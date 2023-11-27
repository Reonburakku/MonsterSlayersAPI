using MonsterSlayersAPI.BLL.Models.Request.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Services
{
    public interface ICharacterService
    {
        Task<bool> SetCharacterZoneId(SetCharacterZoneIdModel model);
    }
}
