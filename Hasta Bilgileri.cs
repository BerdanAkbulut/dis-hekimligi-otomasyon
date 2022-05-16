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
    public partial class Hasta_Bilgileri : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        SqlDataAdapter SqlDataAdapter;
        string cinsiyet = "";
        public static string hastaBilgileriId;

        public Hasta_Bilgileri()
        {
            InitializeComponent();
        }

        private void Hasta_Bilgileri_Load(object sender, EventArgs e)
        {
            txtFilter.Focus();
            try
            {

                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
                SqlDataAdapter = new SqlDataAdapter("select * from hastaBilgileri", con);
                DataSet ds = new DataSet();
                con.Open();

                SqlDataAdapter.Fill(ds, "hastaBilgileri");

                dataGridView1.DataSource = ds.Tables["hastaBilgileri"];


              

                con.Close();



            }
            catch (Exception er)
            {
                MessageBox.Show("Bir hata oluştu");
            }

        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            HastaEkleme hastaEkleme = new HastaEkleme();

            hastaEkleme.btnGuncelle.Hide();
            hastaEkleme.Show();


            this.Hide();

        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {

                hastaBilgileriId = r.Cells["hastaBilgileriId"].Value.ToString();
            }


            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "Select * from hastaBilgileri  where hastaBilgileriId=" + hastaBilgileriId;

                dr = com.ExecuteReader();
                if (dr.Read())
                {

                    HastaEkleme hastaEkleme = new HastaEkleme();
                    hastaEkleme.btnHastaEkle.Hide();
                    hastaEkleme.Show();

               



                 
                    hastaEkleme.txtAd.Text = dr.GetString(1);
                    hastaEkleme.txtSoyad.Text = dr.GetString(2);
                    hastaEkleme.txtTc.Text = dr.GetString(3);
                    hastaEkleme.txtTell.Text = dr.GetString(5);
                    hastaEkleme.txtYas.Text = dr.GetString(4);
                   
                    if(dr.GetString(6) == "Erkek")
                    {
                        hastaEkleme.radioBtnErkek.Checked = true;
                    } else
                    {
                        hastaEkleme.radioBtnKadin.Checked = true;
                    }






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

            this.Hide();


        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {

                hastaBilgileriId = r.Cells["hastaBilgileriId"].Value.ToString();

            }


            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;

            com.CommandText = "DELETE FROM hastaBilgileri where hastaBilgileriId =" + hastaBilgileriId;



            try
            {
                dr = com.ExecuteReader();
                dr.Read();
                MessageBox.Show("Hasta Silindi");

                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
                SqlDataAdapter = new SqlDataAdapter("Select * from hastaBilgileri", con);
                DataSet ds = new DataSet();
                con.Open();

                SqlDataAdapter.Fill(ds, "hastaBilgileri");

                dataGridView1.DataSource = ds.Tables["hastaBilgileri"];
                con.Close();



            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
                SqlDataAdapter = new SqlDataAdapter("select * from hastaBilgileri where hastaAdi LIKE  '%" + txtFilter.Text + "%'" , con);
                DataSet ds = new DataSet();
                con.Open();

                SqlDataAdapter.Fill(ds, "hastaBilgileri");

                dataGridView1.DataSource = ds.Tables["hastaBilgileri"];




                con.Close();
                txtFilter.Clear();


            }
            catch (Exception er)
            {
                MessageBox.Show("Bir hata oluştu");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Dispose();
            
        }
    }
    }

