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
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            cb_sehir.ValueMember = "ID";
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.DataSource = dm.SehirleriGetir();

            cb_universite.ValueMember = "ID";
            cb_universite.DisplayMember = "Isim";
            cb_universite.DataSource = dm.UniversiteleriGetir();

            dgw_ogrenciler.DataSource = dm.OgrencileriGetir();
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
    }
}
