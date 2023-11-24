using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    public class BattleActionAffected : BaseEntity
    {
        [Key]
        public int BattleActionAffectedId { get; set; }
        public int BattleActionId { get; set; }
        public int CreatureId { get; set; }
        public string Type { get; set; }


        public virtual Battle? Battle { get; set; }
        [ForeignKey(nameof(BattleActionId))]
        public virtual BattleAction? BattleAction { get; set; }
        [ForeignKey(nameof(CreatureId))]
        public virtual Creature? Creature { get; set; }
    }
}
