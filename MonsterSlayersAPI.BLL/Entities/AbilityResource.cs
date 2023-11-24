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
    [PrimaryKey(nameof(AbilityId), nameof(LanguageId),nameof(ResourceTypeId))]
    public class AbilityResource : BaseEntity
    {
        public int AbilityId { get; set; }
        public int LanguageId { get; set; }
        public int ResourceTypeId { get; set; }
        public string Value { get; set; }


        [ForeignKey(nameof(AbilityId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Ability? Ability { get; set; }
        [ForeignKey(nameof(LanguageId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Language? Language { get; set; }
        [ForeignKey(nameof(ResourceTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual ResourceType? ResourceType { get; set; }
    }
}
