using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamBen = 0;
        int toplamPC = 0;

        private void btnBaslaBen_Click(object sender, EventArgs e)
        {
           
            int a = rastgele.Next(1,7);
            int b = rastgele.Next(1,7);
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);

            toplamBen += a + b;
            lblToplamB.Text = toplamBen.ToString();

            lblZar1ben.Text = a.ToString();
            lblZar2ben.Text = b.ToString();

            toplamPC += c + d;
            lblToplamP.Text = toplamPC.ToString();

            lblZar1PC.Text = c.ToString();
            lblZar2PC.Text = d.ToString();

            switch (a)
            {
                case 1:
                    pictureBox1.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar1.jpg";
                    break;
                case 2:
                    pictureBox1.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar2.jpg";
                    break;
                case 3:
                    pictureBox1.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar3.jpg";
                    break;
                case 4:
                    pictureBox1.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar4.jpg";
                    break;
                case 5:
                    pictureBox1.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar5.jpg";
                    break;
                case 6:
                    pictureBox1.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar6.jpg";
                    break;
                default:
                    break;

            }

            switch (b)
            {
                case 1:
                    pictureBox2.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar1.jpg";
                    break;
                case 2:
                    pictureBox2.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar2.jpg";
                    break;
                case 3:
                    pictureBox2.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar3.jpg";
                    break;
                case 4:
                    pictureBox2.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar4.jpg";
                    break;
                case 5:
                    pictureBox2.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar5.jpg";
                    break;
                case 6:
                    pictureBox2.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar6.jpg";
                    break;
                default:
                    break;
            }
            
            switch (c)
            {
                case 1:
                    pictureBox4.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar1.jpg";
                    break;
                case 2:
                    pictureBox4.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar2.jpg";
                    break;
                case 3:
                    pictureBox4.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar3.jpg";
                    break;
                case 4:
                    pictureBox4.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar4.jpg";
                    break;
                case 5:
                    pictureBox4.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar5.jpg";
                    break;
                case 6:
                    pictureBox4.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar6.jpg";
                    break;
                default:
                    break;

            }

            switch (d)
            {
                case 1:
                    pictureBox3.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar1.jpg";
                    break;
                case 2:
                    pictureBox3.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar2.jpg";
                    break;
                case 3:
                    pictureBox3.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar3.jpg";
                    break;
                case 4:
                    pictureBox3.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar4.jpg";
                    break;
                case 5:
                    pictureBox3.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar5.jpg";
                    break;
                case 6:
                    pictureBox3.ImageLocation = "D:\\YAZILIM\\proje\\Yaz C# Calismalari(19-yaz)\\ZarOyunu\\Zar\\zar6.jpg";
                    break;
                default:
                    break;
            }

            if (toplamPC > 100 && toplamPC > toplamBen)
            {
                btnBaslaBen.Enabled = false;
                lblKazanan.Text = "BİLGİSAYAR KAZANDI";
            }
            if(toplamBen>100 && toplamBen>toplamPC)
            {
                btnBaslaBen.Enabled = false;
                lblKazanan.Text = "TEBRİKLER KAZANDINIZ!";
            }

        }


        private void btnTekrar_Click_1(object sender, EventArgs e)
        {
            lblKazanan.Text = "";
            lblToplamB.Text = "0";
            lblToplamP.Text = "0";
            lblZar1ben.Text = "0";
            lblZar2ben.Text = "0";
            lblZar1PC.Text = "0";
            lblZar2PC.Text = "0";
            toplamBen = 0;
            toplamPC = 0;
            btnBaslaBen.Enabled = true;
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
