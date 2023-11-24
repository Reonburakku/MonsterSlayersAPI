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
    [PrimaryKey(nameof(ClassId), nameof(AbilityId))]
    public class ClassAbility : BaseEntity
    {
        public int ClassId { get; set; }
        public int AbilityId { get; set; }


        [ForeignKey(nameof(ClassId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Class? Class { get; set; }
        [ForeignKey(nameof(AbilityId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Ability? Ability { get; set; }
    }
}
