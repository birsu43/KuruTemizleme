using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuruTemizleme.App.Models
{
    public class Randevu
    {
        public int id { get; set; }
        public string musteriAd { get; set; }
        public string makbuz { get; set; }
        public string kiyafetTip { get; set; }
        public int musteriNo { get; set; }
        public string teslim { get; set; }
        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
        public int adet { get; set; }
        public float tutar { get; set; }
        public string durum { get; set; }

    }
}
