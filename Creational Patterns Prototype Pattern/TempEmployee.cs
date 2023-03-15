using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns_Prototype_Pattern
{
  public  class TempEmployee : EmployeePrototype
    {
        public override EmployeePrototype DeepCopy()
        {
            TempEmployee emp = new TempEmployee();
            emp = (TempEmployee)this.MemberwiseClone();
            emp.EmpAddress = new Address
            {
                Bulliding = EmpAddress.Bulliding,
                City = EmpAddress.City,
                StreetName = EmpAddress.StreetName
            };
            emp.Name = this.Name;
            return emp;
        }

        public override EmployeePrototype ShallowCopy()
        {
            return (TempEmployee)this.MemberwiseClone();
        }
    }
}
