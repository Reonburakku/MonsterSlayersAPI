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
    [PrimaryKey(nameof(CharacterId), nameof(SkillId))]
    public class CharacterSkill : BaseEntity
    {
        public int CharacterId { get; set; }
        public int SkillId { get; set; }
        public int Total { get; set; }
        public int Real { get; set; }


        [ForeignKey(nameof(CharacterId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Character? Character { get; set; }
        [ForeignKey(nameof(SkillId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Skill? Skill { get; set; }
    }
}
