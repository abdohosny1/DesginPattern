using System;

namespace ProplrmFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cardNumber, bankCode;
            BankA bankA=new BankA();
            BankB bankB=new BankB();
            
            Console.WriteLine("Enter Your Card Number");
            cardNumber= Console.ReadLine();
            bankCode = cardNumber.Substring(0, 6);

            switch(bankCode)
            {
                case "123456": Console.WriteLine(bankA.withDrow()); break;
                case "11111": Console.WriteLine(bankB.withDrow()); break; 
            }
        }
    }
}
