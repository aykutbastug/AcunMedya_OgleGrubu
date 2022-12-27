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
    public partial class frmMusteriSil : Form
    {
        Form1 form1;    
        public frmMusteriSil(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Musteri musteri = (Musteri)form1.listBox1.SelectedItem;
            form1.Musteriler.Remove(musteri);
            form1.ListeyiDoldur();
            this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
