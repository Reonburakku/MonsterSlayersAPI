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
        public int SkillId { get; set; }
        public int Value { get; set; }


        [ForeignKey(nameof(BattleId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Battle Battle { get; set; }
        [ForeignKey(nameof(SkillId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Skill Skill { get; set; }

        public List<BattleActionAffected> BattleActionAffecteds { get; set; }
    }
}
