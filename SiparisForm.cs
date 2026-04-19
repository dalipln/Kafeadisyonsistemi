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
        int toplamTutar = 0;
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void btnKahveler_Click(object sender, EventArgs e)
        {
            

            pnlKahveler.Visible = true;   // Kahveleri göster
            pnlYiyecekler.Visible = false;
            pnlIcecekler.Visible = false;
            pnlTatlilar.Visible = false;
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
            pnlTatlilar.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Kruvasan - 120 TL");
            toplamTutar += 120;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnHindiSandvic_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Hindi Füme Sandviç - 190 TL");
            toplamTutar += 190;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnTonBalikli_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Ton Balıklı Sandviç - 220 TL");
            toplamTutar += 220;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnVeganSandvic_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Vegan Sandviç - 170 TL");
            toplamTutar += 170;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnCikolataliKruvasan_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Çikolatalı Kruvasan - 130 TL");
            toplamTutar += 130;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnZeytinliAcma_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Zeytinli Açma - 100 TL");
            toplamTutar += 100;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnTavukluSalata_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Izgara Tavuklu Salata - 270 TL");
            toplamTutar += 270;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnYiyecekler_Click(object sender, EventArgs e)
        {
            pnlYiyecekler.Visible = true;
            pnlKahveler.Visible = false;
            pnlIcecekler.Visible = false;
            pnlTatlilar.Visible = false;
        }

        private void btnWaffle_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Waffle - 290 TL");
            toplamTutar += 290;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnCookie_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Cookie - 130 TL");
            toplamTutar += 130;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnLimonluCheesecake_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Limonlu Cheesecake - 300 TL");
            toplamTutar += 300;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnCikolataliCheesecake_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Çikolatalı Cheesecake - 300 TL");
            toplamTutar += 300;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnBrownie_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Brownie - 290 TL");
            toplamTutar += 290;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnDondurma_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add("Dondurma (Top) - 50 TL");
            toplamTutar += 50;
            lblToplam.Text = "Toplam: " + toplamTutar + " TL";
        }

        private void btnTatlılar_Click(object sender, EventArgs e)
        {
            pnlTatlilar.Visible = true;   // Tatlıları göster
            pnlKahveler.Visible = false;
            pnlIcecekler.Visible = false;
            pnlYiyecekler.Visible = false;
        }

        private void pnlKahveler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblToplam_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // 1. Önce listeden bir şey seçilmiş mi diye bakıyoruz
            if (lstSiparisler.SelectedIndex != -1)
            {
                // Seçili olanı listeden sil
                lstSiparisler.Items.RemoveAt(lstSiparisler.SelectedIndex);

                // Önemli Not: Toplam fiyatı sıfırlayıp yeniden hesaplatmak en sağlıklısıdır.
                // Ama basit olsun dersen sadece uyarı verelim:
                MessageBox.Show("Ürün çıkarıldı. Lütfen toplam hesabı kontrol edin.");
            }
            else
            {
                MessageBox.Show("Lütfen listeden silmek istediğiniz ürünü seçin!");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. Müşteriye fiş gibi bir mesaj gösterelim
            MessageBox.Show("Sipariş Onaylandı!\nToplam Tahsil Edilen: " + lblToplam.Text);

            // 2. Listeyi boşaltalım (Masa temizlensin)
            lstSiparisler.Items.Clear();

            // 3. Matematiksel toplamı sıfırlayalım
            toplamTutar = 0;

            // 4. Ekrandaki yazıyı sıfırlayalım
            lblToplam.Text = "Toplam: 0,00 TL";
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariş Onaylandı! Tutar: " + lblToplam.Text);
            lstSiparisler.Items.Clear();
            toplamTutar = 0;
            lblToplam.Text = "Toplam: 0,00 TL";

        }


        private void btnSiparisiTemizle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bütün sipariş listesi silinecek. Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                // 2. ListBox'ı tamamen temizle
                lstSiparisler.Items.Clear();

                // 3. Arka plandaki matematiksel toplamı sıfırla
                toplamTutar = 0;

                // 4. Ekranda görünen toplam yazısını sıfırla
                lblToplam.Text = "Toplam: 0,00 TL";

                // 5. Bilgi mesajı göster
                MessageBox.Show("Tüm siparişler temizlendi.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }

        private void btnFisYazdir_Click(object sender, EventArgs e)
        {
            // 1. Fişin başlık kısmını oluşturuyoruz
            string fisMetni = "          CAFE ADİSYON          \n";
            fisMetni += "--------------------------------------\n";
            fisMetni += "Tarih: " + DateTime.Now.ToString("dd.MM.yyyy") + "\n";
            fisMetni += "Saat : " + DateTime.Now.ToString("HH:mm") + "\n";
            fisMetni += "--------------------------------------\n\n";

            // 2. ListBox içindeki tüm ürünleri döngüyle alıyoruz
            foreach (var urun in lstSiparisler.Items)
            {
                fisMetni += urun.ToString() + "\n";
            }

            // 3. Alt toplam kısmını ekliyoruz
            fisMetni += "\n--------------------------------------\n";
            fisMetni += "TOPLAM TUTAR: " + lblToplam.Text + "\n";
            fisMetni += "--------------------------------------\n";
            fisMetni += "      Bizi Tercih Ettiğiniz İçin      \n";
            fisMetni += "           Teşekkür Ederiz!           ";

            // 4. Hazırladığımız bu metni bir mesaj kutusunda gösteriyoruz
            MessageBox.Show(fisMetni, "Adisyon Fişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }
    
    
   
    

