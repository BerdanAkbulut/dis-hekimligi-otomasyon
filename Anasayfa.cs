using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DisHekimiUygulamasi
{
    public partial class Anasayfa : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void randevuEkle_Click(object sender, EventArgs e)
        {
            RandevuEkleme randevu_Ekleme = new RandevuEkleme();
            // randevu_Ekleme.Visible = true;

            randevu_Ekleme.Show();


            
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Randevu_Listesi randevu = new Randevu_Listesi();
            randevu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hasta_Bilgileri hasta_Bilgileri = new Hasta_Bilgileri();
            hasta_Bilgileri.Show();
            hasta_Bilgileri.txtFilter.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BugunkiRandevular bugunkiRandevular = new BugunkiRandevular();
            bugunkiRandevular.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DemirbaşListesi demirbaş = new DemirbaşListesi();
            demirbaş.Show();
        }

        
    }
}
