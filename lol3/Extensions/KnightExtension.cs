using lol3.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol3.Extensions
{
    public static class KnightExtension
    {
        public static int Armor (this Knight knight, int a)
        {
            knight.BattleRoar("roarrrrrrr");
            return a + 10;
        } 
    }
}
