using System;
using System.Threading.Tasks;

namespace Creational_Patterns_Singleton_Pattern
{
    class Program
    {
        //test using multiThreading
        static void Main(string[] args)
        {

            Task task1 = Task.Factory.StartNew(() =>
            {
                Counter c1 = Counter.CreateInstance();
                c1.Add();
                Console.WriteLine("counter 1 = " + c1.count);
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                Counter c2 = Counter.CreateInstance();
                c2.Add();
                Console.WriteLine("counter 2 = " + c2.count);
   
            });

            Console.ReadKey();
         
        }

        //tset using single thread

        //static void Main(string[] args)
        //{
        //    Counter c1 = Counter.CreateInstance();
        //    Counter c2 = Counter.CreateInstance();
        //    Console.WriteLine("counter 1 = " + c1.count);
        //    Console.WriteLine("counter 2 = " + c2.count);
        //    c1.Add();
        //    c2.Add();
        //    Console.WriteLine(" counter 1 after add = " + c1.count);
        //    Console.WriteLine("counter 2 after add = " + c2.count);
        //    c1.Add();
        //    Console.WriteLine(" counter 1 after add again = " + c1.count);
        //    Console.WriteLine("counter 2  = " + c2.count);
        //}
    }
}
