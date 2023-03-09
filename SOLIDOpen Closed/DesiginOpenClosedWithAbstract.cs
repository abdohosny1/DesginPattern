//using System;
//using System.Xml.Linq;

//namespace SOLIDOpen_Closed
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ManagerEmployee Emp1 = new ManagerEmployee();
//            Emp1.Name = "Mohammed Reda";
//            Emp1.ID = "123";
//            Emp1.BasicSalary = 900;

//            ReqularEmployee Emp2 = new ReqularEmployee();
//            Emp2.Name = "abdo Reda";
//            Emp2.ID = "321";
//            Emp2.BasicSalary = 900;


//            Console.WriteLine(Emp1.ToString()
//            + Environment.NewLine
//            + "Bonus: " + Emp1.CalcHoursBouns(5).ToString()
//            );

//            Console.WriteLine(Emp2.ToString()
//         + Environment.NewLine
//         + "Bonus: " + Emp2.CalcHoursBouns(5).ToString()
//         );

//            Console.ReadKey();
//        }

//        public abstract class Employee
//        {
//            public string ID { get; set; }
//            public string Name { get; set; }
//            public decimal BasicSalary { get; set; }
//            public abstract decimal CalcHoursBouns(decimal hours);

//            public override string ToString()
//            {
//                return $"Employee Id: {ID}, Name: {Name}";
//            }
//        }

//        public class ReqularEmployee : Employee
//        {
//            public override decimal CalcHoursBouns(decimal hours)
//            {
//                return (((BasicSalary / 30) / 8) * hours) * 2;
//            }
//        }

//        public class ManagerEmployee : Employee
//        {
//            public override decimal CalcHoursBouns(decimal hours)
//            {
//                return ((BasicSalary / 30) / 8) * hours;
//            }
//        }
//    }
//}
