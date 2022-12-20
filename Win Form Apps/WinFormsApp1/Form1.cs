using System.Security.AccessControl;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Text= "";

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = "Aykut";
            ogrenci.Soyadi = "Baştuğ";

            //ogrenci.OzlukBilgisi = new OgrenciOzlukBilgisi();
            //ogrenci.OzlukBilgisi.AnneAdi = "aasas";
            //ogrenci.OzlukBilgisi.BabaAdi = "zazz";

            //OgrenciOzlukBilgisi ozlukBilgisi = new OgrenciOzlukBilgisi();
            //ozlukBilgisi.AnneAdi = "aasas";
            //ozlukBilgisi.BabaAdi = "zazz";
            //ogrenci.OzlukBilgisi = ozlukBilgisi;
            //string adi = "";
            //this.Text = "";


            dateTimePicker1.Value = DateTime.Now;

            comboBox1.Items.Add("Böl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Örnek uygulama";
        }

        private void ButunaTiklandi(object sender, EventArgs e)
        {
            //this.Text = "aaaaa aaaa";
            //txtAdi.Text = "Örnek öğrenci adı";

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("İşlem tipi seçmediniz...");
                return;
            }

            MessageBox.Show(comboBox1.Text);
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Text = this.Width.ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("İşlem tipi seçmeden devam edemezsiniz.");
                return;
            }

            decimal sonuc = 0;

            if (comboBox1.Text == "Topla")
                sonuc = nupSayi1.Value + nupSayi2.Value;
            else if (comboBox1.Text == "Çarp")
                sonuc = nupSayi1.Value * nupSayi2.Value;
            else if (comboBox1.Text == "Çıkar")
                sonuc = nupSayi1.Value - nupSayi2.Value;
            else if (comboBox1.Text == "Böl")
                sonuc = nupSayi1.Value / nupSayi2.Value;


            lblSonuc.Text = sonuc.ToString("n3");
        }
    }

    //public class Ogrenci
    //{
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public string EMail { get; set; }
    //    public DateTime DogumTarihi { get; set; }

    //    public OgrenciOzlukBilgisi OzlukBilgisi { get; set; } = new OgrenciOzlukBilgisi();

    //}

    //public class OgrenciOzlukBilgisi
    //{
    //    public string KimlikNo { get; set; }

    //    public string AnneAdi { get; set; }
    //    public string BabaAdi { get; set; }
    //}
}

