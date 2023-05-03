using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    class DayDiscountCalc : IDiscountCalaculator
    {
        public double GetDiscountValue(DateTime currentData, string ItemId = null)
        {
            return 0.15;
        }
    }
}
