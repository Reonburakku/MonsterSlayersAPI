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
    [PrimaryKey(nameof(MonsterId), nameof(LanguageId),nameof(ResourceTypeId))]
    public class MonsterResource : BaseEntity
    {
        public int MonsterId { get; set; }
        public int LanguageId { get; set; }
        public int ResourceTypeId { get; set; }
        public string Value { get; set; }


        [ForeignKey(nameof(MonsterId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Monster Monster { get; set; }
        [ForeignKey(nameof(LanguageId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Language Language { get; set; }
        [ForeignKey(nameof(ResourceTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public ResourceType ResourceType { get; set; }
    }
}
