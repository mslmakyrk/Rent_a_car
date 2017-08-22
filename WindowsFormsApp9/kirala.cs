using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp9
{
    public partial class kirala : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GV8L3GM\\SQLEXPRESS;Initial Catalog=rentacar;Integrated Security=True");
       
        public string tc,ad,rol;
        public string mustc, plaka, kiralamatarihi, kiralamabitis;
        int ucret;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listele(textBox1.Text);
        }
        /****************************************************************************************/
        public kirala()
        {
            InitializeComponent();
        }
        /****************************************************************************************/
        private void cmbox_arama_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            kiralamatarihi = DateTime.Now.ToShortDateString();
            DateTime dt = DateTime.Parse( dateTimePicker1.Text);
            TimeSpan fark = (dt-DateTime.Today );
            string[] s = (fark.ToString()).Split('.',':');
            if(! (Convert.ToInt32( s[0])>0 ))
            {
                MessageBox.Show(" Lütfen İleri Bir Tarihi Seciniz...");
            }
            else
            {
                kiralamabitis = dateTimePicker1.Text;
                int fiyat = ucret * Convert.ToInt32( s[0]);
                try
                {
                    
                            if (con.State == ConnectionState.Closed) con.Open();
                            SqlCommand kmt2 = new SqlCommand();
                            kmt2.Connection = con;
                            if(plaka=="" || mustc == "")  MessageBox.Show("Lütfen Araç veya Müsteri Seçmeyi Unutmayınız");
                            else {
                                    kmt2.CommandText = "insert into sozlesmeler(mus_id,arac_id,calisan_id,kiralama_trh,kira_bitis_trh,ucret) values('" +
                                    mustc + "','" + plaka + "','" + tc + "','" + kiralamatarihi + "','" +
                                    kiralamabitis + "','" + fiyat + "')";
                                    kmt2.ExecuteNonQuery();
                                    kmt2.Dispose();
                                    con.Close();
                                    MessageBox.Show("Sözleşme Başarı Bir Şekilde Yapılmıştır");
                                    this.Close();


                                }


                }
                catch (Exception)
                {
                    MessageBox.Show("Baglanti Ayarları ile İlgili Bir Problem Var ");

                }

            }
        }

        /****************************************************************************************/
        private void label2_Click(object sender, EventArgs e)
        {

        }
        /****************************************************************************************/
        private void btn_arac_Click(object sender, EventArgs e)
        {
            arac ar = new arac();
            ar.ad = ad;
            ar.tc = tc;
            ar.rol = rol;
            ar.Show();
        }
        /****************************************************************************************/
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        /****************************************************************************************/
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            kiralamatarihi = DateTime.Now.ToShortDateString();
            DateTime dt = DateTime.Parse(dateTimePicker1.Text);
            TimeSpan fark = (dt - DateTime.Today);
            string[] s = (fark.ToString()).Split('.', ':');
            if (!(Convert.ToInt32(s[0]) > 0))
            {
                MessageBox.Show(" Lütfen İleri Bir Tarihi Seciniz...");
            }
            else
            {
                
                
                kiralamabitis = dateTimePicker1.Text;
                int fiyat  = ucret * Convert.ToInt32(s[0]);
                txbox_ucret.Text = fiyat.ToString();
                btn_kirala.Enabled = true;
            }
        }

        private void cmbox_arac_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        /****************************************************************************************/
        private void tbox_plaka_TextChanged(object sender, EventArgs e)
        {
            listele2(tbox_plaka.Text);
        }

        /****************************************************************************************/
        private void kirala_Load(object sender, EventArgs e)
        {
            label5.Text += ad;
            label4.Text += tc;
            label3.Text += rol;
            btn_kirala.Enabled = false;
            groupBox2.Enabled = false;
            groupBox4.Enabled = false;
            
        }
        /****************************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            musteri ms = new musteri();
            ms.ad = ad;
            ms.tc = tc;
            ms.rol = rol;
            ms.Show();
        }

        /****************************************************************************************/
        public void listele(string deger)
        {
            try
            {
                cmbox_arama.Items.Clear();
                SqlCommand kmt = new SqlCommand("select tc,adsoyad from musteri where tc like '%" + deger + "%'", con);
                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataReader sdr = kmt.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        mustc = sdr["tc"].ToString();
                        string s = " - " + sdr["adsoyad"].ToString();
                        cmbox_arama.Items.Add(mustc + s);
                    }

                }
                else
                {
                    cmbox_arama.Items.Add("Kayitli veri Bulunamamıştır...");

                }
                cmbox_arama.SelectedIndex = 0;
                con.Close();
            }
            catch (Exception)
            {

               
            }
            

        }
        /****************************************************************************************/
        /****************************************************************************************/
        public void listele2(string deger)
        {
            try
            {
                cmbox_arac.Items.Clear();
                SqlCommand kmt = new SqlCommand("select plaka,marka , gun_fiyat from arac where plaka like '%" + deger + "%'", con);
                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataReader sdr = kmt.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        plaka = sdr["plaka"].ToString();
                        ucret = Convert.ToInt32(sdr["gun_fiyat"]);
                        string s = " - " + sdr["marka"].ToString();
                        cmbox_arac.Items.Add(plaka + s);
                    }

                }
                else
                {
                    cmbox_arac.Items.Add("Kayitli veri Bulunamamıştır...");

                }
                cmbox_arac.SelectedIndex = 0;
                con.Close();
            }
            catch (Exception)
            {

                
            }
            

        }
        /****************************************************************************************/
    }
}
