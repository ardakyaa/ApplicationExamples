﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Example.Model
{
    public class Personal
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TCKN { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string SirketAdi { get; set; }
        public string VKN { get; set; }
        public string SirketAdresi { get; set; }
        public Nullable<decimal> YillikCiro { get; set; }
        public string Sektor { get; set; }

        
    }
}
