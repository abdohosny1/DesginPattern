using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class ShoppingBasket
    {
        private List<BasketItem> basketItems = new List<BasketItem>();

        public void AddItem(BasketItem item)
        {
            basketItems.Add(item);
        }

        public void RemoveOneItem(string id)
        {
            var item = basketItems.SingleOrDefault(x => x.ItemId == id);
            if (item.Quantity > 0) item.Quantity = item.Quantity - 1;
        }

        public List<BasketItem> GetItems() { return basketItems; }
    }
}
