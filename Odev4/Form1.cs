using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev4
{
    public partial class Form56 : Form
    {
        public Form56()
        {
            InitializeComponent();
        }

        private void btnasalSayiKontrol_Click(object sender, EventArgs e)
        {
            int Sayi = Convert.ToInt32(txtSayi.Text);
            int sayac = 0;
            for (int i = 2; i < Sayi; i++)
               if (Sayi % i == 0)
                {
                 sayac++;
                 break;
                }
               if(sayac==0)
                {
                   MessageBox.Show("Girdiğiniz sayı asaldır.");
                }
               else
                {
                   MessageBox.Show("Girdiğiniz sayı asal değildir.");
                }
             
                
             

        }
    }
}
