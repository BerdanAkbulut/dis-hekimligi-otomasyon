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
    public partial class DemirbaşListesi : Form
    {
        SqlConnection con;
        SqlCommand com2;
        SqlDataAdapter sqlDataAdapter;
        SqlDataReader dr;
        string outId;

        public DemirbaşListesi()
        {
            InitializeComponent();
        }

        private void DemirbaşListesi_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            sqlDataAdapter = new SqlDataAdapter("Select * from harcamalar", con);
            DataSet ds = new DataSet();
            con.Open();

            sqlDataAdapter.Fill(ds, "harcamalar");

            dataGridView1.DataSource = ds.Tables["harcamalar"];
            con.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            

            MalzemeEkle malzemeEkle = new MalzemeEkle();
            malzemeEkle.Show();
            malzemeEkle.txtMalzemeAdi.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {

                outId = r.Cells["outId"].Value.ToString();

            }


            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com2 = new SqlCommand();
            con.Open();
            com2.Connection = con;

            com2.CommandText = "DELETE FROM harcamalar where outId =" + outId;



            try
            {
                dr = com2.ExecuteReader();
                dr.Read();
                MessageBox.Show("Malzeme silindi");

                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
                sqlDataAdapter = new SqlDataAdapter("Select * from harcamalar", con);
                DataSet ds = new DataSet();
                con.Open();

                sqlDataAdapter.Fill(ds, "harcamalar");

                dataGridView1.DataSource = ds.Tables["harcamalar"];
                con.Close();



            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);


            }
        }
    }
}
