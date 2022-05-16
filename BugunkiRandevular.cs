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
    public partial class BugunkiRandevular : Form
    {
        SqlConnection con;
        SqlDataAdapter SqlDataAdapter;
    
        public BugunkiRandevular()
        {
            InitializeComponent();
        }

        private void BugunkiRandevular_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            var bugunkigun = dateTime.ToString("dd.MM.yyyy");




            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");


            SqlDataAdapter = new SqlDataAdapter("Select * from randevular where tedaviTarihi = '"+ bugunkigun + "'" ,con);
            DataSet ds = new DataSet();
            con.Open();
             
            SqlDataAdapter.Fill(ds, "randevular");

            dataGridView1.DataSource = ds.Tables["randevular"];
            con.Close();

        }
    }
}
