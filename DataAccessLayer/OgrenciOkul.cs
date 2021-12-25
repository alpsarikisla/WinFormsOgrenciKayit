using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OgrenciOkul
    {
        public int ID { get; set; }
        public int OgrenciID { get; set; }
        public int UniversiteID { get; set; }
        public string FakulteID { get; set; }
        public int BolumID { get; set; }
        public int BaslangicYil { get; set; }
        public int BitisYil { get; set; }
        public bool Durum { get; set; }
    }
}
