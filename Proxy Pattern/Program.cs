using System;

namespace Proxy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SMSServiceProxy sMSServiceProxy=new SMSServiceProxy();
            WriteColorLine(sMSServiceProxy.sendSms("123", "0112345",  " hello messsage 1"));
            WriteColorLine(sMSServiceProxy.sendSms("123", "0112345677", "hello messsage 2"));
            WriteColorLine(sMSServiceProxy.sendSms("123", "0112345677", "hello messsage 3"));
            WriteColorLine(sMSServiceProxy.sendSms("123", "0112345677", "hello messsage 4"));
            WriteColorLine(sMSServiceProxy.sendSms("123", "0112345677", "hello messsage 5"));
            WriteColorLine(sMSServiceProxy.sendSms("123", "0112345677", "hello messsage 6"));
            WriteColorLine(sMSServiceProxy.sendSms("123", "0112345677", "hello messsage 7"));
         


        }

        static void WriteColorLine(string text, ConsoleColor consoleColor = ConsoleColor.Green)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
        }
    }
}
