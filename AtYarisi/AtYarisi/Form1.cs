using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinciSolUzaklik, ikinciSolUzaklik, ucuncuSolUzaklik;
        Random rastgele = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciSolUzaklik = pictureBox1.Left;
            ikinciSolUzaklik = pictureBox2.Left;
            ucuncuSolUzaklik = pictureBox3.Left;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            lblSure.Text= "0";
            lblDurum.Text =" ";
            
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void oyna()
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            int derece = Convert.ToInt32(lblSure.Text);
            derece++;
            lblSure.Text = derece.ToString() ;

            int birinciAtGenisligi = pictureBox1.Width;
            int ikinciAtGenisliği = pictureBox2.Width;
            int ucuncuAtGenisligi = pictureBox3.Width;

            int bitisUzakliği = lblBitis.Left;

            pictureBox1.Left += rastgele.Next(5,16);
            pictureBox2.Left += rastgele.Next(5,16);
            pictureBox3.Left += rastgele.Next(5,16);

            if(pictureBox1.Left > pictureBox2.Left+5 && pictureBox1.Left> pictureBox3.Left + 5)
            {
                lblDurum.Text = "1 Numaralı at önde gidiyor.";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                lblDurum.Text = "2 Numaralı at iyi bir atakla gidiyor.";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                lblDurum.Text = "3 Numaralı at kimseye şans tanımıyor.";
            }

            if (birinciAtGenisligi+pictureBox1.Left >= bitisUzakliği)
            {
                timer.Enabled = false;
                lblDurum.Text = "1 Numaralı at yarışı kazandı.";
            }
            if (ikinciAtGenisliği+pictureBox2.Left >= bitisUzakliği)
            {
                timer.Enabled = false;
                lblDurum.Text = "2 Numaralı at yarışı kazandı.";
            }
            if (ucuncuAtGenisligi + pictureBox3.Left >= bitisUzakliği)
            {
                timer.Enabled = false;
                lblDurum.Text="3 Numaralı at yarışı kazandı.";
            }
        }

         
    }
}
