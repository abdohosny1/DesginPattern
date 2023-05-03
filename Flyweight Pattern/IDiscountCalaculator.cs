using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    interface IDiscountCalaculator
    {
        //   public IDiscountCalaculator GetDiscountCalc(string calcType);
        double GetDiscountValue(DateTime currentData, string ItemId = null);
    }
}
