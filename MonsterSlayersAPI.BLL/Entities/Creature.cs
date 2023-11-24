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


        public virtual ICollection<Character>? Characters { get; set; }
        public virtual ICollection<Monster>? Monsters { get; set; }
        public virtual ICollection<BattleParticipant>? BattleParticipants { get; set; }
        public virtual ICollection<BattleActionAffected>? BattleActionAffected { get; set; }
    }
}
