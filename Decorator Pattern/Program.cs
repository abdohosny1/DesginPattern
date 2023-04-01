using Decorator_Pattern.Decorator;
using System;

namespace Decorator_Pattern
{
    internal class Program
    {
        static void WriteColorLine(string text, ConsoleColor consoleColor = ConsoleColor.Green)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {

            ConcereteSMSService sMSService=new ConcereteSMSService();
            NotificationEmailDecorator notificationEmailDecorator= new NotificationEmailDecorator();    

            notificationEmailDecorator.setService(sMSService);
            WriteColorLine(notificationEmailDecorator.sendSMS("123","012234455","message 1"));

            SMSServiceProxy sMSServiceProxy = new SMSServiceProxy();
            WriteColorLine(sMSServiceProxy.sendSms("123", "0112345", " hello messsage 1"));



        }
    }

    
}
