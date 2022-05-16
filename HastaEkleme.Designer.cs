
namespace DisHekimiUygulamasi
{
    partial class HastaEkleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelnumara = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labeltc = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.radioBtnErkek = new System.Windows.Forms.RadioButton();
            this.radioBtnKadin = new System.Windows.Forms.RadioButton();
            this.grpBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpBoxCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yaş";
            // 
            // labelnumara
            // 
            this.labelnumara.AutoSize = true;
            this.labelnumara.Location = new System.Drawing.Point(189, 304);
            this.labelnumara.Name = "labelnumara";
            this.labelnumara.Size = new System.Drawing.Size(58, 17);
            this.labelnumara.TabIndex = 2;
            this.labelnumara.Text = "Numara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(826, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad";
            // 
            // labeltc
            // 
            this.labeltc.AutoSize = true;
            this.labeltc.Location = new System.Drawing.Point(826, 201);
            this.labeltc.Name = "labeltc";
            this.labeltc.Size = new System.Drawing.Size(24, 17);
            this.labeltc.TabIndex = 4;
            this.labeltc.Text = "Tc";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(326, 104);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(308, 22);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(326, 198);
            this.txtYas.MaxLength = 2;
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(308, 22);
            this.txtYas.TabIndex = 3;
            this.txtYas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(326, 301);
            this.txtTell.MaxLength = 11;
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(308, 22);
            this.txtTell.TabIndex = 5;
            this.txtTell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(974, 104);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(308, 22);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(974, 200);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(308, 22);
            this.txtTc.TabIndex = 4;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // radioBtnErkek
            // 
            this.radioBtnErkek.AutoSize = true;
            this.radioBtnErkek.Location = new System.Drawing.Point(145, 39);
            this.radioBtnErkek.Name = "radioBtnErkek";
            this.radioBtnErkek.Size = new System.Drawing.Size(65, 21);
            this.radioBtnErkek.TabIndex = 6;
            this.radioBtnErkek.TabStop = true;
            this.radioBtnErkek.Text = "Erkek";
            this.radioBtnErkek.UseVisualStyleBackColor = true;
            // 
            // radioBtnKadin
            // 
            this.radioBtnKadin.AutoSize = true;
            this.radioBtnKadin.Location = new System.Drawing.Point(359, 39);
            this.radioBtnKadin.Name = "radioBtnKadin";
            this.radioBtnKadin.Size = new System.Drawing.Size(65, 21);
            this.radioBtnKadin.TabIndex = 7;
            this.radioBtnKadin.TabStop = true;
            this.radioBtnKadin.Text = "Kadın";
            this.radioBtnKadin.UseVisualStyleBackColor = true;
            // 
            // grpBoxCinsiyet
            // 
            this.grpBoxCinsiyet.Controls.Add(this.radioBtnKadin);
            this.grpBoxCinsiyet.Controls.Add(this.radioBtnErkek);
            this.grpBoxCinsiyet.Location = new System.Drawing.Point(829, 266);
            this.grpBoxCinsiyet.Name = "grpBoxCinsiyet";
            this.grpBoxCinsiyet.Size = new System.Drawing.Size(453, 100);
            this.grpBoxCinsiyet.TabIndex = 13;
            this.grpBoxCinsiyet.TabStop = false;
            this.grpBoxCinsiyet.Text = "Cinsiyet";
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.Location = new System.Drawing.Point(1069, 407);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(213, 38);
            this.btnHastaEkle.TabIndex = 9;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = true;
            this.btnHastaEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(826, 407);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(213, 38);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Hasta Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // HastaEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 483);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.grpBoxCinsiyet);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.labeltc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelnumara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaEkleme";
            this.Load += new System.EventHandler(this.HastaEkleme_Load);
            this.grpBoxCinsiyet.ResumeLayout(false);
            this.grpBoxCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelnumara;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labeltc;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtYas;
        public System.Windows.Forms.TextBox txtTell;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtTc;
        public System.Windows.Forms.RadioButton radioBtnErkek;
        public System.Windows.Forms.RadioButton radioBtnKadin;
        public System.Windows.Forms.GroupBox grpBoxCinsiyet;
        public System.Windows.Forms.Button btnHastaEkle;
        public System.Windows.Forms.Button btnGuncelle;
    }
}