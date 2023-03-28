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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            lblAdiSoyadi.Text = UygulamaAyarlari.GirisYapanPersonel.Adi + " " + UygulamaAyarlari.GirisYapanPersonel.Soyadi;
            lblEmail.Text = UygulamaAyarlari.GirisYapanPersonel.Email;


            if (UygulamaAyarlari.GirisYapanPersonel.Gorevi == Gorevler.Yonetici)
            {
                menuYoneticiHarcama.Visible = true;
                menuYoneticiPersonel.Visible = true;
                menuBilgilerim.Visible = true;

                menuPersonelHarcama.Visible = false;
            }
            else
            {
                menuYoneticiHarcama.Visible = false;
                menuYoneticiPersonel.Visible = false;
                menuBilgilerim.Visible = true;

                menuPersonelHarcama.Visible = true;
            }
        }

        private void menuYoneticiPersonel_Click(object sender, EventArgs e)
        {
            frmPersoneller frm = new frmPersoneller();
            frm.ShowDialog();
        }
    }
}
