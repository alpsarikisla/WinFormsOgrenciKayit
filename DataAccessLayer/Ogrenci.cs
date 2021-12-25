using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Ogrenci
    {
        public int ID { get; set; }
        public int SehirID { get; set; }
        public int IlceID { get; set; }
        public string TCNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public string Resim { get; set; }
    }
}
