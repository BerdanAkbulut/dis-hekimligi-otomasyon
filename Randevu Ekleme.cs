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
    public  partial class RandevuEkleme : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        

        public static string randevuSaati ;
        public static string randevuTarihi;

        public RandevuEkleme()
        {
            InitializeComponent();
    
        }
       

        private void tikla(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            randevuSaati = btn.Text;
            RandevuKayıtEkranı randevuKayıtEkranı = new RandevuKayıtEkranı();
            randevuKayıtEkranı.Show();
            

            randevuKayıtEkranı.txtTedaviTarihi.Text = dateTimePicker1.Text;
            

          




        }

        private void button24_Click(object sender, EventArgs e)
        {
            
            this.Dispose();

        }

        private void RandevuEkleme_Load(object sender, EventArgs e)
        {

            sorgu(dateTimePicker1.Text);
          

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
             if(c is Button)
                {
                    Button btn = c as Button;
                    c.BackColor = Color.Green;
                    c.Enabled = true;

                }
            }



            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            DateTimePicker dateTimePickerr = sender as DateTimePicker;
          
            randevuTarihi = dateTimePicker1.Text;


            sorgu2(dateTimePickerr.Text);
            this.Refresh();

        }

        private void sorgu(string xx)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();

            con.Open();
            com.Connection = con;

            
           

            com.CommandText = "Select * from randevular ";
            

           dr = com.ExecuteReader();

           

            while (dr.Read())
            {



                if (xx.ToString() == dr.GetString(2))
                {

                    foreach (Control c in this.Controls)
                    {
                        if (c is Button)
                        {
                       

                            Button btn = c as Button;

                            if (c.Text.ToString() == dr.GetString(3))
                            {
                                

                                c.Enabled = false;
                                c.BackColor = Color.Red;
                               // this.Refresh();

                            }
                           

                        }
                    }

                }


            }






        }


        private void sorgu2(string xx)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();

            con.Open();
            com.Connection = con;




            com.CommandText = "Select * from randevular ";


            dr = com.ExecuteReader();



            while (dr.Read())
            {



                if (xx.ToString() == dr.GetString(2))
                {

                    foreach (Control c in this.Controls)
                    {
                        if (c is Button)
                        {

                           // c.Enabled = true;
                            // c.BackColor = Color.Green;

                            Button btn = c as Button;

                            if (c.Text.ToString() == dr.GetString(3))
                            {
                                

                                c.Enabled = false;
                                c.BackColor = Color.Red;
                               // this.Refresh();
                            }

                        }
                    }

                } 


            }






        }




    }
}


