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
    [PrimaryKey(nameof(MonsterId), nameof(SkillId))]
    public class MonsterSkill : BaseEntity
    {
        public int MonsterId { get; set; }
        public int SkillId { get; set; }


        [ForeignKey(nameof(MonsterId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Monster? Monster { get; set; }
        [ForeignKey(nameof(SkillId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Skill? Skill { get; set; }
    }
}
