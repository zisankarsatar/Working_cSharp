using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans1Ucret = 0;
        int seans2 = 0;
        int seans2Ucret = 0;
        int seans3 = 0;
        int seans3Ucret = 0;
        int mısır = 0;
        int mısırFiyat = 0;
        int kola = 0;
        int kolaFiyat = 0;
        int su = 0;
        int suFiyat = 0;
        int toplamIzleyici, bufeKazanc, toplamBilet;
        int ToplamKazanc;
        private void btnArtı_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1Ucret += 8;
            txtGelen.Text = seans1.ToString();
            txtUcret.Text = seans1Ucret.ToString();

            if (seans1 == 10)
            {
                btnArtı.Enabled = false;
            }
            if (seans1 >= 0)
            {
                btnEksi.Enabled = true;
            }

        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1Ucret -= 8;
            txtGelen.Text = seans1.ToString();
            txtUcret.Text = seans1Ucret.ToString();

            if (seans1 == 0)
            {
                btnEksi.Enabled = false;
            }
            if(seans1<=10)
            {
                btnArtı.Enabled = true;
            }
        }

        private void btn2Artı_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2Ucret += 8;
            txtGelen2.Text = seans2.ToString();
            txtUcret2.Text = seans2Ucret.ToString();

            if (seans2 == 10)
            {
                btn2Artı.Enabled = false;
            }
            if (seans2 >= 0)
            {
                btn2Eksi.Enabled = true;
            }
        }

        private void btn2Eksi_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2Ucret -= 8;
            txtGelen2.Text = seans2.ToString();
            txtUcret2.Text = seans2Ucret.ToString();

            if (seans2 == 0)
            {
                btn2Eksi.Enabled = false;
            }
            if (seans2 <= 10)
            {
                btn2Artı.Enabled = true;
            }
        }

        private void btn3Artı_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3Ucret += 8;
            txtGelen3.Text = seans3.ToString();
            txtUcret3.Text = seans3Ucret.ToString();

            if (seans3 == 10)
            {
                btn3Artı.Enabled = false;
            }
            if (seans3 >= 0)
            {
                btn3Eksi.Enabled = true;
            }
        }

        private void btn3Eksi_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3Ucret -= 8;
            txtGelen3.Text = seans3.ToString();
            txtUcret3.Text = seans3Ucret.ToString();

            if (seans3 == 0)
            {
                btn3Eksi.Enabled = false;
            }
            if (seans3 <= 10)
            {
                btn3Artı.Enabled = true;
            }
        }

        private void mArtı_Click(object sender, EventArgs e)
        {
            mısır++;
            mısırFiyat += 8;
            mMiktar.Text = mısır.ToString();
            mFiyat.Text = mısırFiyat.ToString();
        }

        private void mEksi_Click(object sender, EventArgs e)
        {

            mısır--;
            mısırFiyat -= 8;
            mMiktar.Text = mısır.ToString();
            mFiyat.Text = mısırFiyat.ToString();

            if (mısır == 0)
            {
                mEksi.Enabled = false;
            }

        }

        private void kArtı_Click(object sender, EventArgs e)
        {
            kola++;
            kolaFiyat += 4;
            kMiktar.Text = kola.ToString();
            kFiyat.Text = kolaFiyat.ToString();
        }

        private void kEksi_Click(object sender, EventArgs e)
        {
           
            kola--;
            kolaFiyat -= 4;
            kMiktar.Text = kola.ToString();
            kFiyat.Text = kolaFiyat.ToString();
            if (kola == 0)
            {
                kEksi.Enabled = false;
            }

        }

        private void sArtı_Click(object sender, EventArgs e)
        {
            su++;
            suFiyat += 2;
            sMiktar.Text = su.ToString();
            sFiyat.Text = suFiyat.ToString();
        }

      

        private void sEksi_Click(object sender, EventArgs e)
        {
            su--;
            suFiyat -= 2;
            sMiktar.Text = su.ToString();
            sFiyat.Text = suFiyat.ToString();

            if (su == 0)
            {
                sEksi.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla2_Click(object sender, EventArgs e)
        {
            bufeKazanc = mısırFiyat + kolaFiyat + suFiyat;
            bKazanc.Text = bufeKazanc.ToString() + "TL";
            ToplamKazanc += bufeKazanc;
            lblToplamKazanc.Text = ToplamKazanc.ToString() + "TL";
        }
        private void tbnHesapla_Click(object sender, EventArgs e)
        {
            toplamIzleyici = seans1 + seans2 + seans3;
            tIzleyici.Text = toplamIzleyici.ToString();
            toplamBilet = seans1Ucret + seans2Ucret + seans3Ucret;
            biletKazanc.Text = toplamBilet.ToString() + "TL";
            ToplamKazanc += toplamBilet;
            lblToplamKazanc.Text = ToplamKazanc.ToString() + "TL"; 

        }
    }
}
