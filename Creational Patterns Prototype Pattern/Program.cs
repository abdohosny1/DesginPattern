using System;

namespace Creational_Patterns_Prototype_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePrototype tempEmp = new TempEmployee();
            tempEmp.Name = "Temp emp 1";
            tempEmp.Id = 1;
            tempEmp.EmpAddress = new Address { City = "city 1", Bulliding = "Bulliding 1", StreetName = "street Name 1" };

            EmployeePrototype tempEmp1 = tempEmp.DeepCopy();

            Console.WriteLine("=======================Temp Emp origin Value=======================");
            Console.WriteLine(tempEmp.ToString());
            Console.WriteLine("=======================Temp Emp 1 origin Value=======================");
            Console.WriteLine(tempEmp1.ToString());

            tempEmp1.EmpAddress.City = "update city temp 1";
            tempEmp.EmpAddress.City = "update city temp ";
            tempEmp.Name = "update name temp";
            tempEmp1.Name = "update name temp 1";
            tempEmp.Id = 4;
            tempEmp1.Id = 5;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================Temp Emp After change =======================");
            Console.WriteLine(tempEmp.ToString());
            Console.WriteLine("=======================Temp Emp 1 After change =======================");
            Console.WriteLine(tempEmp1.ToString());


        }
    }
}
