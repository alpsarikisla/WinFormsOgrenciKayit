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
            InitializeComponent();
        }

        private void btn_OgrenciKayitFormAc_Click(object sender, EventArgs e)
        {
            OgrenciKayit frm = new OgrenciKayit();
            frm.Show();
        }
    }
}
