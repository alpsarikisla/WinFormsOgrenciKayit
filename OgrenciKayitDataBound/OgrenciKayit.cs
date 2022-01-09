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
    public partial class OgrenciKayit : Form
    {
        DataModel dm = new DataModel();
        int guncellenecekid = -1;
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            cb_sehir.ValueMember = "ID";
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.DataSource = dm.SehirleriGetir();

            cb_universite.ValueMember = "ID";
            cb_universite.DisplayMember = "Isim";
            cb_universite.DataSource = dm.UniversiteleriGetir();

            //dgw_ogrenciler.DataSource = dm.OgrencileriGetir();
            dgw_ogrenciler.DataSource = (dm.OgrencileriGetirDt());
            //dgw_ogrenciler.DataSource = (dm.OgrencileriGetirDt2());
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(cb_sehir.SelectedValue);
            cb_ilce.ValueMember = "ID";
            cb_ilce.DisplayMember = "Isim";
            cb_ilce.DataSource = dm.IlceleriGetir(sid);
        }

        private void cb_universite_SelectedIndexChanged(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(cb_universite.SelectedValue);
            cb_fakulte.ValueMember = "ID";
            cb_fakulte.DisplayMember = "Isim";
            cb_fakulte.DataSource = dm.FakulteleriGetir(uid);
        }

        private void cb_fakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(cb_fakulte.SelectedValue);
            cb_bolum.ValueMember = "ID";
            cb_bolum.DisplayMember = "Isim";
            cb_bolum.DataSource = dm.BolumleriGetir(fid);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adres = tb_adres.Text;
            ogr.SehirID = Convert.ToInt32(cb_sehir.SelectedValue);
            ogr.IlceID = Convert.ToInt32(cb_ilce.SelectedValue);
            ogr.Isim = tb_isim.Text;
            ogr.Soyisim = tb_soyisim.Text;
            ogr.TelNo = mtb_telefon.Text.Replace("(","").Replace(")","").Replace(" ","");
            ogr.TCNo = mtb_tc.Text;
            ogr.KullaniciID = GirisYapanKullanici.Kullanici.ID;
            int gelenid = dm.OgrenciKaydet(ogr);
            if (gelenid > 0)
            {
                MessageBox.Show("Ekleme Başarılı", "Başarılı");
                dgw_ogrenciler.DataSource = (dm.OgrencileriGetirDt());
            }
            else
            {
                MessageBox.Show("Öğrenci Ekleme Başarısız", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuncelleTSMI_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgw_ogrenciler.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[0].Value);
            guncellenecekid = id;
            Ogrenci ogr = dm.OgrenciGetir(id);
            tb_adres.Text = ogr.Adres;
            tb_isim.Text = ogr.Isim;
            tb_soyisim.Text = ogr.Soyisim;
            cb_sehir.SelectedIndex = cb_sehir.FindString(ogr.SehirIsim);
            cb_ilce.SelectedIndex = cb_ilce.FindString(ogr.IlceIsim);
            mtb_tc.Text = ogr.TCNo;
            mtb_telefon.Text = ogr.TelNo;
            btn_guncelle.Visible = true;
            btn_iptal.Visible = true;
        }

        private void dgw_ogrenciler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var yer = dgw_ogrenciler.HitTest(e.X, e.Y);
                dgw_ogrenciler.ClearSelection();
                dgw_ogrenciler.Rows[yer.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgw_ogrenciler, new Point(e.X, e.Y));
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (guncellenecekid != -1)
            {
                Ogrenci ogr = dm.OgrenciGetir(guncellenecekid);
                ogr.Adres = tb_adres.Text;
                ogr.SehirID = Convert.ToInt32(cb_sehir.SelectedValue);
                ogr.IlceID = Convert.ToInt32(cb_ilce.SelectedValue);
                ogr.Isim = tb_isim.Text;
                ogr.Soyisim = tb_soyisim.Text;
                ogr.TelNo = mtb_telefon.Text.Replace("(", "").Replace(")", "").Replace(" ", "");
                ogr.TCNo = mtb_tc.Text;

                switch (dm.OgrenciGuncelle(ogr))
                {
                    case DataFunctionResults.Basarili:
                        MessageBox.Show("Güncelleme Başarılı");
                            break;
                    case DataFunctionResults.Basarisiz:
                        MessageBox.Show("Güncelleme Başarısız");
                        break;
                   
                }
                guncellenecekid = -1;
                dgw_ogrenciler.DataSource = (dm.OgrencileriGetirDt());
                Domestos();
            }
        }
        private void SilTSMI_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgw_ogrenciler.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[0].Value);
            if (MessageBox.Show($"{id} ID'li Veri Silinecek Emin Misin?","Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dm.OgrenciSil(id) == DataFunctionResults.Basarisiz)
                {
                    MessageBox.Show("Hata Oluştu");
                }
            }
            else
            {
                MessageBox.Show("Silme İşlemi iptal edildi");
            }


            dgw_ogrenciler.DataSource = (dm.OgrencileriGetirDt());
        }
        public void Domestos()
        {
            //tb_adres.Text = tb_isim.Text = tb_soyisim.Text = String.Empty;
            cb_sehir.DataSource = dm.SehirleriGetir();

            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(MaskedTextBox))
                {
                    item.Text = String.Empty;
                }
                else if(item.GetType() == typeof(GroupBox))
                {
                    foreach (Control gbItem in item.Controls)
                    {
                        if (gbItem.GetType() == typeof(TextBox) || gbItem.GetType() == typeof(MaskedTextBox))
                        {
                            gbItem.Text = String.Empty;
                        }
                    }
                }

            }
            
        }

       
    }
}
