using ProductOrdering_Application.Entities;
using ProductOrdering_Application.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrdering_Application.DAL
{
    public class ProductCategoryRepository
    {
        public void Add(ProductCategory category)
        {
            category.Id = (++ProductDatabase.ProductCategoryListId);
            ProductDatabase.categories.Add(category);
        }

        public List<ProductCategory> Get()
        {
            return ProductDatabase.categories;
        }
    }
}
