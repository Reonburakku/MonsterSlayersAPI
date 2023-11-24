using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Models.Battle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Result
{
    public class ParticipantResultModel
    {
        public int CreatureId { get; set; }
        public int Name { get; set; }
        public int Order { get; set; }
        public bool IsMonster { get; set; }
        public string? ParticipantData { get; set; }
        //public CharacterBattleModel? Character { get; set; }
        //public MonsterBattleModel? Monster { get; set; }
    }
}
