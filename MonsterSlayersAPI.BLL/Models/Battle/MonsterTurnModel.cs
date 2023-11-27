using MonsterSlayersAPI.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Battle
{
    public class MonsterTurnModel
    {
        public int BattleId { get; set; }
        public int Round { get; set; }
        public int Turn { get; set; }
        public MonsterBattleModel MonsterModel { get; set; }
        public ICollection<BattleParticipant> BattleParticipants { get; set; }
        public int LanguageId { get; set; }
        public string Origin { get; set; }
        public bool Win { get; set; }
    }
}
