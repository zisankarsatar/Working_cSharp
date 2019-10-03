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

namespace EmlakKayitProgramı
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ECAMK9C\\ZISANSQL;Initial Catalog=Siteler;Integrated Security=True");
        private void verileriGoster()
        {
            Listele.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from sitebilgi", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());

                Listele.Items.Add(ekle);
            }
            baglan.Close();

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void cmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSite.Text == "ZirvePark")
            {
                btnZirve.BackColor = Color.Yellow;
                btnHasBahce.BackColor = Color.Gray;
                btnDreamCity.BackColor = Color.Gray;
                btnPalmiye.BackColor = Color.Gray;
            }

            if (cmbSite.Text == "HasBahce")
            {
                btnZirve.BackColor = Color.Gray;
                btnHasBahce.BackColor = Color.Yellow;
                btnDreamCity.BackColor = Color.Gray;
                btnPalmiye.BackColor = Color.Gray;
            }

            if (cmbSite.Text == "DreamCity")
            {
                btnZirve.BackColor = Color.Gray;
                btnHasBahce.BackColor = Color.Gray;
                btnDreamCity.BackColor = Color.Yellow;
                btnPalmiye.BackColor = Color.Gray;
            }

            if (cmbSite.Text == "Palmiye")
            {
                btnZirve.BackColor = Color.Gray;
                btnHasBahce.BackColor = Color.Gray;
                btnDreamCity.BackColor = Color.Gray;
                btnPalmiye.BackColor = Color.Yellow;
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into siteBilgi (site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values " +
                "('" + cmbSite.Text.ToString() + "','" + cmbOda.Text.ToString() +"','" + txtMetre.Text.ToString() + "','" + txtFiyat.Text.ToString() + "','"
                + cmbBlok.Text.ToString() + "','"+ txtNo.Text.ToString() + "','" + txtAd.Text.ToString() + "','"
                + txtTelefon.Text.ToString() + "','" + txtNot.Text.ToString() + "','" + cmbSatKira.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verileriGoster();

            cmbSite.Text = "";
            cmbOda.Text = "";
            txtMetre.Text = "";
            txtFiyat.Text = "";
            cmbBlok.Text = "";
            txtNo.Text = "";
            txtAd.Text = "";
            txtTelefon.Text = "";
            txtNot.Text = "";
            cmbSatKira.Text = "";
        }
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from siteBilgi where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verileriGoster();
        }

        private void Listele_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(Listele.SelectedItems[0].SubItems[0].Text);
            cmbSite.Text = Listele.SelectedItems[0].SubItems[1].Text;
            cmbOda.Text = Listele.SelectedItems[0].SubItems[2].Text;
            txtMetre.Text = Listele.SelectedItems[0].SubItems[3].Text;
            txtFiyat.Text = Listele.SelectedItems[0].SubItems[4].Text;
            cmbBlok.Text = Listele.SelectedItems[0].SubItems[5].Text;
            txtNo.Text = Listele.SelectedItems[0].SubItems[6].Text;
            txtAd.Text = Listele.SelectedItems[0].SubItems[7].Text;
            txtTelefon.Text = Listele.SelectedItems[0].SubItems[8].Text;
            txtNot.Text = Listele.SelectedItems[0].SubItems[9].Text;
            cmbSatKira.Text = Listele.SelectedItems[0].SubItems[10].Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            btnZirve.BackColor = Color.Gray;
            btnHasBahce.BackColor = Color.Gray;
            btnDreamCity.BackColor = Color.Gray;
            btnPalmiye.BackColor = Color.Gray;

            baglan.Open();
            SqlCommand komut = new SqlCommand("update siteBilgi set site='" + cmbSite.Text.ToString() + "',oda='" + cmbOda.Text.ToString() +
                "',metre='" + txtMetre.Text.ToString() + "',fiyat='" + txtFiyat.Text.ToString() + "',blok='" + cmbBlok.Text.ToString() + "',no='"
                + txtNo.Text.ToString() + "',adsoyad='" + txtAd.Text.ToString() + "',telefon='"
                + txtTelefon.Text.ToString() + "',notlar='" + txtNot.Text.ToString() + "',satkira='" + cmbSatKira.Text.ToString() + "' where id="+id+"", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verileriGoster();
        }

     
    }
}
