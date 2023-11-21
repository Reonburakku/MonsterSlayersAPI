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
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(900)")]
        public string ASPUserId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Character>? Characters { get; set; }

    }
}
