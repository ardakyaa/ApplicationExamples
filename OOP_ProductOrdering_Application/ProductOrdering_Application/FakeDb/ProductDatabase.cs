using ProductOrdering_Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductOrdering_Application.FakeDb
{
    public static class ProductDatabase
    {
        public static int ProductCategoryListId = 0;
        public static List<ProductCategory> categories = new List<ProductCategory>();


        public static int ProductListId = 0;
        public static List<Product> products= new List<Product>();

        public static List<decimal> prices = new List<decimal>();

        public static List<FinalOrder> finalOrders = new List<FinalOrder>();


    }
}
