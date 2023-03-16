using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
  public  class Director
    {
        IBulider _bulider;

        public void Construct(IBulider bulider)
        {
            _bulider = bulider;
            bulider.StartUpOperation();
            bulider.BulidBody();
            bulider.InsertWheel();
            bulider.AddHeadlight();
            bulider.EndOperation();
        }
    }
}
