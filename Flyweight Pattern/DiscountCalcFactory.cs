using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    class DiscountCalcFactory
    {
        public IDiscountCalaculator GetDiscountCalc(string calcType)
        {
            IDiscountCalaculator calaculator = null;

            Dictionary<string, IDiscountCalaculator> calList = new Dictionary<string, IDiscountCalaculator>();

            if (calList.ContainsKey(calcType))
            {
                return calList[calcType];
            }
            else
            {
                switch (calcType)
                {
                    case "day":
                        calaculator = new DayDiscountCalc();
                        calList.Add(calcType, calaculator);
                        break;
                    case "item":
                        calaculator = new ItemsDiscountCalc();
                        calList.Add(calcType, calaculator);

                        break;
                }
                return calaculator;

            }

        }
    }
}
