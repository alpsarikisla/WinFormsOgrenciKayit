using DataAccessLayer;
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
    public partial class KullaniciGiris : Form
    {
        bool giris;
        public KullaniciGiris()
        {
            giris = false;
            InitializeComponent();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                Kullanici k = dm.KullaniciGiris(textBox1.Text, textBox2.Text);
                if (k != null)
                {
                    this.Close();
                    giris = true;
                    GirisYapanKullanici.Kullanici = k;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı", "Giriş Hatası");
                }
            }
            else
            {
                MessageBox.Show("Email Ve şifre boş bırakılamaz", "Boş Veri Algılandı");
            }
        }

        private void KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (giris == false)
            {
                Application.Exit();
            }
            
        }
    }
}
