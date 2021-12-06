using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CRM_Example.Model;


namespace CRM_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string path = @"..\..\Data\data.json";
        List<Personal> personals = new List<Personal>();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (path!=null)
            {
                FillGrid();
            }
                
        }

        private void FillGrid()
        {
            string jsonData = GetJsonData(path);

            personals = JsonConvert.DeserializeObject<List<Personal>>(jsonData);
            GetPersonalInformations(personals);
        }

        private void GetPersonalInformations(List<Personal> personals)
        {
            grdPersonalInformation.DataSource = null;
            grdPersonalInformation.DataSource = personals;
        }

        public string GetJsonData(string data)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
        private void UpdatePath()
        {
            string jsonString = JsonConvert.SerializeObject(personals);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonString);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                var personal = new Personal();
                personal.Adi = txtAdi.Text;
                personal.Soyadi = txtSoyadi.Text;
                personal.DogumTarihi = dtDogumTarihi.Value.Date;
                personal.TCKN = txtTCKN.Text;
                personal.Telefon = txtTelefon.Text;
                personal.Mail = txtMail.Text;
                personal.Adres = txtAdres.Text;
                personal.SirketAdi = txtSirketAdi.Text;
                personal.VKN = txtVKN.Text;
                personal.SirketAdresi = txtSirketAdres.Text;
                personal.YillikCiro = Convert.ToDecimal(txtYillikCiro.Text);
                personal.Sektor = cmbSektor.SelectedItem.ToString();
                if (personals != null)
                {
                    personal.Id = personals.Count;
                    personals.Add(personal);
                }
                else
                {
                    personal.Id = 1;
                    personals.Add(personal);
                }

                UpdatePath();
                FillGrid();
                RefreshTable();
                MessageBox.Show("Personel bilgileri kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void RefreshTable()
        {
            txtId.Text = null;
            txtId.Enabled = false;
            txtAdi.Text = null;
            txtSoyadi.Text = null;
            dtDogumTarihi.Text = DateTime.Now.ToShortDateString();
            txtTCKN.Text = null;
            txtTelefon.Text = null;
            txtMail.Text = null;
            txtAdres.Text = null;
            txtSirketAdi.Text = null;
            txtVKN.Text = null;
            txtSirketAdres.Text = null;
            txtYillikCiro.Text = null;
            cmbSektor.SelectedIndex = -1;
        }

        private void grdPersonalInformation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var personals = (grdPersonalInformation.DataSource as List<Personal>);
                if (grdPersonalInformation.SelectedRows.Count > 0)
                {
                    var personal = personals[grdPersonalInformation.SelectedRows[0].Index];
                    RefreshTable(personal);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshTable(Personal personal)
        {
            txtId.Enabled = true;
            txtId.Text = Convert.ToString(personal.Id);
            txtAdi.Text = personal.Adi;
            txtSoyadi.Text = personal.Soyadi;
            dtDogumTarihi.Value = personal.DogumTarihi;
            txtTCKN.Text = personal.TCKN;
            txtTelefon.Text = personal.Telefon;
            txtMail.Text = personal.Mail;
            txtAdres.Text = personal.Adres;
            txtSirketAdi.Text = personal.SirketAdi;
            txtVKN.Text = personal.VKN;
            txtSirketAdres.Text = personal.SirketAdresi;
            txtYillikCiro.Text = Convert.ToString(personal.YillikCiro);
            cmbSektor.SelectedItem = personal.Sektor;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result=MessageBox.Show("Personel bilgilerini silmek istediğinize emin misiniz?", "Personel Ekranı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (grdPersonalInformation.SelectedRows.Count > 0 && result==DialogResult.OK)
                {
                    var personal = personals[grdPersonalInformation.SelectedRows[0].Index];
                    personals.Remove(personal);
                    UpdatePath();
                    RefreshTable();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (grdPersonalInformation.SelectedRows.Count > 0)
                {
                    var personal = personals[grdPersonalInformation.SelectedRows[0].Index];
                    personal.Id =Convert.ToInt32(txtId.Text);
                    personal.Adi = txtAdi.Text;
                    personal.Soyadi = txtSoyadi.Text;
                    personal.DogumTarihi = dtDogumTarihi.Value.Date;
                    personal.TCKN = txtTCKN.Text;
                    personal.Telefon = txtTelefon.Text;
                    personal.Mail = txtMail.Text;
                    personal.Adres = txtAdres.Text;
                    personal.SirketAdi = txtSirketAdi.Text;
                    personal.VKN = txtVKN.Text;
                    personal.SirketAdresi = txtSirketAdres.Text;
                    personal.YillikCiro = Convert.ToDecimal(txtYillikCiro.Text);
                    personal.Sektor = cmbSektor.SelectedItem.ToString();

                    UpdatePath();
                    RefreshTable();
                    FillGrid();
                    MessageBox.Show("Personel bilgileri güncellendi.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
