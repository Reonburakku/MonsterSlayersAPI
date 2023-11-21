using MonsterSlayersAPI.BLL.Entities.Base;
using MonsterSlayersAPI.BLL.Models.Request.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Request.Game
{
    public class GetBattleByIdModel : BaseRequestModel
    {
        public int Id { get; set; }
    }
}
