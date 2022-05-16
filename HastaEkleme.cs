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
    public partial class HastaEkleme : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        SqlCommand com2;
        SqlDataAdapter SqlDataAdapter;


        string cinsiyet = "";



        public HastaEkleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioBtnErkek.Checked == null && radioBtnKadin.Checked == null)
            {
                MessageBox.Show("Cinsiyet seçmeliniz");

            }


            if (radioBtnErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadin";
            }



            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;



            com.CommandText = "insert into hastaBilgileri" +
                " (hastaAdi,hastaSoyadi,hastaTc,hastaNumarasi,hastaYasi,hastaCinsiyeti)" +
                " values (@hastaAdi,@hastaSoyadi,@hastaTc,@hastaNumarasi,@hastaYasi,@hastaCinsiyeti) ";


            com.Parameters.AddWithValue("@hastaAdi", txtAd.Text);
            com.Parameters.AddWithValue("@hastaSoyadi", txtSoyad.Text);
            com.Parameters.AddWithValue("@hastaTc", txtTc.Text);
            com.Parameters.AddWithValue("@hastaNumarasi", txtTell.Text);
            com.Parameters.AddWithValue("@hastaYasi", txtYas.Text);
            com.Parameters.AddWithValue("@hastaCinsiyeti", cinsiyet);




            try
            {
                dr = com.ExecuteReader();
                dr.Read();
                MessageBox.Show("Hasta Eklendi");


            }
            catch (Exception err)
            {
                MessageBox.Show("Hasta Eklenemedi.");
                Console.WriteLine(err);

            }
            finally
            {

                txtAd.Clear();
                txtSoyad.Clear();
                txtTc.Clear();
                txtTell.Clear();
                txtYas.Clear();

                this.Hide();

            }


            Hasta_Bilgileri hasta_Bilgileri = new Hasta_Bilgileri();

            hasta_Bilgileri.Show();


            con.Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (radioBtnErkek.Checked == null && radioBtnKadin.Checked == null)
            {
                MessageBox.Show("Cinsiyet seçmeliniz");

            }


            if (radioBtnErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadin";
            }


            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;

            com.CommandText = "update hastaBilgileri set hastaAdi='" + txtAd.Text +
                "', hastaSoyadi='" + txtSoyad.Text + "', hastaTc='" + txtTc.Text +
                "', hastaYasi = '" + txtYas.Text + "', hastaNumarasi='" + txtTell.Text +
                "', hastaCinsiyeti =  '" + cinsiyet + "' where hastaBilgileriId =" + Hasta_Bilgileri.hastaBilgileriId;

            try
            {
                dr = com.ExecuteReader();
                dr.Read();
                MessageBox.Show("Randevu Güncellendi.");

                



            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);


            }
            finally
            {

                txtAd.Clear();
                txtSoyad.Clear();
                txtTc.Clear();
                txtTell.Clear();
                txtYas.Clear();
                grpBoxCinsiyet.Controls.Clear();
                
                this.Hide();

            }

            Hasta_Bilgileri hasta_Bilgileri = new Hasta_Bilgileri();

            hasta_Bilgileri.Show();


        }

        private void HastaEkleme_Load(object sender, EventArgs e)
        {

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
    

