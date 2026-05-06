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
    public partial class Form1 : Form
    {
 
        double[] masaBorclari = new double[11];
        public List<string> mevcutUrunler = new List<string>();
        public List<string>[] masaListeleri = new List<string>[11];
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++) masaListeleri[i] = new List<string>();
        }
        private void MasaButon_Click(object sender, EventArgs e)
        {
            Button basilanButon = (Button)sender;
            int masaNo = int.Parse(basilanButon.Tag.ToString());

            SiparisForm siparis = new SiparisForm();
            siparis.masaNo = masaNo;
            siparis.toplamTutar = masaBorclari[masaNo];
            siparis.mevcutUrunler = new List<string>(masaListeleri[masaNo]);

            siparis.ShowDialog();

            masaBorclari[masaNo] = siparis.toplamTutar;
            masaListeleri[masaNo] = new List<string>(siparis.mevcutUrunler);

            if (masaBorclari[masaNo] > 0)
            {
                basilanButon.BackColor = Color.Tomato;
                basilanButon.Text = "Masa " + masaNo + "\n" + masaBorclari[masaNo].ToString("0.00") + " TL";
            }
            else
            {
                basilanButon.BackColor = Color.Transparent; 
                basilanButon.Text = "Masa " + masaNo;
            }
        }
    }
}

    

