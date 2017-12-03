using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunProje
{
     public class urun
    {
        public int id { get; set; }
        public string urunAdi { get; set; }
        public DateTime uretimTarihi { get; set; }
        public string sonKullanmaTarihi { get; set; }
        public int fiyat { get; set; }
    }
}
