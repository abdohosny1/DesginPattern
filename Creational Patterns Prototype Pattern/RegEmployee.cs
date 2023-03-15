using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns_Prototype_Pattern
{
    public class RegEmployee : EmployeePrototype
    {
        public override EmployeePrototype DeepCopy()
        {
            RegEmployee reg = new RegEmployee();
            reg = (RegEmployee)this.MemberwiseClone();
            reg.EmpAddress = new Address
            {
                Bulliding = EmpAddress.Bulliding,
                City = EmpAddress.City,
                StreetName = EmpAddress.StreetName
            };
            reg.Name = this.Name;
            return reg;
        }

        public override EmployeePrototype ShallowCopy()
        {
            // this .MemberwiseClone() make shallow copy
            return (RegEmployee)this.MemberwiseClone();
        }
    }
}
