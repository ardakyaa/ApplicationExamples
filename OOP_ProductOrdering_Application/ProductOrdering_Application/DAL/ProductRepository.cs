using ProductOrdering_Application.Entities;
using ProductOrdering_Application.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProductOrdering_Application.DAL
{
    public class ProductRepository
    {
        public void Add(Product product)
        {
            product.Id = (++ProductDatabase.ProductListId);
            ProductDatabase.products.Add(product);
        }

        public List<Product> Get()
        {
            return ProductDatabase.products;
        }
        public void AddPrice(decimal price)
        {

            ProductDatabase.prices.Add(price);
        }

        public List<decimal> GetPrices()
        {
            return ProductDatabase.prices;
        }
    }
}
