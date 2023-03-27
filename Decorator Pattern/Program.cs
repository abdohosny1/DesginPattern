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


            Student student1=new Student();
         //   student1.SetName("Test");
           
            WriteColorLine(student1.GetName());

Student studentstudent2 =new Student(name:"abdo",age:20);

            WriteColorLine(studentstudent2.GetName());

            Emp e=new Emp();
            e.Age = 20;
            e.Name = "emp";
            e.print();


        }
    }

    
}
