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
    public partial class Randevu_Listesi : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlDataReader dr2;
        SqlCommand com;
        SqlCommand com3;
        SqlDataAdapter SqlDataAdapter;
        SqlDataAdapter SqlDataAdapter2;
        public static string hastaId;
        RandevuKayıtEkranı randevuKayıtEkranı = new RandevuKayıtEkranı();


        public Randevu_Listesi()
        {

            InitializeComponent();


        }

        private void Randevu_Listesi_Load(object sender, EventArgs e)
        {




            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            SqlDataAdapter = new SqlDataAdapter("Select * from randevular",con);
            DataSet ds = new DataSet();
            con.Open();
    
            SqlDataAdapter.Fill(ds, "randevular");

            dataGridView1.DataSource = ds.Tables["randevular"];
            con.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();

            

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                randevuKayıtEkranı.txtTedaviSaati.Text = r.Cells["tedaviSaati"].Value.ToString();
                hastaId = r.Cells["hastaId"].Value.ToString();

            }

            


            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "Select * from randevular  where hastaId='" + hastaId + "'";


                ////////
                ///

                //  dr2 = com3.ExecuteReader();
                dr = com.ExecuteReader();
                if (dr.Read())
                {

                 
                    
                    RandevuEkleme randevuEkleme = new RandevuEkleme();
                    

                    randevuKayıtEkranı.Show();

                    randevuKayıtEkranı.btnGuncelle.Show();
                    randevuKayıtEkranı.btnRandevuOlustur.Hide();

                    randevuKayıtEkranı.txtTedaviTarihi.Text = randevuEkleme.dateTimePicker1.Value.ToString();


                    


                    randevuKayıtEkranı.comboBoxTedaviTuru.Text = dr.GetString(1);
                    randevuKayıtEkranı.txtUcret.Text = dr.GetString(4);
                    randevuKayıtEkranı.txtAd.Text = dr.GetString(5);
                    randevuKayıtEkranı.txtSoyad.Text = dr.GetString(6);
                    randevuKayıtEkranı.txtTc.Text = dr.GetString(7);
                    randevuKayıtEkranı.txtTel.Text = dr.GetString(8);
                    randevuKayıtEkranı.txtYas.Text = dr.GetString(9);
                    randevuKayıtEkranı.txtTedaviSaati.Text = dr.GetString(3);

             













                }
                else
                {
                    MessageBox.Show("Birşey oldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
             
                hastaId = r.Cells["hastaId"].Value.ToString();

            }


            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;

            com.CommandText = "DELETE FROM Randevular where hastaId =" + hastaId;



            try
            {
                dr = com.ExecuteReader();
                dr.Read();
                MessageBox.Show("Randevu iptal Edildi");

                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
                SqlDataAdapter = new SqlDataAdapter("Select * from randevular", con);
                DataSet ds = new DataSet();
                con.Open();

                SqlDataAdapter.Fill(ds, "randevular");

                dataGridView1.DataSource = ds.Tables["randevular"];
                con.Close();



            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
