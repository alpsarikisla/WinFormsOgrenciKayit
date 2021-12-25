
namespace OgrenciKayitDataBound
{
    partial class AnaForm
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
            this.btn_OgrenciKayitFormAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OgrenciKayitFormAc
            // 
            this.btn_OgrenciKayitFormAc.Location = new System.Drawing.Point(16, 19);
            this.btn_OgrenciKayitFormAc.Name = "btn_OgrenciKayitFormAc";
            this.btn_OgrenciKayitFormAc.Size = new System.Drawing.Size(174, 55);
            this.btn_OgrenciKayitFormAc.TabIndex = 0;
            this.btn_OgrenciKayitFormAc.Text = "Öğrenci Kaydet";
            this.btn_OgrenciKayitFormAc.UseVisualStyleBackColor = true;
            this.btn_OgrenciKayitFormAc.Click += new System.EventHandler(this.btn_OgrenciKayitFormAc_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 450);
            this.Controls.Add(this.btn_OgrenciKayitFormAc);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OgrenciKayitFormAc;
    }
}