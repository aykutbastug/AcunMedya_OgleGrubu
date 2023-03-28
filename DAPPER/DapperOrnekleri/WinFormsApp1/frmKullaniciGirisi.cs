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
    public partial class frmKullaniciGirisi : Form
    {
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           Personel personel = UygulamaAyarlari.MyConnection.Query<Personel>("select * from dbo.Personeller where Email=@email and Sifre=@sifre", param: new { email = txtEmail.Text, sifre = txtSifre.Text }).FirstOrDefault();

            if (personel != null)
            {
                UygulamaAyarlari.GirisYapanPersonel = personel;
                frmAnaSayfa frm = new frmAnaSayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email veya şifreyi hatalı girdiniz..");
            }

        }
    }
}
