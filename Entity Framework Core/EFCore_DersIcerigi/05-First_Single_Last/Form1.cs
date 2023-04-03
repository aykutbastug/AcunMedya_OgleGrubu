namespace _05_First_Single_Last
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
            new Personel() { PersonelId = 5, Adi = "Emre", Yas = 23 }
        };

        List<Personel> personelBos = new List<Personel>();

        List<Personel> personelTek = new List<Personel>()
        {
            new Personel() { PersonelId = 1, Adi = "Özgür", Yas = 38 }
        };


        private void Form1_Load(object sender, EventArgs e)
        {
            //First() : Elimizdeki listenin içindeki ilk elemanı döner. Eğer eleman yoksa hata fırlatır.
            //FirstOrDefault() : Elimizdeki listenin içindeki ilk elemanı döner. Ama eleman yoksa hata fırlatmaz elemanın varsayılan değerleriyle bir nesne döner.


            //Single() : Elimizdeki listenin içinde bir tane eleman varmı yok yokmu diye bakar, bir tane varsa o elemanı geriye döner yoksa veya birden fazla ise hata verir.
            //SingleOrDefault() : Elimizdeki listenin içinde bir tane eleman varmı yok yokmu diye bakar, bir tane varsa o elemanı geriye döner yoksa hata vermez varsayılan değeri döner, ama birden fazla kayıt varsa yine hata fırlatır.


            //Last() : Elimizdeki listenin içindeki son elemanı döner. Eğer eleman yoksa hata fırlatır.
            //LastOrDefault() : Elimizdeki listenin içindeki son elemanı döner. Ama eleman yoksa hata fırlatmaz elemanın varsayılan değerleriyle bir nesne döner.

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.First(x => x.Yas > 25 && x.Adi == "Ahmet");

            MessageBox.Show(personel.Adi);
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.FirstOrDefault(x => x.Yas > 25 && x.Adi == "Ahmet");

            MessageBox.Show(personel.Adi);
        }

        private void btnFirstBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.First();

            MessageBox.Show(personel.Adi);
        }

        private void btnFirstOrDefaultBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.FirstOrDefault();

            MessageBox.Show(personel.Adi);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.Last();
        }

        private void btnLastOrDefault_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.LastOrDefault();
        }

        private void btnLastBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.Last();
        }

        private void btnLastOrDefaultBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.LastOrDefault();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            //Personel personel = personeller.Single();
            Personel personel = personelTek.Single();
        }

        private void btnSingleOrDefault_Click(object sender, EventArgs e)
        {
            //Personel personel = personeller.SingleOrDefault();
            Personel personel = personelTek.SingleOrDefault();
        }

        private void btnSingleBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.Single();
        }

        private void btnSingleOrDefaultBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.SingleOrDefault();
        }
    }
}

public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
}