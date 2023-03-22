using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Abstract_Factory_Pattern

{
    internal class BankFactory : IBankFactory
    {
        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "123456": return new BankA();
                case "111111": return new BankB(); 
            }
            return null;
        }

        public IPaymentCard GetPaymentCard(string cardNumber)
        {
            switch (cardNumber)
            {
                case "12": return new Visa();
                case "55": return new MasterCard();
            }
            return null;
        }
    }
}
