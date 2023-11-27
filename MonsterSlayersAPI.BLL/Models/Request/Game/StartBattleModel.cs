using MonsterSlayersAPI.BLL.Models.Request.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Request.Game
{
    public class StartBattleModel : BaseRequestModel
    {
        public int ZoneId { get; set; }

        public List<int> CharactersIds { get; set; }
        public List<int> MonstersIds { get; set; }
    }
}
