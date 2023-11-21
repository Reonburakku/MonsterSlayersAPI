using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    public class Creature : BaseEntity
    {
        [Key]
        public int CreatureId { get; set; }


        public ICollection<Character>? Characters { get; set; }
        public ICollection<Monster>? Monsters { get; set; }
        public ICollection<BattleParticipant> BattleParticipants { get; set; }
        public ICollection<BattleActionAffected>? BattleActionAffected { get; set; }
    }
}
