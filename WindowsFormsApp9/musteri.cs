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
    public partial class musteri : Form
    {
        public string tc;
        public string ad;
        public string rol;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GV8L3GM\\SQLEXPRESS;Initial Catalog=rentacar;Integrated Security=True");
        SqlDataAdapter sda;
        public musteri()
        {
            InitializeComponent();
        }
        /**************************************************************************************************/
        private void musteri_Load(object sender, EventArgs e)
        {
            if (rol != "Yönetici")
            {
                btn_guncelle.Enabled = false;
                btn_sil.Enabled = false;
            }
            listele();
            cmb_dogumyeri.SelectedIndex = 0;
            cmb_ehliyet_turu.SelectedIndex = 0;
            cmbox_arama.SelectedIndex = 0;
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad-Soyad";
            dataGridView1.Columns[2].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[3].HeaderText = "Doğum Yeri";
            dataGridView1.Columns[4].HeaderText = "İş Telefonu";
            dataGridView1.Columns[5].HeaderText = "Cep Telefonu";
            dataGridView1.Columns[6].HeaderText = "Mail";
            dataGridView1.Columns[7].HeaderText = "Adres";
            dataGridView1.Columns[8].HeaderText = "Ehliyet";
            dataGridView1.Columns[9].HeaderText = "Ehliyet Tarihi";

        }
        /**************************************************************************************************/
        public void listele()
        {
            sda = new SqlDataAdapter("select * from musteri", con);
            DataSet ds = new DataSet();
            if (con.State == ConnectionState.Closed) con.Open();
            sda.Fill(ds, "musteri");
            dataGridView1.DataSource = ds.Tables["musteri"];
            con.Close();

        }
        /**************************************************************************************************/
        public void listele2(string sutun, string deger)
        {
            sda = new SqlDataAdapter("select * from musteri where "+sutun+" like '%"+deger+"%'", con);
            DataSet ds = new DataSet();
            if (con.State == ConnectionState.Closed) con.Open();
            sda.Fill(ds, "musteri");
            dataGridView1.DataSource = ds.Tables["musteri"];
            con.Close();

        }
        /**************************************************************************************************/
        public void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txb = (TextBox)item;
                    txb.Clear();
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mtbox = (MaskedTextBox)item;
                    mtbox.Clear();
                }
            }
            cmb_dogumyeri.SelectedIndex = 0;
            cmb_ehliyet_turu.SelectedIndex = 0;
            txb_dogum.Text = DateTime.Now.ToShortDateString();
            txb_ehliyet_trh.Text = DateTime.Now.ToShortDateString();
        }
        /**************************************************************************************************/
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        /**************************************************************************************************/
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int s;
            if (txb_tc.Text.Trim() == "" || txb_ad.Text.Trim() =="" ||  cmb_ehliyet_turu.Text.Trim() == "" || txb_ceptel.Text== "(    )    -")
            {
                MessageBox.Show("Lütfen * İle Belirtilen Yerleri Boş Bırakmayınız ");
            }
            else if (txb_tc.Text.Trim().Length<11 )
            {
                MessageBox.Show("lütfen TC Kimlik Numaranızı Kurallara uygun şekilde giriniz ");
                txb_tc.Text = "";
            }
            else
            {


               

                SqlCommand kmt = new SqlCommand("select tc , adsoyad from musteri where tc=@tc ", con);
                kmt.Parameters.AddWithValue("@tc", txb_tc.Text);

                if (con.State == ConnectionState.Closed) con.Open();

                SqlDataReader sdr = kmt.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.HasRows)
                {
                    MessageBox.Show("Girdiğiniz Tc Kimlik Numarası ile Kayıt Zaten Bulunmaktadır. ");
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

                    kmt2.CommandText = "insert into musteri(tc,adsoyad,dogum_tarihi,dogum_yeri,iş_telefonu,cep_telefonu,mail,adres,ehliyet,ehliyet_tarihi) values('" +
                        txb_tc.Text + "','" + txb_ad.Text + "','" + txb_dogum.Text + "','" +
                        cmb_dogumyeri.Text + "','" + txb_is_tel.Text + "','" + txb_ceptel.Text + "','" + txb_mail.Text + "','" + txb_adres.Text + "','" + cmb_ehliyet_turu.Text + "','" + txb_ehliyet_trh.Text + "')";
                    kmt2.ExecuteNonQuery();
                    kmt2.Dispose();
                    con.Close();
                    temizle();
                    listele();
                }
            }
            
        }
        /**************************************************************************************************/
        
        private void btn_sil_Click(object sender, EventArgs e)
        {
          if(  MessageBox.Show("Silmek İstediginizden Emin misiniz", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from musteri where tc=@tc";
                cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                listele();
            }
            
        }
        /**************************************************************************************************/
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            btn_ekle.Enabled = false;
            btn_sil.Enabled = false;
            btn_guncelle.Enabled = false;
            btn_gncl_kaydet.Visible = true;
            txb_tc.Enabled = false;
            txb_tc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txb_ad.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txb_dogum.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmb_dogumyeri.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txb_is_tel.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txb_ceptel.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txb_mail.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txb_adres.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmb_ehliyet_turu.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txb_ehliyet_trh.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }
        /**************************************************************************************************/
        private void btn_gncl_kaydet_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            btn_ekle.Enabled = true;
            btn_sil.Enabled =true;
            btn_guncelle.Enabled = true;
            btn_gncl_kaydet.Visible = false;
            txb_tc.Enabled = true;
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = con;
            kmt.CommandText = "update musteri set adsoyad='"+ txb_ad.Text + "' , dogum_tarihi='"+ txb_dogum.Text +
                "' , dogum_yeri='"+ cmb_dogumyeri.Text+"' , iş_telefonu='"+ txb_is_tel.Text+"' , cep_telefonu='"+ txb_ceptel.Text+
                "' , mail='"+ txb_mail.Text+"' , adres='"+ txb_adres.Text+"' , ehliyet='"+ cmb_ehliyet_turu.Text+"' , ehliyet_tarihi='"+ txb_ehliyet_trh.Text+"' where tc='"+ txb_tc.Text + "' ";
            kmt.ExecuteNonQuery();
            con.Close();
            kmt.Dispose();
            temizle();
            listele();

        }
        /**************************************************************************************************/
        private void btn_ekle_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Verileri Kaydetmek İcin Tıklayınız",btn_ekle);
        }
        /**************************************************************************************************/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s="";
            switch (cmbox_arama.Text)
            {
                case "Tc Kimlik":s = "tc";break;
                case "Ad-Soyad":s = "adsoyad"; break;
                case "Doğum Tarihi": s = "dogum_tarihi"; break;
                case "Doğum Yeri": s = "dogum_yeri"; break;
                case "İş Telefonu": s = "iş_telefonu"; break;
                case "Cep Telefonu": s = "cep_telefonu"; break;
                case "Mail": s = "mail"; break;
                case "Adres": s = "adres"; break;
                case "Ehliyet Türü": s = "ehliyet"; break;
                case "Ehliyet Alış Tarihi":s = "ehliyet_tarihi"; break;
                default: s = "tc"; cmbox_arama.SelectedIndex = 0; break;

            }
            string deger = textBox1.Text;
            listele2(s,deger);
        }
        /**************************************************************************************************/
        private void txb_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        /**************************************************************************************************/
    }
}
