using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Utilities
{
    public static class GlobalData
    {
        public static Dictionary<string, object> Data { get; set; }
        static GlobalData()
        {
            Data = new Dictionary<string, object>();
        }
    }
}
