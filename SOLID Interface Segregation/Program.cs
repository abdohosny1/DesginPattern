using System;

namespace SOLID_Interface_Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class CashOrder : ICashOrder
        {
            public void ProcessCashInvoice()
            {
                throw new NotImplementedException();
            }

            public void shareMothod()
            {
                throw new NotImplementedException();
            }
        }

        public class OnlineOrder : IOnlineOrder
        {
            public void ProcessOnlinePaymentInvoice()
            {
                throw new NotImplementedException();
            }

            public void shareMothod()
            {
                throw new NotImplementedException();
            }
        }

        public class WorkONAllPay : IWorkONAllPay
        {
            public void ProcessCashInvoice()
            {
                throw new NotImplementedException();
            }

            public void ProcessCreditInvoice()
            {
                throw new NotImplementedException();
            }

            public void ProcessOnlinePaymentInvoice()
            {
                throw new NotImplementedException();
            }

            public void shareMothod()
            {
                throw new NotImplementedException();
            }
        }

        public interface IOrder
        {
            void shareMothod();
        }
        public interface ICashOrder : IOrder { void ProcessCashInvoice(); }
        public interface IOnlineOrder : IOrder { void ProcessOnlinePaymentInvoice(); }
        public interface ICreditOrderIOrder : IOrder { void ProcessCreditInvoice(); }


        public interface IWorkONAllPay:ICashOrder,IOnlineOrder,ICreditOrderIOrder { }

    }
}
