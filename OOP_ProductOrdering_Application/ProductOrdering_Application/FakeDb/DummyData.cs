using ProductOrdering_Application.DAL;
using ProductOrdering_Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOrdering_Application.FakeDb
{
    public class DummyData
    {
        public static void Seed()
        {
            ProductCategoryRepository productCategoryRepository = new ProductCategoryRepository();

            ProductCategory category1 = new ProductCategory() { CategoryName = "Elektronik" };
            ProductCategory category2 = new ProductCategory() { CategoryName = "Giyim" };
            ProductCategory category3 = new ProductCategory() { CategoryName = "Beyaz Eşya" };
            productCategoryRepository.Add(category1);
            productCategoryRepository.Add(category2);
            productCategoryRepository.Add(category3);

            ProductRepository productRepository = new ProductRepository();

            Product product1 = new Product() { ProductName = "Akıllı Telefon", Price = 8000m };
            Product product2 = new Product() { ProductName = "Laptop", Price = 9500m };
            Product product3 = new Product() { ProductName = "Tablet", Price = 4000m };
            Product product4 = new Product() { ProductName = "Pantolon", Price = 200m };
            Product product5 = new Product() { ProductName = "Gömlek", Price = 150m };
            Product product6 = new Product() { ProductName = "T-Shirt", Price = 90m };
            Product product7 = new Product() { ProductName = "Ayakkabı", Price = 300m };
            Product product8 = new Product() { ProductName = "Buzdolabı", Price = 7000m };
            Product product9 = new Product() { ProductName = "Çamaşır Makinesi", Price = 4500m };
            Product product10 = new Product() { ProductName = "Bulaşık Makinesi", Price = 3000m };
            productRepository.Add(product1);
            productRepository.Add(product2);
            productRepository.Add(product3);
            productRepository.Add(product4);
            productRepository.Add(product5);
            productRepository.Add(product6);
            productRepository.Add(product7);
            productRepository.Add(product8);
            productRepository.Add(product9);
            productRepository.Add(product10);

            productRepository.AddPrice(product1.Price);
            productRepository.AddPrice(product2.Price);
            productRepository.AddPrice(product3.Price);
            productRepository.AddPrice(product4.Price);
            productRepository.AddPrice(product5.Price);
            productRepository.AddPrice(product6.Price);
            productRepository.AddPrice(product7.Price);
            productRepository.AddPrice(product8.Price);
            productRepository.AddPrice(product9.Price);
            productRepository.AddPrice(product10.Price);

        }
    }
}
