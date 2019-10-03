using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakKayitProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullanici.Text=="admin" && txtSifre.Text=="admin")
            {
                Anasayfa emlakkayit = new Anasayfa();
                emlakkayit.Show();
                this.Hide();
            }
        }
    }
}
