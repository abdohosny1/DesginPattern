using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class PurchaseInvoice
    {
        public double discount =0;
        public double totalAmount =0;
        public double netTotal =0;

        public PurchaseInvoice CreateInvoic(ShoppingBasket shoppingBasket,string custimerInfo)
        {
            var invoic = new PurchaseInvoice();
            var items = shoppingBasket.GetItems();

            foreach (BasketItem item in items)
            {
                invoic.totalAmount += item.ItemPrice * item.Quantity;
            }
            //applay discount
            if (items.Count > 5) invoic.discount = 20;

            return invoic;

        }
    }
}
