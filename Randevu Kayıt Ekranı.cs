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
    public partial class RandevuKayıtEkranı : Form

    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        SqlCommand com3;
        int secenek = 6;

        public SqlDataAdapter SqlDataAdapter2 { get; private set; }

        SqlCommand com4;
        SqlDataReader dr4;
        string cinsiyet = "";
        public RandevuKayıtEkranı()
        {
            
            InitializeComponent();
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {

            RandevuEkleme randevuEkleme = new RandevuEkleme();

            

            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com = new SqlCommand();

            

            con.Open();
            com.Connection = con;

            if(radioBtnErkek.Checked)
            {
                cinsiyet = "Erkek";
            } else
            {
                cinsiyet = "Kadin";
            }



            com.CommandText = "insert into Randevular" +
                " (hastaTedavisi,tedaviTarihi,tedaviSaati,tedaviUcreti,hastaAdi,hastaSoyadi,hastaTc,hastaNumarasi,hastaYasi,hastaCinsiyeti,hekimAdiSoyadi)" +
                " values (@hastaTedavisi,@tedaviTarihi,@tedaviSaati,@tedaviUcreti,@hastaAdi,@hastaSoyadi,@hastaTc,@hastaNumarasi,@hastaYasi,@hastaCinsiyeti,@hekimAdiSoyadi) ";

            com.Parameters.AddWithValue("@hastaTedavisi", comboBoxTedaviTuru.SelectedItem.ToString());
            com.Parameters.AddWithValue("@tedaviTarihi", txtTedaviTarihi.Text);
            com.Parameters.AddWithValue("@tedaviSaati", RandevuEkleme.randevuSaati);
            com.Parameters.AddWithValue("@tedaviUcreti", txtUcret.Text);
            com.Parameters.AddWithValue("@hastaAdi", txtAd.Text);
            com.Parameters.AddWithValue("@hastaSoyadi", txtSoyad.Text);
            com.Parameters.AddWithValue("@hastaTc", txtTc.Text);
            com.Parameters.AddWithValue("@hastaNumarasi", txtTel.Text);
            com.Parameters.AddWithValue("@hastaYasi", txtYas.Text);
            com.Parameters.AddWithValue("@hekimAdiSoyadi", cmbBoxHekimAdi.SelectedItem.ToString());
            com.Parameters.AddWithValue("@hastaCinsiyeti", cinsiyet);




            try
            {
               
                dr = com.ExecuteReader();
                dr.Read();
                //  dr4.Read();
                

               
                    
                    
                

                MessageBox.Show("Randevu Eklendi");


            } catch(Exception err)
            {
                
                Console.WriteLine(err);
                MessageBox.Show("Randevu Eklenemedi.");

            } finally
            {
                
                txtAd.Clear();
                txtSoyad.Clear();
                txtTc.Clear();
                txtTel.Clear();
                txtUcret.Clear();
                txtYas.Clear();
                comboBoxTedaviTuru.ResetText();
                this.Hide();
                
            }
            


            randevuEkleme.Show();
            randevuEkleme.Refresh();
            con.Close();
           

        }

        private void RandevuKayıtEkranı_Load(object sender, EventArgs e)
        {
            btnGuncelle.Hide();
            btnRandevuOlustur.Show();

          

            RandevuEkleme randevuEkleme = new RandevuEkleme();
         
            

            txtTedaviSaati.Text = RandevuEkleme.randevuSaati;

            
            txtTedaviTarihi.Text = RandevuEkleme.randevuTarihi;



            /////
            ///

            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
            com3 = new SqlCommand("select * from hekimler", con);
            SqlDataAdapter2 = new SqlDataAdapter("select * from hekimler", con);

            con.Open();
            DataSet ds2 = new DataSet();


            SqlDataAdapter2.Fill(ds2);
            com3.ExecuteReader();


            cmbBoxHekimAdi.DisplayMember = "items";
            cmbBoxHekimAdi.ValueMember = "items";


            for (var i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
               cmbBoxHekimAdi.Items.Add(ds2.Tables[0].Rows[i]["hekimAdi"].ToString() + " " + ds2.Tables[0].Rows[i]["hekimSoyadi"].ToString());
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisHekimi;Integrated Security=True");
           
            com = new SqlCommand();
         
            con.Open();
          
            com.Connection = con;
            
           

           
            com.CommandText = "update Randevular set hastaTedavisi='" + comboBoxTedaviTuru.Text +
                "', tedaviTarihi='" + txtTedaviTarihi.Text + "', tedaviSaati='" + txtTedaviSaati.Text +
                "', tedaviUcreti = '" + txtUcret.Text + "', hastaAdi='" + txtAd.Text +
                "', hastaSoyadi =  '" + txtSoyad.Text + "', hastaTc =  '"
                + txtTc.Text + "', hastaNumarasi = '" + txtTel.Text + "', hekimAdiSoyadi ='" + cmbBoxHekimAdi.SelectedItem.ToString()  +"', hastaYasi = '" + txtYas.Text + "', hastaCinsiyeti ='" + radioBtnErkek.Text + "' where hastaId =" +  Randevu_Listesi.hastaId;

            try
            {
                com3.ExecuteReader();
                dr = com.ExecuteReader();
                dr.Read();
           
                MessageBox.Show("Randevu Güncellendi.");

                Randevu_Listesi randevu_Listesi = new Randevu_Listesi();
                randevu_Listesi.Show();



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
                txtTel.Clear();
                txtUcret.Clear();
                txtYas.Clear();
                comboBoxTedaviTuru.ResetText();
                txtTedaviSaati.Clear();
                txtTedaviTarihi.Clear();
                cmbBoxHekimAdi.ResetText();
                this.Hide();

            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}






