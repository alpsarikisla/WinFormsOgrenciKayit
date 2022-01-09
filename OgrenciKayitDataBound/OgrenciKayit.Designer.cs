
namespace OgrenciKayitDataBound
{
    partial class OgrenciKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_tc = new System.Windows.Forms.MaskedTextBox();
            this.mtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.cb_ilce = new System.Windows.Forms.ComboBox();
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_bolum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_fakulte = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_universite = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgw_ogrenciler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GuncelleTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SilTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ogrenciler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtb_tc);
            this.groupBox1.Controls.Add(this.mtb_telefon);
            this.groupBox1.Controls.Add(this.tb_soyisim);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim:";
            // 
            // mtb_tc
            // 
            this.mtb_tc.Location = new System.Drawing.Point(87, 85);
            this.mtb_tc.Mask = "99999999999";
            this.mtb_tc.Name = "mtb_tc";
            this.mtb_tc.Size = new System.Drawing.Size(226, 20);
            this.mtb_tc.TabIndex = 1;
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(87, 111);
            this.mtb_telefon.Mask = "(999) 999 99 99";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(226, 20);
            this.mtb_telefon.TabIndex = 1;
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(87, 59);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(226, 20);
            this.tb_soyisim.TabIndex = 0;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(87, 33);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(226, 20);
            this.tb_isim.TabIndex = 0;
            // 
            // cb_ilce
            // 
            this.cb_ilce.FormattingEnabled = true;
            this.cb_ilce.Location = new System.Drawing.Point(93, 59);
            this.cb_ilce.Name = "cb_ilce";
            this.cb_ilce.Size = new System.Drawing.Size(226, 21);
            this.cb_ilce.TabIndex = 3;
            // 
            // cb_sehir
            // 
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Location = new System.Drawing.Point(93, 29);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(226, 21);
            this.cb_sehir.TabIndex = 3;
            this.cb_sehir.SelectedIndexChanged += new System.EventHandler(this.cb_sehir_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "İlçe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şehir:";
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(93, 91);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(226, 56);
            this.tb_adres.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_bolum);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cb_fakulte);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cb_universite);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(698, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 189);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üniversite Bilgileri";
            // 
            // cb_bolum
            // 
            this.cb_bolum.FormattingEnabled = true;
            this.cb_bolum.Location = new System.Drawing.Point(93, 86);
            this.cb_bolum.Name = "cb_bolum";
            this.cb_bolum.Size = new System.Drawing.Size(226, 21);
            this.cb_bolum.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bölüm:";
            // 
            // cb_fakulte
            // 
            this.cb_fakulte.FormattingEnabled = true;
            this.cb_fakulte.Location = new System.Drawing.Point(93, 59);
            this.cb_fakulte.Name = "cb_fakulte";
            this.cb_fakulte.Size = new System.Drawing.Size(226, 21);
            this.cb_fakulte.TabIndex = 3;
            this.cb_fakulte.SelectedIndexChanged += new System.EventHandler(this.cb_fakulte_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fakülte:";
            // 
            // cb_universite
            // 
            this.cb_universite.FormattingEnabled = true;
            this.cb_universite.Location = new System.Drawing.Point(93, 32);
            this.cb_universite.Name = "cb_universite";
            this.cb_universite.Size = new System.Drawing.Size(226, 21);
            this.cb_universite.TabIndex = 3;
            this.cb_universite.SelectedIndexChanged += new System.EventHandler(this.cb_universite_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Üniversite:";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(337, 207);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgw_ogrenciler
            // 
            this.dgw_ogrenciler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ogrenciler.Location = new System.Drawing.Point(12, 264);
            this.dgw_ogrenciler.Name = "dgw_ogrenciler";
            this.dgw_ogrenciler.Size = new System.Drawing.Size(1045, 255);
            this.dgw_ogrenciler.TabIndex = 2;
            this.dgw_ogrenciler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgw_ogrenciler_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuncelleTSMI,
            this.SilTSMI});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // GuncelleTSMI
            // 
            this.GuncelleTSMI.Name = "GuncelleTSMI";
            this.GuncelleTSMI.Size = new System.Drawing.Size(120, 22);
            this.GuncelleTSMI.Text = "Güncelle";
            this.GuncelleTSMI.Click += new System.EventHandler(this.GuncelleTSMI_Click);
            // 
            // SilTSMI
            // 
            this.SilTSMI.Name = "SilTSMI";
            this.SilTSMI.Size = new System.Drawing.Size(180, 22);
            this.SilTSMI.Text = "Sil";
            this.SilTSMI.Click += new System.EventHandler(this.SilTSMI_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_ilce);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_sehir);
            this.groupBox3.Controls.Add(this.tb_adres);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(337, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 189);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adres Bilgileri";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(337, 207);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Visible = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(418, 207);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Visible = false;
            // 
            // OgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 531);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgw_ogrenciler);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgrenciKayit";
            this.Text = "Ogrenci Kayit";
            this.Load += new System.EventHandler(this.OgrenciKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ogrenciler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_ilce;
        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_tc;
        private System.Windows.Forms.MaskedTextBox mtb_telefon;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_bolum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_fakulte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_universite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgw_ogrenciler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GuncelleTSMI;
        private System.Windows.Forms.ToolStripMenuItem SilTSMI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_iptal;
    }
}