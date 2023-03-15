using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Person  1";
            person1.Age = 25;
            person1.idInfo = new IdInfo {  Id=200 };

            Person person2 = person1.DeepCop();

            Console.WriteLine("=======================Person  origin Value=======================");
            Console.WriteLine(person1.ToString());
            Console.WriteLine("=======================Person 2 origin Value=======================");
            Console.WriteLine(person2.ToString());

            person2.idInfo.Id = 1000;
            person1.idInfo.Id = 500;
            person2.Name = "update name Person 2";
            person1.Name = "update name Person 1";
            person1.Age = 4;
            person2.Age = 5;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================Person After change =======================");
            Console.WriteLine(person1.ToString());
            Console.WriteLine("=======================Person 2 After change =======================");
            Console.WriteLine(person2.ToString());
        }
    }
}
