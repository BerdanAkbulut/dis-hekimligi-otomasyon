
namespace DisHekimiUygulamasi
{
    partial class Giris_Ekrani
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioBtnEnglish = new System.Windows.Forms.RadioButton();
            this.radioBtnTurkce = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(443, 153);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(468, 22);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(443, 248);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(468, 22);
            this.txtSifre.TabIndex = 2;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGirisYap.Location = new System.Drawing.Point(443, 318);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(143, 53);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.TabStop = false;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.Enter += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(561, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "GİRİŞ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DisHekimiUygulamasi.Properties.Resources.diş;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // radioBtnEnglish
            // 
            this.radioBtnEnglish.AutoSize = true;
            this.radioBtnEnglish.Location = new System.Drawing.Point(805, 338);
            this.radioBtnEnglish.Name = "radioBtnEnglish";
            this.radioBtnEnglish.Size = new System.Drawing.Size(89, 21);
            this.radioBtnEnglish.TabIndex = 5;
            this.radioBtnEnglish.Text = "ENGLISH";
            this.radioBtnEnglish.UseVisualStyleBackColor = true;
           
            // 
            // radioBtnTurkce
            // 
            this.radioBtnTurkce.AutoSize = true;
            this.radioBtnTurkce.Checked = true;
            this.radioBtnTurkce.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radioBtnTurkce.Location = new System.Drawing.Point(621, 338);
            this.radioBtnTurkce.Name = "radioBtnTurkce";
            this.radioBtnTurkce.Size = new System.Drawing.Size(85, 21);
            this.radioBtnTurkce.TabIndex = 4;
            this.radioBtnTurkce.TabStop = true;
            this.radioBtnTurkce.Text = "TÜRKÇE";
            this.radioBtnTurkce.UseVisualStyleBackColor = true;
            
            // 
            // Giris_Ekrani
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1050, 457);
            this.Controls.Add(this.radioBtnEnglish);
            this.Controls.Add(this.radioBtnTurkce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Giris_Ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.Button btnGirisYap;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton radioBtnEnglish;
        public System.Windows.Forms.RadioButton radioBtnTurkce;
    }
}

