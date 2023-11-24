using MonsterSlayersAPI.BLL.Models.Result.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Result
{
    public class AttackResultModel : BaseResultModel
    {
        public int NewStaminaPoints { get; set; }
        public int NewManaPoints { get; set; }
    }
}
