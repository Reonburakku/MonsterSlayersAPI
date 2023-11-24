using Microsoft.EntityFrameworkCore;
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
    public class BattleAction : BaseEntity
    {
        [Key]
        public int BattleActionId { get; set; }
        public int BattleId { get; set; }
        public int AbilityId { get; set; }
        public double Value { get; set; }


        [ForeignKey(nameof(BattleId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Battle? Battle { get; set; }
        [ForeignKey(nameof(AbilityId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Ability? Ability { get; set; }

        public virtual ICollection<BattleActionAffected>? BattleActionAffecteds { get; set; }
    }
}
