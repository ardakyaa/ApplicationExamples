using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<PictureBox> koltuklar = new List<PictureBox>();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            KoltukLoad();
  
        }
        

        private void KoltukLoad()
        {
            pbDolu.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDolu.Image= Image.FromFile(Application.StartupPath + "\\dolu koltuk.jpg");
            pbBos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBos.Image= Image.FromFile(Application.StartupPath + "\\sinema koltuk.jpg");
            for (int i = 0; i < 40; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Name = i.ToString();
                pic.Height = pic.Width = 45;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Image = Image.FromFile(Application.StartupPath + "\\sinema koltuk.jpg");
                pic.Click += Pic_Click;
                flpKoltuklar.Controls.Add(pic);
                koltuklar.Add(pic);
            }

        }

        private void Pic_Click(object sender, EventArgs e)
        {

            PictureBox pic = (PictureBox) sender;

            this.Hide();
            var mainForm = new Form2();
            mainForm.form1 = this;
            mainForm.seciliKoltuk = (sender as PictureBox);           
            mainForm.ShowDialog();
            
        }

        public void DoluKoltuk(PictureBox pic1, string adSoyad, ulong tc, string cinsiyet)
        {
            
            foreach (var item in koltuklar)
            {
                if (item.Name==pic1.Name)
                {
                    item.Image= Image.FromFile(Application.StartupPath + "\\dolu koltuk.jpg");
                    item.Tag = "Dolu";
                    break;
                }
            }
            
        }

    }
}
