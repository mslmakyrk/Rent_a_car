using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public string tc;
        public string ad;
        public string rol;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Visible = false;
            label1.Text += ad;
            label2.Text += tc;
            label3.Text += rol;
            if (rol == "Yönetici") btn_calisan.Enabled = true;
            
           
        }

        private void btn_mus_Click(object sender, EventArgs e)
        {
            musteri mus = new musteri();
            mus.ad = ad;
            mus.rol = rol;
            mus.tc = tc;
            mus.ShowDialog();
            
        }

        private void btn_arac_Click(object sender, EventArgs e)
        {
            arac arc = new arac();
            arc.ad = ad;
            arc.tc = tc;
            arc.rol = rol;
            arc.ShowDialog();
        }

        private void btn_calisan_Click(object sender, EventArgs e)
        {
            calısan ca = new calısan();
            
            ca.ShowDialog();
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            kirala k = new kirala();
            k.ad = ad;
            k.tc = tc;
            k.rol = rol;
            k.ShowDialog();
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_teslim_Click(object sender, EventArgs e)
        {
            teslim_al ta = new teslim_al();
            ta.ad = ad;
            ta.rol = rol;
            ta.tc = tc;
            ta.Show();
        }
    }
}
