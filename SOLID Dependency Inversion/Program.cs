using System;

namespace SOLID_Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail gmail = new Gmail();

            HotMail hotMail = new HotMail();
            WebService webService = new WebService();

            Notification n = new Notification(webService);

            //use construtor Injection
            n.send();

            //usee mothod Injection
            n.sendEmail(hotMail);

            //use prop Injection
            n.isend = gmail;
            n.sendEmailWithProp();


        }

    }

    public class Notification 
    {
        private  IsendNotification _isendNotification;


        //constrotor injection
        public Notification(IsendNotification isendNotification)
        {
            _isendNotification = isendNotification;
        }

        public void send() => _isendNotification.send();

        //method injection
        public void sendEmail(IsendNotification isendNotification) => isendNotification.send();

        //property Injection
        public IsendNotification isend { get; set; }

        public void sendEmailWithProp( ) => isend.send();



    }

    public interface IsendNotification
    {
      public void  send();
    }
    public class Gmail : IsendNotification
    {

        public string Address = "address";
        public string from = "from";
        public string ToAddress = "ToAddress";
        public void send() { Console.WriteLine("send Gmail"); }

    }

    public class HotMail : IsendNotification
    {
        public string Address = "address";
        public string from = "from";
        public string ToAddress = "ToAddress";
        public void send() { Console.WriteLine("send HotMail"); }

    }

    public class WebService : IsendNotification
    {
        public string Address = "address";
        public string from = "from";
        public string ToAddress = "ToAddress";
        public void send() { Console.WriteLine("send WebService"); }

    }
}
