using MonsterSlayersAPI.BLL.Models.Result.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Result
{
    public class BattleResultModel : BaseResultModel
    {
        public int BattleId { get; set; }
        public ZoneResultModel ZoneResultModel { get; set; }
        public List<ParticipantResultModel> Participants { get; set; }
    }
}
