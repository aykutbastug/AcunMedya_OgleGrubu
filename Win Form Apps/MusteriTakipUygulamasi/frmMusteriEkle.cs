using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakipUygulamasi
{
    public partial class frmMusteriEkle : Form
    {
        Form1 form1;
        public frmMusteriEkle(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            txtId.Text = (form1.Musteriler.Count() + 1).ToString();
            txtKayitTarihi.Text = DateTime.Now.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Adi = txtAdi.Text;
            musteri.Soyadi = txtSoyadi.Text;
            musteri.Telefon = txtTelefon.Text;
            musteri.Email = txtEmail.Text;
            musteri.Adres = txtAdres.Text;
            musteri.Id = form1.Musteriler.Count() + 1;

            musteri.FaturaBilgisi.Unvan = txtUnvan.Text;
            musteri.FaturaBilgisi.VergiDairesi = txtVergiDairesi.Text;
            musteri.FaturaBilgisi.VergiNo = txtVergiNo.Text;

            form1.Musteriler.Add(musteri);
            form1.ListeyiDoldur();
            this.Close();   
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu formu kapatmak istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            this.Close();
        }

        private void frmMusteriEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnKaydet_Click(btnKaydet, null);
            }
            else if (e.KeyCode == Keys.Escape) {
                btnVazgec_Click(btnVazgec, null);
            }
        }
    }
}
