using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cSharp_Tarayıcı
{
    public partial class cSharp : Form
    {
        public cSharp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtSearch.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com/");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.facebook.com");
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.linkedin.com");
        }

        private void btnTwit_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://twitter.com/");
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.instagram.com/?hl=tr");
        }

        private void btnKral_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = "http://46.20.3.204:80/";
        }

        private void btnJoy_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = "http://provisioning.streamtheworld.com/pls/JOY_TURKAAC.pls";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = "http://46.20.4.60/listen.pls";
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = "http://powerfm.listenpowerapp.com/powerfm/abr/playlist.m3u8";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void onedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://onedio.com");
        }

        private void milliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.n11.com");
        }

        private void fanatikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.modanisa.com/");
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBaslik_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser.DocumentTitle.ToString());
        }

        private void btnKaynak_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser.DocumentText);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtSearch.Text = webBrowser.Url.ToString();
            string zaman = DateTime.Now.Day+"."+ DateTime.Now.Month+"."+DateTime.Now.Year;
            string zaman2 = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            FileStream f = new FileStream("Gecmis.txt",FileMode.Append);
            StreamWriter yaz = new StreamWriter(f);
            yaz.WriteLine(webBrowser.DocumentTitle + " /" + zaman + " /" + zaman2 );
            yaz.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatuslblDurum.Text = webBrowser.StatusText;
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {
                toolStripProgressBar.Minimum = 0;
            }
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            gecmisiYukle();
        }
        private void gecmisiYukle()
        {
            lstGecmis.Items.Clear();
            StreamReader dosya = new StreamReader("Gecmis.txt");
            while(!dosya.EndOfStream)
            {
                lstGecmis.Items.Add(dosya.ReadLine());
            }
            dosya.Close();
        }

        private void btnGecmisSil_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = new StreamWriter("Gecmis.txt");
            dosya.Write("");
            dosya.Close();
            gecmisiYukle();
        }
    }
}
