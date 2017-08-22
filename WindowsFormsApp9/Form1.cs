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
    public partial class Form1 : Form
    {
       
        public string ad;
        public string rol;
        public string tc;
        /************************************************************************************************/
        public Form1()
        {
            InitializeComponent();
        }
        /************************************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-GV8L3GM\\SQLEXPRESS;Initial Catalog=rentacar;Integrated Security=True");
                SqlCommand kmt = new SqlCommand("select adsoyad,rol,tc from calisan where tc=@tc and sifre=@sifre", con);
                kmt.Parameters.AddWithValue("@tc", txb_ad.Text);
                kmt.Parameters.AddWithValue("@sifre", txb_sifre.Text);
                con.Open();

                SqlDataReader sdr = kmt.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {

                        ad = sdr["adsoyad"].ToString();
                        rol = sdr["rol"].ToString();
                        tc = sdr["tc"].ToString();

                        Form2 f2 = new Form2();
                        f2.ad = ad;
                        f2.tc = tc;
                        if (rol == "1") rol = "Yönetici";
                        else rol = "Çalışan";
                        f2.rol = rol;
                        f2.Show();
                        this.Hide();
                       // this.Close();
                       // Application.Exit();

                    }

                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yapıldı Lütfen Kullanıcı Adınızı veya Şifrenizi Kontrol Ediniz");
                    txb_ad.Text = "";
                    txb_sifre.Text = "";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Problemle Karşılaşıldı.Lütfen Girdiginiz Değerleri Kontrol Ediniz... ");
            }
            
            
        }
        /************************************************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /************************************************************************************************/
        private void txb_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        /************************************************************************************************/
    }
}
