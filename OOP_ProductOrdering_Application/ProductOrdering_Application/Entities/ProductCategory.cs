using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrdering_Application.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
