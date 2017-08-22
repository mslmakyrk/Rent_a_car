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
    public partial class teslim_al : Form
    {
        public int ucret, yeni_ucret;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GV8L3GM\\SQLEXPRESS;Initial Catalog=rentacar;Integrated Security=True");
        public string tc, ad, rol,plaka,kira_bitis="", kiralama_tarihi;

        private void btn_onay_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            btn_onay.Enabled = false;
            SqlCommand kmt = new SqlCommand("update sozlesmeler set teslim_trh='"+DateTime.Now.ToShortDateString()+ "' , ucret='"+yeni_ucret +"' where arac_id ='" + plaka + "' AND teslim_trh IS NULL  ", con);
            
            kmt.ExecuteNonQuery();
            con.Close();
            kmt.Dispose();
            this.Close();

        }

        /****************************************************************************************/
        private void teslim_al_Load(object sender, EventArgs e)
        {
            btn_onay.Enabled = false;
        }
        /****************************************************************************************/
        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            
            label5.Text = "";
            label3.Text = "";
            label6.Text = "";
            label7.Text = "";
            plaka = cmbox_arac.Text;
            SqlCommand kmt = new SqlCommand("select kira_bitis_trh , ucret , kiralama_trh from sozlesmeler where arac_id ='" + plaka + "' AND teslim_trh IS NULL  ", con);
            if (con.State == ConnectionState.Closed) con.Open();
            SqlDataReader sdr = kmt.ExecuteReader(CommandBehavior.CloseConnection);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {

                    kira_bitis = sdr["kira_bitis_trh"].ToString();
                    ucret = Convert.ToInt32(sdr["ucret"]);
                    label3.Text = kira_bitis;
                    label6.Text = sdr["ucret"].ToString()+" TL";
                    kiralama_tarihi = sdr["kiralama_trh"].ToString();
                }

            }
            con.Close();
            sdr.Close();

            DateTime dt = DateTime.Parse(kira_bitis);
            TimeSpan fark = (DateTime.Today-dt  );
            string[] s = (fark.ToString()).Split('.', ':');
            if (!(Convert.ToInt32(s[0]) < 0))
            {
                label5.Text = "Gecikmeli Gün Sayısı :" + s[0];
                TimeSpan x = DateTime.Parse(kira_bitis) - DateTime.Parse(kiralama_tarihi);
                string[] x2 = (x.ToString()).Split('.', ':');
                yeni_ucret = (ucret / Convert.ToInt32(x2[0])) * Convert.ToInt32(s[0]);
                label7.Text = "Ek Ücret :" + yeni_ucret + " TL";
                yeni_ucret += ucret;
            }
            btn_onay.Enabled = true;
        }

        /****************************************************************************************/
        public teslim_al()
        {
            InitializeComponent();
        }
        /****************************************************************************************/
        private void tbox_plaka_TextChanged(object sender, EventArgs e)
        {
            
                listele2(tbox_plaka.Text);
            
        }
        /****************************************************************************************/
        public void listele2(string deger)
        {
            try
            {
                cmbox_arac.Items.Clear();
                SqlCommand kmt = new SqlCommand("select arac_id  from sozlesmeler where arac_id like '%" + deger + "%' AND teslim_trh IS NULL  ", con);
                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataReader sdr = kmt.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                      
                        plaka = sdr["arac_id"].ToString();
                        cmbox_arac.Items.Add(plaka);
                        
                    }

                }
                else
                {
                    cmbox_arac.Items.Add("Kayitli veri Bulunamamıştır...");

                }
                cmbox_arac.SelectedIndex = 0;
                con.Close();
                sdr.Close();

            }
            catch (Exception)
            {


            }


        }
        /****************************************************************************************/
    }
}
