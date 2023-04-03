namespace _07_Sum_Avg_Min_Max_Count
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Personel> personeller = new List<Personel>()
        {
            new Personel() { PersonelId = 1, Adi = "Ayşe", Yas = 38 },
            new Personel() { PersonelId = 2, Adi = "Fatma", Yas = 25 },
            new Personel() { PersonelId = 3, Adi = "Ali", Yas = 28 },
            new Personel() { PersonelId = 4, Adi = "Aykut", Yas = 38 },
            new Personel() { PersonelId = 5, Adi = "Aykut", Yas = 23 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sum() : Elimizdeki listenin belirli alanlarının toplam değerini geriye döner
            //Avg() : Elimizdeki listenin belirli alanlarının ortalama değerini geriye döner
            //Min() : Elimizdeki listenin belirli alanlarının en küçük değerini geriye döner
            //Max() : Elimizdeki listenin belirli alanlarının en büyük değerini geriye döner
            //Count() : Elimizdeki listenin içerisindeki elaman sayısını geriye döner
        }

        private void btnKacTanePersonelVar_Click(object sender, EventArgs e)
        {
            int sonuc = personeller.Count();
            MessageBox.Show(sonuc.ToString());
        }

        private void btnYasi25denBuyukKacPersonelVar_Click(object sender, EventArgs e)
        {
            int sonuc = personeller.Count(x => x.Yas > 25);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnEnYasliPersonelinYasiKac_Click(object sender, EventArgs e)
        {
            int sonuc = personeller.Max(x => x.Yas);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnEnKucukPersonelinYasiKac_Click(object sender, EventArgs e)
        {
            int sonuc = personeller.Min(x => x.Yas);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnTumPersonelYaslariToplami_Click(object sender, EventArgs e)
        {
            int sonuc = personeller.Sum(x => x.Yas);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnYaslarinOrtalamasi_Click(object sender, EventArgs e)
        {
            double sonuc = personeller.Average(x => x.Yas);
            MessageBox.Show(sonuc.ToString());
        }
    }
}


public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
}