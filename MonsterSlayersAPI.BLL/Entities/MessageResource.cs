using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    [PrimaryKey(nameof(LanguageId), nameof(MessageName))]
    public class MessageResource : BaseEntity
    {
        public int LanguageId { get; set; }
        public string MessageName { get; set; }
        public string Value { get; set; }


        [ForeignKey(nameof(LanguageId))]
        public virtual Language? Language { get; set; }
    }
}
