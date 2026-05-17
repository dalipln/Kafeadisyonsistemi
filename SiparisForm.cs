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
        public double toplamTutar = 0;
        public int masaNo = 0;
        public List<string> mevcutUrunler = new List<string>();

        public SiparisForm()
        {
            InitializeComponent();
            foreach (string urun in mevcutUrunler)
            {
                lstSiparisler.Items.Add(urun);
            }
            lblToplam.Text = "Toplam: " + toplamTutar.ToString("0.00") + " TL";
        }
            private void UrunEkle(string urunAdi, double fiyat)
        {
            string urunBilgi = urunAdi + " - " + fiyat + " TL";
            lstSiparisler.Items.Add(urunBilgi); 
            mevcutUrunler.Add(urunBilgi);     
            toplamTutar += fiyat;
            lblToplam.Text = "Toplam: " + toplamTutar.ToString("0.00") + " TL";
        }


       
        private void SiparisForm_Load(object sender, EventArgs e)
        {
            lstSiparisler.Items.Clear(); 
            if (mevcutUrunler != null)
            {
                foreach (string urun in mevcutUrunler)
                {
                    lstSiparisler.Items.Add(urun); 
                }
            }
            lblToplam.Text = "Toplam: " + toplamTutar.ToString("0.00") + " TL";
        }
        private void btnKahveler_Click(object sender, EventArgs e)
        {
            

            pnlKahveler.Visible = true;  
            pnlYiyecekler.Visible = false;
            pnlIcecekler.Visible = false;
            pnlTatlilar.Visible = false;
        }
        private void btnLatte_Click(object sender, EventArgs e) { UrunEkle("Latte", 220); }
     
        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            pnlIcecekler.Visible = true;   
            pnlKahveler.Visible = false; 
            pnlYiyecekler.Visible = false; 
            pnlTatlilar.Visible = false;
        }

        private void pnlYiyecekler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAmericano_Click(object sender, EventArgs e) {  UrunEkle("Americano", 180); }

        private void btnCappuccino_Click(object sender, EventArgs e) { UrunEkle("Cappuccino", 220); }

        private void btnTurkKahvesi_Click(object sender, EventArgs e) { UrunEkle("Türk Kahvesi", 125); }

        private void btnSpanishLatte_Click(object sender, EventArgs e) { UrunEkle("Spanish Latte", 270); }
        private void btnCaramelLatte_Click(object sender, EventArgs e) { UrunEkle("Caramel Latte", 260); }
        private void btnSoda_Click(object sender, EventArgs e) { UrunEkle("Soda", 60); }

        private void btnSu_Click(object sender, EventArgs e) { UrunEkle("Su", 20); }
        private void btnLimonata_Click(object sender, EventArgs e) { UrunEkle("Limonata", 140); }
        private void btnCoolLime_Click(object sender, EventArgs e) { UrunEkle("Cool Lime", 220); }
        private void btnMilkshake_Click(object sender, EventArgs e) { UrunEkle("Milkshake", 245); }
        private void btnCay_Click(object sender, EventArgs e) { UrunEkle("Çay", 55); }
        private void btnAyran_Click(object sender, EventArgs e) { UrunEkle("Ayran", 45); }
        private void btnPortakalSuyu_Click(object sender, EventArgs e) { UrunEkle("Portakal Suyu", 170); }
        private void btnRedBull_Click(object sender, EventArgs e) { UrunEkle("Red Bull", 110); }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHindiFume_Click(object sender, EventArgs e) { UrunEkle("Hindi Füme Sandviç", 190); }
        private void btnTonBalikli_Click(object sender, EventArgs e) { UrunEkle("Ton Balıklı Sandviç", 220); }
        private void btnKruvasan_Click(object sender, EventArgs e) { UrunEkle("Kruvasan", 120); }
        private void btnVeganSandvic_Click(object sender, EventArgs e) { UrunEkle("Vegan Sandviç", 170); }
        private void btnCikolataliKruvasan_Click(object sender, EventArgs e) { UrunEkle("Çikolatalı Kruvasan", 130); }
        private void btnZeytinliAcma_Click(object sender, EventArgs e) { UrunEkle("Zeytinli Açma", 100); }
        private void btnTavukluSalata_Click(object sender, EventArgs e) { UrunEkle("Tavuklu Salata", 270); }

        private void btnYiyecekler_Click(object sender, EventArgs e)
        {
            pnlYiyecekler.Visible = true;
            pnlKahveler.Visible = false;
            pnlIcecekler.Visible = false;
            pnlTatlilar.Visible = false;
        }

        private void btnWaffle_Click(object sender, EventArgs e) { UrunEkle("Waffle", 290); }
        private void btnCookie_Click(object sender, EventArgs e) { UrunEkle("Cookie", 130); }
        private void btnLimonluCheesecake_Click(object sender, EventArgs e) { UrunEkle("Limonlu Cheesecake", 300); }
        private void btnCikolataliCheesecake_Click(object sender, EventArgs e) { UrunEkle("Çikolatalı Cheesecake", 300); }
        private void btnBrowni_Click(object sender, EventArgs e) { UrunEkle("Browni", 290); }
        private void btnDondurma_Click(object sender, EventArgs e) { UrunEkle("Dondurma (Top)", 50); }

        private void btnTatlılar_Click(object sender, EventArgs e)
        {
            pnlTatlilar.Visible = true;   
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
            if (lstSiparisler.SelectedIndex != -1) 
            {
         
                string seciliUrun = lstSiparisler.SelectedItem.ToString();
                string[] parcalar = seciliUrun.Split('-');
                string fiyatParcasi = parcalar[1].Replace("TL", "").Trim();
                double silinecekFiyat = Convert.ToDouble(fiyatParcasi);

                toplamTutar -= silinecekFiyat;

           
                int index = lstSiparisler.SelectedIndex;
                lstSiparisler.Items.RemoveAt(index);
                mevcutUrunler.RemoveAt(index); 
                lblToplam.Text = "Toplam: " + toplamTutar.ToString("0.00") + " TL";
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü listeden seçin.");
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
        
            MessageBox.Show("Sipariş Onaylandı!\nToplam Tahsil Edilen: " + lblToplam.Text);

            lstSiparisler.Items.Clear();

            toplamTutar = 0;


            lblToplam.Text = "Toplam: 0,00 TL";
       
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Siparişler masaya kaydedildi!");
            this.Close(); 
        }

        private void btnSiparisiTemizle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bütün sipariş listesi silinecek. Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();
                toplamTutar = 0;
                mevcutUrunler.Clear();

                lblToplam.Text = "Toplam: 0,00 TL";
                MessageBox.Show("Tüm siparişler temizlendi.");
            }
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }

        private void btnFisYazdir_Click(object sender, EventArgs e)
        {
    
            string fisMetni = "          CAFE ADİSYON          \n";
            fisMetni += "--------------------------------------\n";
            fisMetni += "Tarih: " + DateTime.Now.ToString("dd.MM.yyyy") + "\n";
            fisMetni += "Saat : " + DateTime.Now.ToString("HH:mm") + "\n";
            fisMetni += "--------------------------------------\n\n";

            foreach (var urun in lstSiparisler.Items)
            {
                fisMetni += urun.ToString() + "\n";
            }

            fisMetni += "\n--------------------------------------\n";
            fisMetni += "TOPLAM TUTAR: " + lblToplam.Text + "\n";
            fisMetni += "--------------------------------------\n";
            fisMetni += "      Bizi Tercih Ettiğiniz İçin      \n";
            fisMetni += "           Teşekkür Ederiz!           ";

            MessageBox.Show(fisMetni, "Adisyon Fişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
 
            toplamTutar = 0;
            mevcutUrunler.Clear(); 
            lstSiparisler.Items.Clear(); 

            this.Close(); 
        }

 
        

        }
    }
    
    
    
   
    

