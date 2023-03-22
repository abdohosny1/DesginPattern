using System;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardNumber, bankCode;
            BankFactory bankFactory = new BankFactory();

            WriteColorLine("Enter Your Card Number", ConsoleColor.Cyan);
            cardNumber = Console.ReadLine();
            bankCode = cardNumber.Substring(0, 6);

            IBank bank = bankFactory.GetBank(bankCode);
            IPaymentCard paymentCard = bankFactory.GetPaymentCard("12");

            WriteColorLine(paymentCard.GetName());
            WriteColorLine(bank.withDrow());
        }

        static void WriteColorLine(string text, ConsoleColor consoleColor = ConsoleColor.Green)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
        }
    }
}
