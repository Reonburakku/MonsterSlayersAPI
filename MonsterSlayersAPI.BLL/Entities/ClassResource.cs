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
    [PrimaryKey(nameof(ClassId), nameof(LanguageId),nameof(ResourceTypeId))]
    public class ClassResource : BaseEntity
    {
        public int ClassId { get; set; }
        public int LanguageId { get; set; }
        public int ResourceTypeId { get; set; }
        public string Value { get; set; }


        [ForeignKey(nameof(ClassId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Class? Class { get; set; }
        [ForeignKey(nameof(LanguageId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Language? Language { get; set; }
        [ForeignKey(nameof(ResourceTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual ResourceType? ResourceType { get; set; }
    }
}
