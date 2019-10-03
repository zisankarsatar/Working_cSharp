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

namespace BilgiYarismasiOyunu
{
    public partial class BilgiYarismasi : Form
    {
        public BilgiYarismasi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ECAMK9C\\ZISANSQL;Initial Catalog=BilgiYarismasi;Integrated Security=True");
        int counter = 0;
        int correct = 0;
        string trueAnswer;
        int zaman = 100;
        

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 100;
            counter++;
            lblSoruSayisi.Text = counter.ToString();
            btnBasla.Text = "Sonraki";
            lblDogru.Text = "--";
            btnBasla.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;

            connection.Open();
            SqlCommand command = new SqlCommand("Select * from sorular order by NEWID()", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                txtSoru.Text = (read["soru"].ToString());
                btnA.Text = (read["a"].ToString());
                btnB.Text = (read["b"].ToString());
                btnC.Text = (read["c"].ToString());
                trueAnswer = (read["dogru"].ToString());
                    
            }
            connection.Close();
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;

            if (counter == 33)
            {
                btnBasla.Text = "Bitir";
                lblDogruSayi.Text = correct.ToString();
                int puan = ((correct * 3) + 1);
                lblPuan.Text=puan.ToString();
                timer1.Enabled = false;
                lblSoruSayisi.Text = "33";
                txtSoru.Text = "";
                btnA.Text = "";
                btnB.Text = "";
                btnC.Text = "";

            }
            
           
        }

        private void BilgiYarismasi_Load(object sender, EventArgs e)
        {
            lblSoruSayisi.Text = counter.ToString();


        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if(btnA.Text== trueAnswer)
            {
                btnA.BackColor = Color.MediumSpringGreen;
                correct++;
            }
            else 
            {
                btnA.BackColor = Color.Salmon;
                lblDogru.Text = trueAnswer.ToString();
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == trueAnswer)
            {
                btnB.BackColor = Color.MediumSpringGreen;
                correct++;
            }
            else
            {
                btnB.BackColor = Color.Salmon;
                lblDogru.Text = trueAnswer.ToString();
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnA.Text == trueAnswer)
            {
                btnC.BackColor = Color.MediumSpringGreen;
                correct++;

            }
            else
            {
                btnC.BackColor = Color.Salmon;
                lblDogru.Text = trueAnswer.ToString();
            }
           
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman =zaman- 1;
            lblzaman.Text = zaman.ToString();
            if(zaman==0)
            {
                timer1.Enabled = false;
                btnBasla.Enabled = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
            }
        }
    }
}
