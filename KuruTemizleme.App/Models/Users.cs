using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuruTemizleme.App.Models
{
    public class Users
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string cinsiyet { get; set; }
        public string sifre { get; set; }
    }
}
