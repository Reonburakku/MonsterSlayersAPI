using MonsterSlayersAPI.BLL.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Request.Parametrization
{
    public class ResourceCreateModel
    {
        public int LanguageId { get; set; }
        public int ResourceTypeId { get; set; }
        public string Value { get; set; }
    }
}
