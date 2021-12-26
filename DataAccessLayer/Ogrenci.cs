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
        public int KullaniciID { get; set; }
        public string KullaniciIsim { get; set; }
        public int SehirID { get; set; }
        public string SehirIsim { get; set; }
        public int IlceID { get; set; }
        public string IlceIsim { get; set; }
        public string TCNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public string Resim { get; set; }
    }
}
