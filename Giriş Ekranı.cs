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
    public partial class Giris_Ekrani : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        // public static string dil;

        

        
        
        

        public Giris_Ekrani()
        {
            
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {



            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from kullanici where kullaniciAdi='"+kullaniciAdi+ "'And sifre='"+sifre + "'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                Anasayfa anasayfa = new Anasayfa();
                
                anasayfa.Show();

                this.Hide();
            } else
            {
                MessageBox.Show("başarısız");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
           
            con.Close();

            


            
            
        }


    

        
    }
}
