using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
  public  class Product
    {
        private System.Collections.Generic.LinkedList<String> _parts;

        public Product()
        {
            _parts = new System.Collections.Generic.LinkedList<String>();
        }

        public void Add(string part)
        {
            _parts.AddLast(part);
        }

        public string Show()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Product Component are :");
            foreach (var item in _parts)
            {
                result.AppendLine(item);
            }
            return result.ToString();
        }
    }
}
