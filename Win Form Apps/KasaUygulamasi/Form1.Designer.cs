namespace KasaUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ekmek",
            "5",
            "Fırın"}, "ekmek");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.büyükSimgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçükSimgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylıGörünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.döşemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listSepet = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSepetiTemizle = new System.Windows.Forms.Button();
            this.btnSepettenCikar = new System.Windows.Forms.Button();
            this.btnMiktarAzalt = new System.Windows.Forms.Button();
            this.btnMiktarArttir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSepetToplami = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUrunler
            // 
            this.listUrunler.BackColor = System.Drawing.SystemColors.Control;
            this.listUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listUrunler.ContextMenuStrip = this.contextMenuStrip1;
            this.listUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUrunler.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listUrunler.LargeImageList = this.ımageList2;
            this.listUrunler.Location = new System.Drawing.Point(0, 0);
            this.listUrunler.Name = "listUrunler";
            this.listUrunler.Size = new System.Drawing.Size(406, 665);
            this.listUrunler.SmallImageList = this.ımageList1;
            this.listUrunler.TabIndex = 0;
            this.listUrunler.UseCompatibleStateImageBehavior = false;
            this.listUrunler.DoubleClick += new System.EventHandler(this.listUrunler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Fiyatı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.büyükSimgeToolStripMenuItem,
            this.küçükSimgeToolStripMenuItem,
            this.detaylıGörünümToolStripMenuItem,
            this.listeToolStripMenuItem,
            this.döşemeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 114);
            // 
            // büyükSimgeToolStripMenuItem
            // 
            this.büyükSimgeToolStripMenuItem.Name = "büyükSimgeToolStripMenuItem";
            this.büyükSimgeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.büyükSimgeToolStripMenuItem.Text = "Büyük Simge";
            this.büyükSimgeToolStripMenuItem.Click += new System.EventHandler(this.büyükSimgeToolStripMenuItem_Click);
            // 
            // küçükSimgeToolStripMenuItem
            // 
            this.küçükSimgeToolStripMenuItem.Name = "küçükSimgeToolStripMenuItem";
            this.küçükSimgeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.küçükSimgeToolStripMenuItem.Text = "Küçük Simge";
            this.küçükSimgeToolStripMenuItem.Click += new System.EventHandler(this.küçükSimgeToolStripMenuItem_Click);
            // 
            // detaylıGörünümToolStripMenuItem
            // 
            this.detaylıGörünümToolStripMenuItem.Name = "detaylıGörünümToolStripMenuItem";
            this.detaylıGörünümToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.detaylıGörünümToolStripMenuItem.Text = "Detaylı Görünüm";
            this.detaylıGörünümToolStripMenuItem.Click += new System.EventHandler(this.detaylıGörünümToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // döşemeToolStripMenuItem
            // 
            this.döşemeToolStripMenuItem.Name = "döşemeToolStripMenuItem";
            this.döşemeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.döşemeToolStripMenuItem.Text = "Döşeme";
            this.döşemeToolStripMenuItem.Click += new System.EventHandler(this.döşemeToolStripMenuItem_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "kiraz");
            this.ımageList2.Images.SetKeyName(1, "cilek");
            this.ımageList2.Images.SetKeyName(2, "elma");
            this.ımageList2.Images.SetKeyName(3, "ekmek");
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kiraz");
            this.ımageList1.Images.SetKeyName(1, "cilek");
            this.ımageList1.Images.SetKeyName(2, "elma");
            this.ımageList1.Images.SetKeyName(3, "ekmek");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listUrunler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(557, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 665);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listSepet);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 665);
            this.panel2.TabIndex = 2;
            // 
            // listSepet
            // 
            this.listSepet.BackColor = System.Drawing.SystemColors.Control;
            this.listSepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSepet.FullRowSelect = true;
            this.listSepet.LargeImageList = this.ımageList2;
            this.listSepet.Location = new System.Drawing.Point(0, 74);
            this.listSepet.Name = "listSepet";
            this.listSepet.Size = new System.Drawing.Size(557, 531);
            this.listSepet.SmallImageList = this.ımageList1;
            this.listSepet.TabIndex = 2;
            this.listSepet.UseCompatibleStateImageBehavior = false;
            this.listSepet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Adı";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ürün Fiyatı";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Miktar";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tutar";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 120;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSepetiTemizle);
            this.panel4.Controls.Add(this.btnSepettenCikar);
            this.panel4.Controls.Add(this.btnMiktarAzalt);
            this.panel4.Controls.Add(this.btnMiktarArttir);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 605);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 60);
            this.panel4.TabIndex = 1;
            // 
            // btnSepetiTemizle
            // 
            this.btnSepetiTemizle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSepetiTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnSepetiTemizle.Image")));
            this.btnSepetiTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSepetiTemizle.Location = new System.Drawing.Point(407, 7);
            this.btnSepetiTemizle.Name = "btnSepetiTemizle";
            this.btnSepetiTemizle.Size = new System.Drawing.Size(139, 45);
            this.btnSepetiTemizle.TabIndex = 0;
            this.btnSepetiTemizle.Text = "Sepeti Boşalt";
            this.btnSepetiTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSepetiTemizle.UseVisualStyleBackColor = true;
            this.btnSepetiTemizle.Click += new System.EventHandler(this.btnSepetiTemizle_Click);
            // 
            // btnSepettenCikar
            // 
            this.btnSepettenCikar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSepettenCikar.Image = ((System.Drawing.Image)(resources.GetObject("btnSepettenCikar.Image")));
            this.btnSepettenCikar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSepettenCikar.Location = new System.Drawing.Point(250, 7);
            this.btnSepettenCikar.Name = "btnSepettenCikar";
            this.btnSepettenCikar.Size = new System.Drawing.Size(150, 45);
            this.btnSepettenCikar.TabIndex = 0;
            this.btnSepettenCikar.Text = "Sepetten Çıkar";
            this.btnSepettenCikar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSepettenCikar.UseVisualStyleBackColor = true;
            this.btnSepettenCikar.Click += new System.EventHandler(this.btnSepettenCikar_Click);
            // 
            // btnMiktarAzalt
            // 
            this.btnMiktarAzalt.Image = ((System.Drawing.Image)(resources.GetObject("btnMiktarAzalt.Image")));
            this.btnMiktarAzalt.Location = new System.Drawing.Point(64, 7);
            this.btnMiktarAzalt.Name = "btnMiktarAzalt";
            this.btnMiktarAzalt.Size = new System.Drawing.Size(49, 45);
            this.btnMiktarAzalt.TabIndex = 0;
            this.btnMiktarAzalt.UseVisualStyleBackColor = true;
            this.btnMiktarAzalt.Click += new System.EventHandler(this.btnMiktarAzalt_Click);
            // 
            // btnMiktarArttir
            // 
            this.btnMiktarArttir.Image = ((System.Drawing.Image)(resources.GetObject("btnMiktarArttir.Image")));
            this.btnMiktarArttir.Location = new System.Drawing.Point(9, 7);
            this.btnMiktarArttir.Name = "btnMiktarArttir";
            this.btnMiktarArttir.Size = new System.Drawing.Size(49, 45);
            this.btnMiktarArttir.TabIndex = 0;
            this.btnMiktarArttir.UseVisualStyleBackColor = true;
            this.btnMiktarArttir.Click += new System.EventHandler(this.btnMiktarArttir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.lblSepetToplami);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 74);
            this.panel3.TabIndex = 0;
            // 
            // lblSepetToplami
            // 
            this.lblSepetToplami.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSepetToplami.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSepetToplami.Location = new System.Drawing.Point(293, 0);
            this.lblSepetToplami.Name = "lblSepetToplami";
            this.lblSepetToplami.Size = new System.Drawing.Size(264, 74);
            this.lblSepetToplami.TabIndex = 1;
            this.lblSepetToplami.Text = "0,00 ₺";
            this.lblSepetToplami.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEPET TOPLAMI :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Kasa Uygylaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listUrunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem büyükSimgeToolStripMenuItem;
        private ToolStripMenuItem küçükSimgeToolStripMenuItem;
        private ToolStripMenuItem detaylıGörünümToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem döşemeToolStripMenuItem;
        private ImageList ımageList2;
        private ImageList ımageList1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button btnMiktarAzalt;
        private Button btnMiktarArttir;
        private Panel panel3;
        private Label lblSepetToplami;
        private Label label1;
        private Button btnSepetiTemizle;
        private Button btnSepettenCikar;
        private ListView listSepet;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}