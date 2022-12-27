using System.Linq;
using System.Windows.Forms;

namespace MusteriTakipUygulamasi
{
    public partial class Form1 : Form
    {
        public List<Musteri> Musteriler = new List<Musteri>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 16; i++)
            {
                Musteri musteri = new Musteri
                {
                    Adi = "Müşteri " + i,
                    Soyadi = "Soyadı",
                    Adres = "Müşteri " + i + " Adresi",
                    Email = "musteri@" + i + ".com",
                    Id = i,
                    Telefon = "543111111" + i
                };
                musteri.FaturaBilgisi.Unvan = "Müşteri " + i + " Ünvan";
                musteri.FaturaBilgisi.VergiDairesi = "VergiDairesi" + i;
                musteri.FaturaBilgisi.VergiNo = "VergiNo" + i;
                Musteriler.Add(musteri);
            }

            ListeyiDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle _frmMusteriEkle = new frmMusteriEkle(this);
            _frmMusteriEkle.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Musteri musteri = (Musteri)listBox1.SelectedItem;
            frmMusteriSil _frmMusteriSil = new frmMusteriSil(this);
            _frmMusteriSil.lblSoru.Text = musteri.GorunenIsim + " müşterisini silmek istiyor musunuz ?";
            _frmMusteriSil.ShowDialog();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int musteriId = ((Musteri)listBox1.SelectedItem).Id;
            Musteri musteri = Musteriler.Where(x => x.Id == musteriId).FirstOrDefault();

            musteri.Adi = txtAdi.Text;
            musteri.Soyadi = txtSoyadi.Text;
            musteri.Telefon= txtTelefon.Text;   
            musteri.Email= txtEmail.Text;
            musteri.Adres= txtAdres.Text;
            musteri.FaturaBilgisi.Unvan = txtUnvan.Text;
            musteri.FaturaBilgisi.VergiDairesi = txtVergiDairesi.Text;
            musteri.FaturaBilgisi.VergiNo = txtVergiNo.Text;

            ListeyiDoldur();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;

            if (listBox1.SelectedItem == null)
                return;

            Musteri _musteri = (Musteri)listBox1.SelectedItem;

            txtId.Text = _musteri.Id.ToString();
            txtKayitTarihi.Text = _musteri.KayitTarihi.ToString();
            txtAdi.Text = _musteri.Adi;
            txtSoyadi.Text = _musteri.Soyadi;
            txtTelefon.Text = _musteri.Telefon;
            txtEmail.Text = _musteri.Email;
            txtAdres.Text = _musteri.Adres;

            txtUnvan.Text = _musteri.FaturaBilgisi.Unvan;
            txtVergiDairesi.Text = _musteri.FaturaBilgisi.VergiDairesi;
            txtVergiNo.Text = _musteri.FaturaBilgisi.VergiNo;


            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
        }

        public void ListeyiDoldur()
        {
            listBox1.Items.Clear();
            //listBox1.DataSource = null;
            listBox1.DisplayMember = "GorunenIsim";
            listBox1.ValueMember = "Id";
            //listBox1.DataSource = Musteriler;

            foreach (var item in Musteriler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void fdgdfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(); 
        }

        private void örnekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("deneme");
        }

        private void sdfgsdfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3form3 = new Form3();
            form3form3.ShowDialog();
        }
    }
}