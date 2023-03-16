using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
   public class Car : IBulider
    {

        private string BrandName { get; set; }

        private Product product;

        public Car(string brandName)
        {
            this.product = new Product();
            BrandName = brandName;
        }

        public void StartUpOperation()
        {
            product.Add($"Car Model Name  : {this.BrandName}");
        }

        public void BulidBody()
        {
            product.Add($"Body Of Car Add");
        }

        public void InsertWheel()
        {
            product.Add($"Wheel Of Car Add");
        }

        public void AddHeadlight()
        {
            product.Add($"Headlight Of Car Add");
        }

        public void EndOperation()
        {
            product.Add($"End Operation ");
        }

        public Product GetVechicle()
        {
            return product;
        }
    }
}
