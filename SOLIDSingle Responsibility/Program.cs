using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDSingle_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopingCart myCart = new ShopingCart();
            myCart.Add(new Item());
            SalesInvoice.CreateInvoice(myCart, 1);
            Console.WriteLine("Items Count " + myCart.GetItemsCount().ToString());
        }
    }

    public class Item
    {
        public string code;
        public double price;
        public double quantity;
    }
    public class Stock
    {
        public static List<Item> items = new List<Item> {
             new Item{code="456", price=12, quantity=2},
            new Item{code="123", price=10, quantity=10},
            new Item{code="789", price=14, quantity=1}
            };

        public static bool IsAvailableQuantity(Item item)
        {
            if (item.quantity < items.Where(x => x.code == item.code).FirstOrDefault().quantity)
            {
                return true;
            }
            else { return false; }
        }
    }
    public class ShopingCart
    {
        List<Item> cartItems = new List<Item>();
        public void RemoveFromCart(Item item)
        {
            if (cartItems.Contains(item)) cartItems.Remove(item);
        }
        public bool Add(Item item)
        {
            // check available quantity
            //  var quantityInStock = Stock.items.Where(x => x.code == item.code).FirstOrDefault().quantity;
            if (Stock.IsAvailableQuantity(item))
            {
                cartItems.Add(item); return true;
            }
            else { return false; }
        }

        public int GetItemsCount() { return cartItems.Count; }



    }

    public class SalesInvoice
    {
        public static void CreateInvoice(ShopingCart cart, int custId)
        {

            // calc total price
             var total = cart.Sum(x => x.price);
            // get customer data
            // save to database
            // print invoice
            PrintingManager.Print("print Invoice");
            // send invoice to customer email
            EmailService.send(new object());
        }
    }

    public class PrintingManager
    {
        public static void Print(string text) { }
    }

    public class EmailService
    {
        public static void send(object email) { }
    }

}
