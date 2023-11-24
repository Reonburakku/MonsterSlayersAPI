using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Utilities
{
    public static class UtilityFunctions
    {
        public static bool IsCritic(int critRate)
        {
            int random = Random.Shared.Next(critRate, 101);
            return random >= 100;
        }
        public static int DiceDamage(int dice, int diceCount)
        {
            int damage = 0;
            for (int i = 0; i < diceCount; i++) {
                damage += Random.Shared.Next(1, dice + 1);
            }
            return damage;
        }
        public static double AplyResistance(int damage, double resistance)
        {
            return damage - (damage * resistance / 100);
        }
    }
}
