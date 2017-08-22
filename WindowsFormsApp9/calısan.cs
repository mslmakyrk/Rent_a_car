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
    public partial class calısan : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GV8L3GM\\SQLEXPRESS;Initial Catalog=rentacar;Integrated Security=True");
        SqlDataAdapter sda;
        string tc, ad, sifre, mail, cep, adres;
        int rol;
        public calısan()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
            verioku();

            try
            {

                if (tc == "" || ad == "" || sifre == "" || cep == "(    )    -"  )
                {
                    MessageBox.Show("Lütfen * İle Belirtilen Yerleri Boş Bırakmayınız ");
                }
                else if(tc.Length < 11)
                {
                    MessageBox.Show("Lütfen Tc Kimlik Numarasını Dogru Giriniz");
                }

                else
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    SqlCommand kmt = new SqlCommand("select * from calisan where tc=@x ", con);
                    kmt.Parameters.AddWithValue("@x", tc);
                    SqlDataReader sdr = kmt.ExecuteReader(CommandBehavior.CloseConnection);
                    if (sdr.HasRows)
                    {
                        MessageBox.Show("Girdiğiniz Plaka  Numarası ile Kayıtlı Arac Zaten Bulunmaktadır. ");
                        temizle();
                        sdr.Close();
                        kmt.Dispose();
                        con.Close();


                    }
                    else
                    {
                        sdr.Close();
                        kmt.Dispose();
                        if (con.State == ConnectionState.Closed) con.Open();
                        SqlCommand kmt2 = new SqlCommand();
                        kmt2.Connection = con;
                        kmt2.CommandText = "insert into calisan values('" +
                            tc + "','" + ad + "','" + sifre + "','" + adres + "','" +
                           mail + "','" + cep + "','" + rol + "')";
                        kmt2.ExecuteNonQuery();
                        kmt2.Dispose();
                        con.Close();
                        temizle();
                        listele();
                        MessageBox.Show("Güncelleme İşlemi Başarı İle Yapıldı...");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Baglanti Ayarları ile İlgili Bir Problem Var ");

            }
        }
        /*******************************************************************************************************/
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek İstediginizden Emin misiniz", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (con.State == ConnectionState.Closed) con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "delete from calisan where tc=@x";
                    cmd.Parameters.AddWithValue("@x", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    listele();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Silinecek Birşey Bulunamadı. Silmek İstediğiniz Nesneyi Seciniz");
            }
        }
        /*******************************************************************************************************/
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                btn_ekle.Enabled = false;
                btn_sil.Enabled = false;
                btn_guncelle.Enabled = false;
                btn_gncl_kaydet.Visible = true;
                tbox_tc.Enabled = false;
                tbox_tc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbox_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbox_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tbox_adres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                tbox_mail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                tbox_ceptel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cmbox_rol.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Yaparken Bir Hata İle Karşılaşıldı... ");
            }
        }
        /*******************************************************************************************************/
        private void btn_gncl_kaydet_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = con;
            verioku();
            if (tc == "" || ad == "" || sifre == "" || cep == "(    )    -")
            {
                MessageBox.Show("Lütfen * İle Belirtilen Yerleri Boş Bırakmayınız ");
            }
            
            else
            {
                btn_ekle.Enabled = true;
                btn_sil.Enabled = true;
                btn_guncelle.Enabled = true;
                btn_gncl_kaydet.Visible = false;
                tbox_tc.Enabled = true;
                kmt.CommandText = "update calisan set  adsoyad='" + ad + "', sifre='" + sifre + "' , adres='" + adres + "' , mail='" + mail +
                "' , telefon='" + cep + "' , rol='" + rol + "'  where tc='" + tc + "'  ";
                kmt.ExecuteNonQuery();
                con.Close();
                kmt.Dispose();
                temizle();
                listele();
            }
            
        }
        /*******************************************************************************************************/
        public void listele2(string sutun, string deger)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            sda = new SqlDataAdapter("select * from calisan where " + sutun + " like '%" + deger + "%'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "musteri");
            dataGridView1.DataSource = ds.Tables["musteri"];
            con.Close();

        }
        /*******************************************************************************************************/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = "";
            switch (cmbox_arama.Text)
            {
                case "TC": s = "tc"; break;
                case "Ad-Soyad": s = "adsoyad"; break;
                case "Mail": s = "mail"; break;
                case "Telefon": s = "telefon"; break;
                default: s = "tc"; cmbox_arama.SelectedIndex = 0; break;

            }
            string deger = textBox1.Text;
            listele2(s, deger);


         
        }

        /*******************************************************************************************************/
        private void calısan_Load(object sender, EventArgs e)
        {
            listele();
        }
        /*******************************************************************************************************/
        public void listele()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            sda = new SqlDataAdapter("select * from calisan", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "calis");
            dataGridView1.DataSource = ds.Tables["calis"];
            sda.Dispose();
            con.Close();

        }
        /*******************************************************************************************************/
        public void verioku()
        {
            tc = tbox_tc.Text.Trim();
            ad = tbox_ad.Text.Trim();
            sifre = tbox_sifre.Text.Trim();
            mail = tbox_mail.Text.Trim();
            cep = tbox_ceptel.Text.Trim();
            adres = tbox_adres.Text.Trim();
            string s = cmbox_rol.Text.Trim();
            if (s == "Yönetici") rol = 1;
            else rol = 2;
        }
        /*******************************************************************************************************/
        public void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txb = (TextBox)item;
                    txb.Clear();
                }

            }
            tbox_ceptel.Text = "";
            cmbox_rol.SelectedIndex = 0;
            

        }
        /*******************************************************************************************************/
        private void btn_ekle_Click(object sender, EventArgs e)
        {
           

        }
        /*******************************************************************************************************/

    }
}
