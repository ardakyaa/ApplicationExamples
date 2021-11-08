using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtensionMethods.Extensions;
using System.Windows.Forms;

namespace StringExtensionMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void btnContains_Click_1(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            string ifade = txtIfade.Text;
            bool result = true;
            metin.ContainsMethod(ifade, result);
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            string ifade = txtIfade.Text;
            bool result = true;
            metin.StartsWithMethod(ifade, result);
        }

        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            string kelime1 = txtMetin.Text;
            string kelime2 = txtIfade.Text;
            kelime1.CompareToMethod(kelime2);
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            try
            {
                string kelime = txtMetin.Text;
                char harf = Convert.ToChar(txtIfade.Text);
                kelime.IndexOfMethod(harf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            try
            {
                string kelime = txtMetin.Text;
                char harf = Convert.ToChar(txtIfade.Text);
                kelime.LastIndexOfMethod(harf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //int index => verilen index değerinden itibaren metin kısmı silinecek.
                string metin = txtMetin.Text;
                int index = Convert.ToInt32(txtIfade.Text);
                metin.RemoveMethod(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            string ifade = txtIfade.Text;
            string yeniIfade = txtYeniIfade.Text;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            char ifade = Convert.ToChar(txtIfade.Text);
            metin.SplitMethod(ifade);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string metin = txtMetin.Text; //ana metin
                string ifade = txtIfade.Text; //eklenecek ifade
                int index = Convert.ToInt32(txtYeniIfade.Text); //ifadenin eklenmeye başlanacağı yer
                metin.InsertMethod(ifade, index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            try
            {
                //int index => verilen index değerinden itibaren metin kısmı  çağırılacak.
                string metin = txtMetin.Text;
                int index = Convert.ToInt32(txtIfade.Text);
                metin.SubStringMethod(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            metin.ToCharArrayMethod();
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            string ifade = txtIfade.Text;
            bool result = true;
            metin.EndWithMethod(ifade, result);
        }


    }
}
