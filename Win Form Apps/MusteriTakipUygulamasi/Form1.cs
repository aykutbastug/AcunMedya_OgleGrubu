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

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusteriEkle = new frmMusteriEkle(this);
            frmMusteriEkle.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        public void ListeyiDoldur()
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "GorunenIsim";
            listBox1.ValueMember = "Id";
            listBox1.DataSource = Musteriler;
        }
    }
}