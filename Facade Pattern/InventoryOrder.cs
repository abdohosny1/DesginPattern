using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class InventoryOrder
    {
        public string CreateOrder(ShoppingBasket shoppingBasket)
        {
            shoppingBasket.GetItems();
            return $"Order num is {Guid.NewGuid().ToString()}";
        }
    }
}
