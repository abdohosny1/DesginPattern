using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    public class MachineOperator
    {
        public string Name { get; set; }

        public double BasicSalary { get; set; }

        public int ShiftCode { get; set; }
    }
}
