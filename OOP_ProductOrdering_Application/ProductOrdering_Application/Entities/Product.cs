using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrdering_Application.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }


        public override string ToString()
        {
            return this.ProductName;
        }
    }
}
