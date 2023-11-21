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
    [PrimaryKey(nameof(SkillId), nameof(LanguageId),nameof(ResourceTypeId))]
    public class SkillResource : BaseEntity
    {
        public int SkillId { get; set; }
        public int LanguageId { get; set; }
        public int ResourceTypeId { get; set; }
        public string Value { get; set; }


        [ForeignKey(nameof(SkillId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Skill Skill { get; set; }
        [ForeignKey(nameof(LanguageId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Language Language { get; set; }
        [ForeignKey(nameof(ResourceTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public ResourceType ResourceType { get; set; }
    }
}
