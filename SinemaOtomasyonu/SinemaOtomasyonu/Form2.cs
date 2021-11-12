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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public List<string> formData = new List<string>();

        public Form1 form1 { get; set; }
        public PictureBox seciliKoltuk;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAdSoyad.Text;
                ulong tc = Convert.ToUInt64(txtTc.Text);

                if (rbBay.Checked || rbBayan.Checked && name != null && tc.ToString().Length==11)
                {
                    if (rbBay.Checked)
                    {
                        formData.Add(name + tc.ToString()+rbBay.Text);
                        form1.DoluKoltuk(seciliKoltuk, name, tc, rbBay.Text);
                       
                    }
                    else if (rbBayan.Checked)
                    {
                        formData.Add(name + tc.ToString() + rbBayan.Text);
                    }


                    this.Hide();
                    form1.Show();

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
