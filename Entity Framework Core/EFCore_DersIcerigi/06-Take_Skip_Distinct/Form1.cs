namespace _06_Take_Skip_Distinct
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
            //Take() : SQL deki TOP keyword'üne karşılık gelmektedir. Yani Elimizdeki listenin içerisindeki ilk n kaydı geriye döner. (İlk 5, ilk 10 vb)

            //Skip() : Elimizdeki listenin içindeki ilk n kaydı atlar ve sonrakileri geriye döner.

            //Distinct() : Yinelenen satırları kaldırarak tekil olarak liste halinde geriye döner.
        }

        private void btnTumunuGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller;
        }

        private void btnIlk2KaydiGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller.Take(2).ToList();
        }

        private void btnIlk2KaydiAtlaSonraki2KaydiGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller.Skip(2).Take(2).ToList();
        }

        private void btnPersonelIsimleriniTekilOlarakGetir_Click(object sender, EventArgs e)
        {
            List<string> list = personeller.Select(x => x.Adi).Distinct().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;

            string isimler = string.Join(", ", list);
            MessageBox.Show(isimler);
        }
    }
}


public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
}