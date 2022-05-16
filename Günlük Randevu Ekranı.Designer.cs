
namespace DisHekimiUygulamasi
{
    partial class Günlük_Randevu_Ekranı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hastaİsmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaSoyismi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedaviTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedaviSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 621);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(87, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(561, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(857, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarihindeki Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hastaİsmi,
            this.HastaSoyismi,
            this.TedaviTuru,
            this.HastaNumarasi,
            this.TedaviSaati});
            this.dataGridView1.Location = new System.Drawing.Point(309, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 362);
            this.dataGridView1.TabIndex = 3;
            // 
            // Hastaİsmi
            // 
            this.Hastaİsmi.HeaderText = "Hasta İsmi";
            this.Hastaİsmi.MinimumWidth = 6;
            this.Hastaİsmi.Name = "Hastaİsmi";
            this.Hastaİsmi.Width = 150;
            // 
            // HastaSoyismi
            // 
            this.HastaSoyismi.HeaderText = "Hasta Soyismi";
            this.HastaSoyismi.MinimumWidth = 6;
            this.HastaSoyismi.Name = "HastaSoyismi";
            this.HastaSoyismi.Width = 150;
            // 
            // TedaviTuru
            // 
            this.TedaviTuru.HeaderText = "Tedavi Türü";
            this.TedaviTuru.MinimumWidth = 6;
            this.TedaviTuru.Name = "TedaviTuru";
            this.TedaviTuru.Width = 150;
            // 
            // HastaNumarasi
            // 
            this.HastaNumarasi.HeaderText = "Hasta Numarası";
            this.HastaNumarasi.MinimumWidth = 6;
            this.HastaNumarasi.Name = "HastaNumarasi";
            this.HastaNumarasi.Width = 150;
            // 
            // TedaviSaati
            // 
            this.TedaviSaati.HeaderText = "Tedavi Saati";
            this.TedaviSaati.MinimumWidth = 6;
            this.TedaviSaati.Name = "TedaviSaati";
            this.TedaviSaati.Width = 150;
            // 
            // Günlük_Randevu_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1447, 619);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Name = "Günlük_Randevu_Ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günlük Randevu Ekranı";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hastaİsmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaSoyismi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedaviTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaNumarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedaviSaati;
    }
}