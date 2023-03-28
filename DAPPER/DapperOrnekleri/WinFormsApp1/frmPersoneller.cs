using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            PersonelleriListele();
        }

        //5.Adım
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            //kontrollerin değerleri temizlenecek
            KontrolleriTemizle();
        }

        //4.Adım
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelId.Text == "")
                return;

            //Seçili olan personel silinecek
            UygulamaAyarlari.MyConnection.Execute("delete from dbo.Personeller where PersonelId=@id", param: new { id = txtPersonelId.Text });
            PersonelleriListele();
        }

        //2.Adım
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //controllerdeki verilere uygun olarak kayıt insert edilecek ve liste yeniden doldurualacak
            if (txtPersonelId.Text == "")
            {
                UygulamaAyarlari.MyConnection.Execute("insert into dbo.Personeller values (@adi, @soyadi, @dogumTarihi, @email, @sifre, @telefon, @gorevi)", param:
                    new
                    {
                        adi = txtAdi.Text,
                        soyadi = txtSoyadi.Text,
                        dogumTarihi = dateTimePicker1.Value,
                        email = txtEmail.Text,
                        sifre = txtSifre.Text,
                        telefon = txtTelefon.Text,
                        gorevi = comboBox1.SelectedIndex
                    });
            }
            else
            {
                UygulamaAyarlari.MyConnection.Execute("update dbo.Personeller set Adi=@adi, Soyadi=@soyadi, DogumTarihi=@dogumTarihi, Email=@email, Sifre=@sifre, Telefon=@telefon, Gorevi=@gorevi where PersonelId=@id", param:
                    new
                    {
                        id = txtPersonelId.Text,
                        adi = txtAdi.Text,
                        soyadi = txtSoyadi.Text,
                        dogumTarihi = dateTimePicker1.Value,
                        email = txtEmail.Text,
                        sifre = txtSifre.Text,
                        telefon = txtTelefon.Text,
                        gorevi = comboBox1.SelectedIndex
                    });
            }
            PersonelleriListele();
            KontrolleriTemizle();
        }

        //3.Adım
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //seçili satırdaki personel bilgileri controllere doldurulacak
            KontrolleriTemizle();
            if (dataGridView1.CurrentRow == null)
                return;

            txtPersonelId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox1.SelectedIndex = dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Yonetici" ? 1 : 0;
        }

        //1.Adım
        private void PersonelleriListele()
        {
            List<Personel> personeller = UygulamaAyarlari.MyConnection.Query<Personel>("select * from dbo.Personeller").ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller;
        }

        private void KontrolleriTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
            }
        }
    }
}
