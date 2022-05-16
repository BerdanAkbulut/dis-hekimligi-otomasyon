
namespace DisHekimiUygulamasi
{
    partial class Hasta_Bilgileri
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHastaSil = new System.Windows.Forms.Button();
            this.btnHastaGuncelle = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(623, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim Yazınız :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(93, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(811, 58);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(341, 22);
            this.txtFilter.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(944, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnHastaSil);
            this.panel1.Controls.Add(this.btnHastaGuncelle);
            this.panel1.Controls.Add(this.btnHastaEkle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 619);
            this.panel1.TabIndex = 3;
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.BackColor = System.Drawing.Color.Teal;
            this.btnHastaSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHastaSil.Location = new System.Drawing.Point(93, 490);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(124, 52);
            this.btnHastaSil.TabIndex = 4;
            this.btnHastaSil.Text = "Hasta Sil";
            this.btnHastaSil.UseVisualStyleBackColor = false;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click);
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnHastaGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHastaGuncelle.Location = new System.Drawing.Point(93, 343);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(124, 52);
            this.btnHastaGuncelle.TabIndex = 3;
            this.btnHastaGuncelle.Text = "Hasta Güncelle";
            this.btnHastaGuncelle.UseVisualStyleBackColor = false;
            this.btnHastaGuncelle.Click += new System.EventHandler(this.btnHastaGuncelle_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.Teal;
            this.btnHastaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHastaEkle.Location = new System.Drawing.Point(93, 203);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(124, 52);
            this.btnHastaEkle.TabIndex = 2;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 186);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 433);
            this.dataGridView1.TabIndex = 4;
            // 
            // Hasta_Bilgileri
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1533, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Hasta_Bilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bilgileri";
            this.Load += new System.EventHandler(this.Hasta_Bilgileri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHastaEkle;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHastaGuncelle;
        private System.Windows.Forms.Button btnHastaSil;
        public System.Windows.Forms.TextBox txtFilter;
    }
}