using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol3.classes
{
    interface IMoney
    {
        public double USD { get; set; }
        public int Budget { get; set; }
        public double ConvertToUSD();
    }
    class EUR : IMoney
    {
        public double USD { get ; set ; }
        public int Budget { get ; set ; }
        public EUR(double usd, int budget)
        {
            USD = usd;
            Budget = budget;
        }
        public double ConvertToUSD()
        {
            return Budget / USD;

        }
    }
    class UAH : IMoney
    {
        public double USD { get ; set ; }
        public int Budget { get ; set ; }
        public UAH(double usd, int budget)
        {
            USD = usd;
            Budget = budget;
        }
        public double ConvertToUSD()
        {
           return Budget / USD;
        }
    }
}
