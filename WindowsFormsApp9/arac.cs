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
    public partial class arac : Form
    {
        string plaka, marka, seri, model, renk, bakimt, yakit, aciklama, ehliyet;
        int mgucu, mhacmi, km; double fiyat;
        public string tc;
        public string ad;
        public string rol;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GV8L3GM\\SQLEXPRESS;Initial Catalog=rentacar;Integrated Security=True");
        SqlDataAdapter sda;
        /*******************************************************************************************************/
        public arac()
        {
            InitializeComponent();
        }
        /*******************************************************************************************************/
        private void tbox_motorgucu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        /*******************************************************************************************************/
        private void tbox_motorhacmi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        /*******************************************************************************************************/
        private void tbox_km_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        /*******************************************************************************************************/
        private void tbox_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /*******************************************************************************************************/

        private void arac_Load(object sender, EventArgs e)
        {
            try
            {
                if (rol != "Yönetici")
                {
                    btn_guncelle.Enabled = false;
                    btn_sil.Enabled = false;
                }
                cmbox_ehliyet_turu.SelectedIndex = 0;
                cmbox_renk.SelectedIndex = 0;
                cmbox_yakitturu.SelectedIndex = 0;
                cmbox_arama.SelectedIndex = 0;
                listele();
                dataGridView1.Columns[0].HeaderText = "Plaka";
                dataGridView1.Columns[1].HeaderText = "Marka";
                dataGridView1.Columns[2].HeaderText = "Seri";
                dataGridView1.Columns[3].HeaderText = "Model";
                dataGridView1.Columns[4].HeaderText = "Renk";
                dataGridView1.Columns[5].HeaderText = "Motor Gücü";
                dataGridView1.Columns[6].HeaderText = "Motor Hacmi";
                dataGridView1.Columns[7].HeaderText = "Bakım Tarihi";
                dataGridView1.Columns[8].HeaderText = "Kilometre";
                dataGridView1.Columns[9].HeaderText = "Yakıt Türü";
                dataGridView1.Columns[10].HeaderText = "Günlük Fiyat";
                dataGridView1.Columns[11].HeaderText = "Açıklama";
                dataGridView1.Columns[12].HeaderText = "Ehliyet";
            }
            catch (Exception)
            {

                MessageBox.Show("Araç Formu Yüklenirken Bir Hata İle Karşılaşıldı...");
            }
            
            
        }
        /*******************************************************************************************************/
        public void listele()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                sda = new SqlDataAdapter("select * from arac", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "arac");
                dataGridView1.DataSource = ds.Tables["arac"];
                sda.Dispose();
                con.Close();
            }
            catch (Exception)
            {

                
            }
            

        }
        /*******************************************************************************************************/
        public void listele2(string sutun, string deger)
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                sda = new SqlDataAdapter("select * from arac where " + sutun + " like '%" + deger + "%'", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "musteri");
                dataGridView1.DataSource = ds.Tables["musteri"];
                con.Close();
            }
            catch (Exception)
            {

                
            }
            

        }
        /*******************************************************************************************************/
        public void temizle()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txb = (TextBox)item;
                        txb.Clear();
                    }

                }
                cmbox_ehliyet_turu.SelectedIndex = 0;
                cmbox_renk.SelectedIndex = 0;
                cmbox_yakitturu.SelectedIndex = 0;
                date_bakim.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception)
            {

                
            }
            
            
        }
        /*******************************************************************************************************/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s = "";
                switch (cmbox_arama.Text)
                {
                    case "Plaka": s = "plaka"; break;
                    case "Marka": s = "marka"; break;
                    case "Seri": s = "seri"; break;
                    case "Model": s = "model"; break;
                    case "Renk": s = "renk"; break;
                    case "Motor Gücü": s = "motor_gucu"; break;
                    case "Motor Hacmi": s = "motor_hacmi"; break;
                    case "Son Bakim Tarihi": s = "bakim_trh"; break;
                    case "Kilometre": s = "kilometre"; break;
                    case "Yakıt Türü": s = "yakit_türü"; break;
                    case "Günlük Fiyat": s = "gun_fiyat"; break;
                    case "Ehliyet Türü": s = "gereken_ehliyet"; break;
                    default: s = "plaka"; cmbox_arama.SelectedIndex = 0; break;

                }
                string deger = textBox1.Text;
                listele2(s, deger);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata İle Karşılaşıldı Yaptığınız İşlemi Kontrol Ediniz...");
            }
            
            
        }
        /*******************************************************************************************************/
        private void btn_gncl_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                verioku();
                if ( marka == "" || model == "" || bakimt == "" ||  yakit == "" ||  ehliyet == "")
                {
                    MessageBox.Show("Lütfen * İle Belirtilen Yerleri Boş Bırakmayınız ");
                }
                else
                {
                    
                    if (con.State == ConnectionState.Closed) con.Open();
                    btn_ekle.Enabled = true;
                    btn_sil.Enabled = true;
                    btn_guncelle.Enabled = true;
                    btn_gncl_kaydet.Visible = false;
                    tbox_plaka.Enabled = true;
                    SqlCommand kmt = new SqlCommand();
                    kmt.Connection = con;
                    
                    kmt.CommandText = "update arac set  marka='" + marka + "', seri='" + seri + "' , model='" + model + "' , renk='" + renk +
                        "' , motor_gucu='" + mgucu + "' , motor_hacmi='" + mhacmi + "' , bakim_trh='" + bakimt + "' , kilometre='" + km +
                        "' , yakit_türü='" + yakit + "' , gun_fiyat='" + fiyat + "' , aciklama='" + aciklama + "' , gereken_ehliyet='" + ehliyet + "' where plaka='" + plaka + "'  ";
                    kmt.ExecuteNonQuery();
                    con.Close();
                    kmt.Dispose();
                    temizle();
                    listele();
                    MessageBox.Show("Güncelleme İşlemi Başarı İle Yapıldı...");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Günceleme İşlemi Başarısız Oldu...");
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
                tbox_plaka.Enabled = false;
                tbox_plaka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbox_marka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbox_seri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tbox_model.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cmbox_renk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                tbox_motorgucu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                tbox_motorhacmi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                date_bakim.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                tbox_km.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                cmbox_yakitturu.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                tbox_fiyat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                tbox_aciklama.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                cmbox_ehliyet_turu.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Araç Seçip Sonra Tıklayın...");
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
                    cmd.CommandText = "delete from arac where plaka=@x";
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
        public void verioku()
        {
            try
            {
                plaka = tbox_plaka.Text.Trim();
                marka = tbox_marka.Text.Trim();
                seri = tbox_seri.Text.Trim();
                model = tbox_model.Text.Trim();
                renk = cmbox_renk.Text.Trim();
                mgucu = Convert.ToInt32(tbox_motorgucu.Text.Trim());
                mhacmi = Convert.ToInt32(tbox_motorhacmi.Text.Trim());
                bakimt = date_bakim.Text;
                km = Convert.ToInt32(tbox_km.Text.Trim());
                yakit = cmbox_yakitturu.Text.Trim();
                fiyat = Convert.ToDouble(tbox_fiyat.Text.Trim());
                aciklama = tbox_aciklama.Text.Trim();
                ehliyet = cmbox_ehliyet_turu.Text.Trim();
            }
            catch (Exception)
            {
                
                temizle();

            }
        }
        /*******************************************************************************************************/
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            verioku();

            try
            {

                if (plaka == "" || marka == "" || model == "" || bakimt == "" || km == 0 || yakit == "" || fiyat == 0.0 || ehliyet == "")
                {
                    MessageBox.Show("Lütfen * İle Belirtilen Yerleri Boş Bırakmayınız ");
                }

                else
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    SqlCommand kmt = new SqlCommand("select * from arac where plaka=@x ", con);
                    kmt.Parameters.AddWithValue("@x", plaka);
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

                        kmt2.CommandText = "insert into arac values('" +
                            plaka + "','" + marka + "','" + seri + "','" +
                           model + "','" + renk + "','" + mgucu + "','" + mhacmi + "','" + bakimt + "','" + km + "','" + yakit + "', '" + fiyat + "','" + aciklama + "','" + ehliyet + "')";
                        kmt2.ExecuteNonQuery();
                        kmt2.Dispose();
                        con.Close();
                        temizle();
                        listele();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Baglanti Ayarları ile İlgili Bir Problem Var ");
                
            }

        }
        /*******************************************************************************************************/
    }
}
