using System;

namespace Flyweight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountCalcFactory discountFactory = new DiscountCalcFactory();
            var calculator = discountFactory.GetDiscountCalc("day");
            var val = calculator.GetDiscountValue(DateTime.Now.Date);
            WriteColorLine(val.ToString());
        }
        static void WriteColorLine(string text, ConsoleColor consoleColor = ConsoleColor.Green)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
        }
    }
}
