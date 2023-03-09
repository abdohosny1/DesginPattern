//using System;
//using System.Xml.Linq;

//namespace SOLIDOpen_Closed
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee Emp1 = new Employee();
//            Emp1.Name = "Mohammed Reda";
//            Emp1.ID = "123";
//            Emp1.BasicSalary = 900;
//            Emp1.EmpType = "Manager";

//            Employee Emp2 = new Employee();
//            Emp2.Name = "abdo Reda";
//            Emp2.ID = "321";
//            Emp2.BasicSalary = 400;
//            Emp2.EmpType = "reqular";


//            Console.WriteLine(Emp1.ToString()
//            + Environment.NewLine
//            + "Bonus: " + Emp1.CalcHoursBouns(5, Emp1.EmpType).ToString()
//            );

//            Console.WriteLine(Emp2.ToString()
//         + Environment.NewLine
//         + "Bonus: " + Emp2.CalcHoursBouns(5, Emp2.EmpType).ToString()
//         );

//            Console.ReadKey();
//        }

//        public class Employee
//        {
//            public string ID { get; set; }
//            public string Name { get; set; }
//            public string EmpType { get; set; }
//            public decimal BasicSalary { get; set; }
//            public decimal CalcHoursBouns(decimal hours, string empType)
//            {
//                if (EmpType == "Manager")
//                {
//                    return (((BasicSalary / 30) / 8) * hours) * 2;
//                }
//                else
//                {
//                    return ((BasicSalary / 30) / 8) * hours;
//                }
//            }
//            public override string ToString()
//            {
//                return $"Employee Id: {ID}, Name: {Name}";
//            }
//        }
//    }
//}
