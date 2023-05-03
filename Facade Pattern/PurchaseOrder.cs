using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    //this class desgin Facade Pattern
    class PurchaseOrder
    {
        public bool CreateOrder(ShoppingBasket basket,string userInfo)
        {

            bool IsAvaliable = true;

            foreach (var item in basket.GetItems())
            {
                // check stock
                Inventory inventory = new Inventory();
                if (!inventory.CheckItemQuentity(item.ItemId, item.Quantity)) IsAvaliable = false;
            }

            if (IsAvaliable)
            {
                // Create Inventory Order
                InventoryOrder inventoryOrder = new InventoryOrder();
                inventoryOrder.CreateOrder(basket);

                // Create Invoice
                PurchaseInvoice invoice = new PurchaseInvoice();
                var inv = invoice.CreateInvoic(basket, "address: 132, id=456, email=xyz");

                // Payment
                PaymentProcessor payment = new PaymentProcessor();
                payment.HandlePayment(inv.netTotal, "acc=123456789");

                // Send SMS
                SmsNotification sms = new SmsNotification();
                sms.SendSms("123", "Invoice Created");
                return true;
            }
            else { return false; }

          
        }
    }
}
