using System.Security.Cryptography.X509Certificates;

namespace _04_Any_All_Contains
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] iller = new string[] { "Ankara", "İstanbul", "İzmir", "Antalya", "Konya", "Hatay", "Kahramanmaraş", "Muğla" };
        List<Personel> personeller = new List<Personel>()
        {
            new Personel() { PersonelId = 1, Adi = "Ayşe", Yas = 38 },
            new Personel() { PersonelId = 2, Adi = "Fatma", Yas = 25 },
            new Personel() { PersonelId = 3, Adi = "Ali", Yas = 28 },
            new Personel() { PersonelId = 4, Adi = "Aykut", Yas = 38 },
            new Personel() { PersonelId = 5, Adi = "Emre", Yas = 23 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //Any() metodu : Elimizdeki listenenin içinde belirlediğimiz şarta uyan en azından bir kayıt bile varsa TRUE değer döndürür yoksa FALSE değer döndürür.

            //All() Metodu : Elimizdeki listenin içerisinde belirlediğimiz şarta tüm kayıtlar uyuyormu diye bakar. Uyarsa TRUE uymazsa FALSE

            //Contains() Metodu : Elimizdeki listenin içerisinde belli şarta uyan kayıt varmı diye bakıyor. TRUE yada FALSE değer döndürür.
        }

        private void btnHepsi18denBuyuk30danKucukMu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.All(x => x.Yas > 18 && x.Yas < 30).ToString());
        }

        private void btnHepsi18denBuyuk40danKucukMu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.All(x => x.Yas > 18 && x.Yas < 40).ToString());
        }

        private void btnYasi18denBuyuk20denKucukVarmi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.Any(x => x.Yas > 18 && x.Yas < 20).ToString());
        }

        private void btnYasi18denBuyuk30denKucukVarmi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.Any(x => x.Yas > 18 && x.Yas < 30).ToString());
        }

        private void btnIsmiAnkaraOlanSehirVarmi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iller.Contains("Ankara").ToString());
        }

        private void btnIsmiAykutOlanPersonelVarmi_Click(object sender, EventArgs e)
        {

            //düzgün çalışmaz her zaman false döner. NOT : Contains metodu sadece basit veri tipleri için kullanılır.
            MessageBox.Show(personeller.Contains(new Personel() { Adi = "Aykut" }).ToString());

            //olması gereken
            MessageBox.Show(personeller.Any(x => x.Adi == "Aykut").ToString());


        }
    }
}

public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
}