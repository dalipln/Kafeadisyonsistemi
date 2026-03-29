using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafesiparişsistemi
{
    public partial class SiparisForm : Form
    {
        int toplamTutar = 0; // Bütün fiyatlar burada toplanacak
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void btnKahveler_Click(object sender, EventArgs e)
        {
            // Buraya hangi paneli görmek istiyorsan onu "true" yap 
            pnlKahveler.Visible = true;
            pnlYiyecekler.Visible = false;
            pnlIcecekler.Visible = false;
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Latte - 220 TL");
            toplamTutar += 220;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            pnlIcecekler.Visible = true;   // İçecek panelini göster
            pnlKahveler.Visible = false;  // Kahveleri gizle
            pnlYiyecekler.Visible = false; // Diğerlerini gizle
        }

        private void pnlYiyecekler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Americano - 210 TL");
            toplamTutar += 210;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Cappuccino - 220 TL");
            toplamTutar += 220;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnTurkKahvesi_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Türk Kahvesi - 125 TL");
            toplamTutar += 125;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnSpanishLatte_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Spanish Latte - 270 TL");
            toplamTutar += 270;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnCaremelLatte_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Caramel Latte - 260 TL");
            toplamTutar += 260;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnSoda_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Soda - 60 TL");
            toplamTutar += 60;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Su - 20 TL");
            toplamTutar += 20;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnLimonata_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Limonata - 140 TL");
            toplamTutar += 140;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnCoolLime_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Cool Lime - 220 TL");
            toplamTutar += 220;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnMilkshake_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Milkshake - 245 TL");
            toplamTutar += 245;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnCay_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Çay - 55 TL");
            toplamTutar += 55;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnAyran_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Ayran - 45 TL");
            toplamTutar += 45;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnPortakalSuyu_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Portakal Suyu - 170 TL");
            toplamTutar += 170;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnRedBull_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Red Bull - 110 TL");
            toplamTutar += 110;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
