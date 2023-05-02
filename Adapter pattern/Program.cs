using System;

namespace Adapter_pattern
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
            Employee employee = new Employee { Name = "Test", BasicSalary = 1000 };
            MachineOperator machineOperator= new MachineOperator { Name= "Machine",BasicSalary=2000,ShiftCode=12 };

            SalaryAdapter salaryCalculator=new SalaryAdapter();

            var res=salaryCalculator.calaSalary(employee);
            var resMachine=salaryCalculator.calaSalary(machineOperator);

            WriteColorLine(res.ToString(), ConsoleColor.Green);
            WriteColorLine(resMachine.ToString(), ConsoleColor.Red);
        }
    }
}
