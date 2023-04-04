namespace _08_Group_Join
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Departman> departmanlar = new List<Departman>()
        {
            new Departman(){ DepartmanId = 1, DepartmanAdi = "Bilgi İşlem" },
            new Departman(){ DepartmanId = 2, DepartmanAdi = "Muhasebe" },
            new Departman(){ DepartmanId = 3, DepartmanAdi = "Satın Alma" }
        };

        List<Personel> personeller = new List<Personel>()
        {
            new Personel() { PersonelId = 1, Adi = "Ayşe", Yas = 38, DepartmanId = 1 },
            new Personel() { PersonelId = 2, Adi = "Fatma", Yas = 25, DepartmanId = 1 },
            new Personel() { PersonelId = 3, Adi = "Ali", Yas = 25, DepartmanId = 2 },
            new Personel() { PersonelId = 4, Adi = "Aykut", Yas = 38, DepartmanId = 3 },
            new Personel() { PersonelId = 5, Adi = "Ahmet", Yas = 23, DepartmanId = 3 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnYasaGoreGrupla_Click(object sender, EventArgs e)
        {
            //AMAÇ:
            //SATIR 1 : 38 - Ayşe, Aykut
            //SATIR 2 : 25 - Fatma, Ali

            var list = personeller.GroupBy(x => x.Yas).ToList();

            List<PersonelSatir> yeniPersonelListesi = new List<PersonelSatir>();
            foreach (var item in list)
            {
                PersonelSatir personelSatir = new PersonelSatir();
                personelSatir.Yas = item.Key;
                personelSatir.Isimler = string.Join(", ", item.Select(x => x.Adi));

                yeniPersonelListesi.Add(personelSatir);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = yeniPersonelListesi;

        }

        private void btnPersonelDepartman_Click(object sender, EventArgs e)
        {
            //ÇIKTI
            //PersonelinAdi, DepartmanınAdi

            var sonuc = personeller.Join(
                                        departmanlar,
                                        p => p.DepartmanId,
                                        d => d.DepartmanId,
                                        (personel, departman) => new PersonelDepartman { 
                                            PersonelAdi = personel.Adi,
                                            DepartmanAdi = departman.DepartmanAdi
                                        }).ToList();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sonuc;
        }
    }
}


public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
    public int DepartmanId { get; set; }
}

public class Departman
{
    public int DepartmanId { get; set; }
    public string DepartmanAdi { get; set; }
}

public class PersonelSatir
{
    public int Yas { get; set; }
    public string Isimler { get; set; }
}

public class PersonelDepartman
{
    public string PersonelAdi { get; set; }
    public string DepartmanAdi { get; set; }
}