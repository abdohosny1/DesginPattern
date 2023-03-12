//using System;

//namespace SOLID_Interface_Segregation
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }

//        public class CashOrder : IOrder
//        {
//            public void InsallmentOrder()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessCashInvoice()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessCreditInvoice()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessOnlinePaymentInvoice()
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public class OnlineOrder : IOrder
//        {
//            public void InsallmentOrder()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessCashInvoice()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessCreditInvoice()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessOnlinePaymentInvoice()
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public class InsatllmentOrder : IOrder
//        {
//            public void InsallmentOrder()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessCashInvoice()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessCreditInvoice()
//            {
//                throw new NotImplementedException();
//            }

//            public void ProcessOnlinePaymentInvoice()
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public interface IOrder
//        {

//            void ProcessCashInvoice();
//            void ProcessCreditInvoice();
//            void ProcessOnlinePaymentInvoice();

//            void InsallmentOrder();
//        }
//    }
//}
