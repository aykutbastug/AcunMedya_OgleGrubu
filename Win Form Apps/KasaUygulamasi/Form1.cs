namespace KasaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Kiraz";
            item.ImageKey = "kiraz";
            item.SubItems.Add("33");
            item.SubItems.Add("Meyve");
            listUrunler.Items.Add(item);

            ListViewItem item2 = new ListViewItem();
            item2.Text = "Çilek";
            item2.ImageKey = "cilek";
            item2.SubItems.Add("45");
            item2.SubItems.Add("Meyve");
            listUrunler.Items.Add(item2);

            ListViewItem item3 = new ListViewItem();
            item3.Text = "Elma";
            item3.ImageKey = "elma";
            item3.SubItems.Add("17");
            item3.SubItems.Add("Meyve");
            listUrunler.Items.Add(item3);
        }

        private void büyükSimgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listUrunler.View = View.LargeIcon;
        }

        private void küçükSimgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listUrunler.View = View.SmallIcon;
        }

        private void detaylıGörünümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listUrunler.View = View.Details;
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listUrunler.View = View.List;
        }

        private void döşemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listUrunler.View = View.Tile;
        }

        private void listUrunler_DoubleClick(object sender, EventArgs e)
        {
            if (listUrunler.SelectedItems.Count == 0)
                return;

            var seciliUrun = listUrunler.SelectedItems[0];
            int fiyat = Convert.ToInt32(seciliUrun.SubItems[1].Text);

            ListViewItem varOlan = null;
            foreach (ListViewItem listItem in listSepet.Items)
            {
                if (listItem.Text == seciliUrun.Text)
                {
                    varOlan = listItem;
                    break;
                }
            }

            if (varOlan != null)
            {
                int miktar = int.Parse(varOlan.SubItems[2].Text);
                miktar = miktar + 1;
                int tutar = miktar * fiyat;
                varOlan.SubItems[2].Text = miktar.ToString();
                varOlan.SubItems[3].Text = tutar.ToString("n2");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = seciliUrun.Text;
                item.ImageKey = seciliUrun.ImageKey;
                item.SubItems.Add(fiyat.ToString("n2") + " ₺");
                item.SubItems.Add("1");
                item.SubItems.Add(fiyat.ToString("n2") + " ₺");
                listSepet.Items.Add(item);
            }
            SepetTutariniHesapla();
        }


        private void SepetTutariniHesapla()
        {
            decimal sepetToplami = 0;

            foreach (ListViewItem item in listSepet.Items)
            {
                sepetToplami += Convert.ToDecimal(item.SubItems[3].Text.Replace(" ₺", ""));
            }

            lblSepetToplami.Text = sepetToplami.ToString("n2") + " ₺";
        }

        private void btnMiktarArttir_Click(object sender, EventArgs e)
        {
            if (listSepet.SelectedItems.Count == 0)
                return;

            decimal fiyat = Convert.ToDecimal(listSepet.SelectedItems[0].SubItems[1].Text.Replace(" ₺", ""));
            decimal miktar = decimal.Parse(listSepet.SelectedItems[0].SubItems[2].Text);
            miktar = miktar + 1;
            decimal tutar = miktar * fiyat;

            listSepet.SelectedItems[0].SubItems[2].Text = miktar.ToString();
            listSepet.SelectedItems[0].SubItems[3].Text = tutar.ToString("n2") + " ₺";

            SepetTutariniHesapla();
        }

        private void btnMiktarAzalt_Click(object sender, EventArgs e)
        {
            if (listSepet.SelectedItems.Count == 0)
                return;

            decimal fiyat = Convert.ToDecimal(listSepet.SelectedItems[0].SubItems[1].Text.Replace(" ₺", ""));
            decimal miktar = decimal.Parse(listSepet.SelectedItems[0].SubItems[2].Text);


            if (miktar == 1)
            {
                listSepet.Items.Remove(listSepet.SelectedItems[0]);
            }
            else
            {
                miktar = miktar - 1;
                decimal tutar = miktar * fiyat;

                listSepet.SelectedItems[0].SubItems[2].Text = miktar.ToString();
                listSepet.SelectedItems[0].SubItems[3].Text = tutar.ToString("n2") + " ₺";
            }

            SepetTutariniHesapla();
        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            if (listSepet.SelectedItems.Count == 0)
                return;

            listSepet.Items.Remove(listSepet.SelectedItems[0]);
            SepetTutariniHesapla();
        }

        private void btnSepetiTemizle_Click(object sender, EventArgs e)
        {
            if (listSepet.Items.Count == 0)
                return;

            if (MessageBox.Show("Sepetteki ürünleri kaldırmak istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            listSepet.Items.Clear();
            SepetTutariniHesapla();
        }
    }
}