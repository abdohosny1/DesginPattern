using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Inventory
    {
        public bool CheckItemQuentity(string ItemId,double quentity)
        {
            return quentity > 100;
        }
    }
}
