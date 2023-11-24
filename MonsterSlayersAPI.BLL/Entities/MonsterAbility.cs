using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    [PrimaryKey(nameof(MonsterId), nameof(AbilityId))]
    public class MonsterAbility : BaseEntity
    {
        public int MonsterId { get; set; }
        public int AbilityId { get; set; }


        [ForeignKey(nameof(MonsterId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Monster? Monster { get; set; }
        [ForeignKey(nameof(AbilityId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Ability? Ability { get; set; }
    }
}
