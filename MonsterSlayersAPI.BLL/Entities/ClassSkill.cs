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
    [PrimaryKey(nameof(ClassId), nameof(SkillId))]
    public class ClassSkill : BaseEntity
    {
        public int ClassId { get; set; }
        public int SkillId { get; set; }
        public double Rate { get; set; }


        [ForeignKey(nameof(ClassId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Class? Class { get; set; }
        [ForeignKey(nameof(SkillId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Skill? Skill { get; set; }

    }
}