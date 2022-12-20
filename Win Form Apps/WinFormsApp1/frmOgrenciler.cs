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
    public partial class frmOgrenciler : Form
    {
        public frmOgrenciler()
        {
            InitializeComponent();
        }

        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        private void frmOgrenciler_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = ogrenciler.Count + 1;
            ogrenci.Adi = txtAdi.Text;  
            ogrenci.Soyadi= txtSoyadi.Text;
            ogrenci.EMail = txtEmail.Text;
            ogrenci.DogumTarihi = dateDogumtarihi.Value;
            
            ogrenciler.Add(ogrenci);

            OgrencileriListele();
        }

        void OgrencileriListele()
        {
            listBox1.DisplayMember = "FullName";
            listBox1.ValueMember = "Id";

            listBox1.Items.Clear();
            foreach (Ogrenci item in ogrenciler)
            {
                listBox1.Items.Add(item);
            }


            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtEmail.Text = "";
            dateDogumtarihi.Value = DateTime.Now;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int ogrenciId = ((Ogrenci)listBox1.SelectedItem).Id;
            var ogrenci = ogrenciler.Where(x => x.Id == ogrenciId).FirstOrDefault();
            //ogrenciler.Remove(ogrenci);

            txtAdi.Text = ogrenci.Adi;
            txtSoyadi.Text = ogrenci.Soyadi;
            txtEmail.Text = ogrenci.EMail;
            dateDogumtarihi.Value = ogrenci.DogumTarihi;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1_DoubleClick(sender, e);
        }
    }

    public class Ogrenci
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string EMail { get; set; }
        public DateTime DogumTarihi { get; set; }

        public string FullName { get { return Adi + " " +  Soyadi; }  }
    }
}
