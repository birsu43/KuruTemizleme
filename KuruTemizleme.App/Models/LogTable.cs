using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuruTemizleme.App.Models
{
    public class LogTable
    {
        public int id { get; set; }
        public int kullaniciId { get; set; }
        public string yapilanIslem { get; set; }
        public DateTime tarihSaat { get; set; }
    }
}
