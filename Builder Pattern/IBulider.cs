using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public interface IBulider
    {
        public void StartUpOperation();
        void BulidBody();

        void InsertWheel();

        void AddHeadlight();
        void EndOperation();
        Product GetVechicle();
    }
}
