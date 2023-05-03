using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // this the proplem becuace the clinet all make this action and i have dupliacted data and the make share to all object

            //// create basket
            //ShoppingBasket basket = new ShoppingBasket();
            //BasketItem item = new BasketItem();
            //item.ItemId = "123"; item.ItemPrice = 50; item.Quantity = 3;

            //// check stock
            //Inventory inventory = new Inventory();
            //if (inventory.CheckItemQuentity(item.ItemId, item.Quantity))
            //    basket.AddItem(item);

            //// Create Inventory Order
            //InventoryOrder inventoryOrder = new InventoryOrder();
            //inventoryOrder.CreateOrder(basket);

            //// Create Invoice
            //PurchaseInvoice invoice = new PurchaseInvoice();
            //var inv = invoice.CreateInvoic(basket, "address: 132, id=456, email=xyz");

            //// Payment
            //PaymentProcessor payment = new PaymentProcessor();
            //payment.HandlePayment(inv.netTotal, "acc=123456789");

            //// Send SMS
            //SmsNotification sms = new SmsNotification();
            //sms.SendSms("123", "Invoice Created");


            // create basket
            ShoppingBasket basket = new ShoppingBasket();
            basket.AddItem(new BasketItem { ItemId="123",ItemPrice=50,Quantity=3});
            basket.AddItem(new BasketItem { ItemId="456",ItemPrice=40,Quantity=4});
            basket.AddItem(new BasketItem { ItemId="789",ItemPrice=90,Quantity=5});

            PurchaseOrder purchaseOrder = new PurchaseOrder();
            purchaseOrder.CreateOrder(basket, "name:abdo,bank:12345679,phone:01236456855");
        }
    }
}
