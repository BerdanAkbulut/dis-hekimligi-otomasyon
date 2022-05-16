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
    public partial class MalzemeEkle : Form
    {

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        


        public MalzemeEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;



            com.CommandText = "insert into harcamalar" +
                " (materialName,materialPrice)" +
                " values (@materialName,@materialPrice) ";


            com.Parameters.AddWithValue("@materialName", txtMalzemeAdi.Text);
            com.Parameters.AddWithValue("@materialPrice", txtMalzemeFiyati.Text);

            try
            {
                dr = com.ExecuteReader();
                dr.Read();
                MessageBox.Show("Malzeme Eklendi");


            }
            catch (Exception err)
            {
                MessageBox.Show("Malzeme Eklenemedi.");
                Console.WriteLine(err);

            }
            finally
            {

                txtMalzemeAdi.Clear();
                txtMalzemeFiyati.Clear();
                txtMalzemeAdi.Focus();


                this.Hide();

            }


            DemirbaşListesi demirbaş = new DemirbaşListesi();
            demirbaş.Show();


            con.Close();
        }
    }
}
