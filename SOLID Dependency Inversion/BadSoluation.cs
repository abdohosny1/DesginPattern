//using System;

//namespace SOLID_Dependency_Inversion
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Notification n = new Notification();
//            n.sendGmail();
//            n.sendHotMail();
//            n.sendWebService();
//        }

//    }

//    public class Notification
//    {
//        Gmail d = new Gmail();
//        HotMail h = new HotMail();
//        WebService w = new WebService();

//        public void sendGmail() => d.send();
//        public void sendHotMail() => h.send();
//        public void sendWebService() => w.send();

//    }
//    public class Gmail
//    {

//        public string Address = "address";
//        public string from = "from";
//        public string ToAddress = "ToAddress";
//        public void send() { Console.WriteLine("send Gmail"); }

//    }

//    public class HotMail
//    {
//        public string Address = "address";
//        public string from = "from";
//        public string ToAddress = "ToAddress";
//        public void send() { Console.WriteLine("send HotMail"); }

//    }

//    public class WebService
//    {
//        public string Address = "address";
//        public string from = "from";
//        public string ToAddress = "ToAddress";
//        public void send() { Console.WriteLine("send WebService"); }

//    }
//}
