using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    public class SalaryAdapter :SalaryCalculator
    {
        private Employee employee;

        public double calaSalary(MachineOperator machine)
        {
            employee=new Employee();
            employee.BasicSalary = machine.BasicSalary;
            return base.calaSalary(employee);

        }

    }
}
