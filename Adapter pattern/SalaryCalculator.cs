using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    public class SalaryCalculator
    {
        public double calaSalary(Employee employee) { return employee.BasicSalary * 1.5; }
    }
}
