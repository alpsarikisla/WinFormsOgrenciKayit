using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayitDataBound
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "Kullanıcı = " + GirisYapanKullanici.Kullanici.Isim + " " + GirisYapanKullanici.Kullanici.Soyad;
        }
        private void CikisTSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OgrenciKaydetTSMI_Click(object sender, EventArgs e)
        {
            bool varmi = false;
            Form[] acikFormlar = this.MdiChildren;
            foreach (Form item in acikFormlar)
            {
                if (item.GetType() == typeof(OgrenciKayit))
                {
                    item.Activate();
                    varmi = true;
                }
            }
            if (varmi == false)
            {
                OgrenciKayit frm = new OgrenciKayit();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        
    }
}
