using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class MotorCycle : IBulider
    {

        private string BrandName { get; set; }

        private Product product;

        public MotorCycle(string brandName)
        {
            this.product = new Product();
            BrandName = brandName;
        }
        public void AddHeadlight()
        {
            product.Add($"Headlight Of MotorCycle Add");
        }

        public void BulidBody()
        {
            product.Add($"Body Of MotorCycle Add");
        }

        public void EndOperation()
        {
            product.Add($"End Operation model : {this.BrandName}");
        }

        public Product GetVechicle()
        {
            return product;
        }

        public void InsertWheel()
        {
            product.Add($"Wheel Of MotorCycle Add");
        }

        public void StartUpOperation()
        {
            product.Add($"MotorCycle Model Name  : {this.BrandName}");
        }
    }
}
