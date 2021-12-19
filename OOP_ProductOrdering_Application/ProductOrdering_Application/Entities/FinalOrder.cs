using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrdering_Application.Entities
{
    public class FinalOrder
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public decimal OrderPrice { get; set; }
    }
}
