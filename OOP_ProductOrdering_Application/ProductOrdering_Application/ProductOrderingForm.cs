using ProductOrdering_Application.DAL;
using ProductOrdering_Application.Entities;
using ProductOrdering_Application.FakeDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOrdering_Application
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        ProductCategoryRepository categoryRepository;
        ProductRepository productRepository;
        FinalOrder order;
        
        private void ProductForm_Load(object sender, EventArgs e)
        {
            categoryRepository= new ProductCategoryRepository();
            productRepository = new ProductRepository();

            DummyData.Seed();
            FillCategory();

        }

        private void FillCategory()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Insert(0, "Seçiniz");
            List<ProductCategory> categories = categoryRepository.Get();
            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category);
            }
            cmbCategory.SelectedIndex = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProducts();
        }

        private void FillProducts()
        {
            cmbProduct.Items.Clear();
            List<Product> products = productRepository.Get();
            cmbProduct.Items.Insert(0, "Seçiniz");
            if (cmbCategory.SelectedIndex==1)
            {
                for (int i = 0; i < 3; i++)
                {
                    cmbProduct.Items.Add(products[i]);
                }
            }
            else if (cmbCategory.SelectedIndex == 2)
            {
                for (int i = 3; i < 7; i++)
                {
                    cmbProduct.Items.Add(products[i]);
                }
            }
            else if (cmbCategory.SelectedIndex == 3)
            {
                for (int i = 7; i < 10; i++)
                {
                    cmbProduct.Items.Add(products[i]);
                }
            }
            cmbProduct.SelectedIndex = 0;

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPrice();
 
        }

        private void FillPrice()
        {
            List<Product> products = productRepository.Get();
            List<decimal> productPrices = productRepository.GetPrices();
            for (int i = 0; i < products.Count; i++)
            {
                if (cmbProduct.SelectedItem == products[i])
                {
                    decimal price = productPrices[i];
                    lblPrice.Text = $"FİYAT: {price} TL";
                }
            }
  
        }
        decimal totalPrice;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cmbProduct.SelectedIndex>-1)
            
                for (int i = 0; i < productRepository.Get().Count; i++)
                {
                    if (productRepository.Get()[i]==cmbProduct.SelectedItem)
                    {
                        Product product = productRepository.Get()[i];
                        product.Price = product.Price * nuCount.Value;
                        product.Count = Convert.ToInt32(nuCount.Value);
                        lstOrder.Items.Add($"{product.Count} adet {product} - Tutar={product.Price} TL");
                        order = new FinalOrder();
                        order.OrderPrice = product.Price;
                        order.OrderId = product.Id;
                        order.OrderName = product.ProductName;
                        decimal price = order.OrderPrice;
                        totalPrice += product.Price;
                        lblTotalPrice.Text = $"TOPLAM TUTAR: {totalPrice} TL";
 
                        break;
                    }
                }

        }

        private void ClearAll()
        {
            cmbCategory.SelectedIndex = 0;
            cmbProduct.SelectedIndex = 0;
            nuCount.Value = 0;
            lblPrice.Text = "Fiyat: 0.00 TL";
            lblTotalPrice.Text = "TOPLAM TUTAR: 0.00 TL";
            lstOrder.Items.Clear();
            totalPrice = 0;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
             var result= MessageBox.Show($"Ödeyeceğiniz Tutar: {totalPrice} TL'dir. Onaylıyor musunuz?","Sipariş Özeti",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result==DialogResult.OK)
            {
                ClearAll();
            }

        }


    }
}
