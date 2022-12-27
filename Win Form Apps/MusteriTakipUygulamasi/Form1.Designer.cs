namespace MusteriTakipUygulamasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextListe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.müşteriyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriyiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniMüşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listeyiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.örnekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEkle = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.fdgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfgsdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dgfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bilgileriKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKayitTarihi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.contextListe.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 947);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(572, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 44);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextListe;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(0, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(638, 895);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextListe
            // 
            this.contextListe.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextListe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriyiSilToolStripMenuItem,
            this.müşteriyiGüncelleToolStripMenuItem,
            this.toolStripSeparator1,
            this.yeniMüşteriEkleToolStripMenuItem,
            this.toolStripSeparator2,
            this.listeyiYenileToolStripMenuItem,
            this.örnekToolStripMenuItem});
            this.contextListe.Name = "contextListe";
            this.contextListe.Size = new System.Drawing.Size(340, 196);
            // 
            // müşteriyiSilToolStripMenuItem
            // 
            this.müşteriyiSilToolStripMenuItem.Name = "müşteriyiSilToolStripMenuItem";
            this.müşteriyiSilToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.müşteriyiSilToolStripMenuItem.Text = "Müşteriyi Sil";
            this.müşteriyiSilToolStripMenuItem.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // müşteriyiGüncelleToolStripMenuItem
            // 
            this.müşteriyiGüncelleToolStripMenuItem.Name = "müşteriyiGüncelleToolStripMenuItem";
            this.müşteriyiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.müşteriyiGüncelleToolStripMenuItem.Text = "Müşteriyi Güncelle";
            this.müşteriyiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(336, 6);
            // 
            // yeniMüşteriEkleToolStripMenuItem
            // 
            this.yeniMüşteriEkleToolStripMenuItem.Name = "yeniMüşteriEkleToolStripMenuItem";
            this.yeniMüşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.yeniMüşteriEkleToolStripMenuItem.Text = "Yeni Müşteri Ekle";
            this.yeniMüşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(336, 6);
            // 
            // listeyiYenileToolStripMenuItem
            // 
            this.listeyiYenileToolStripMenuItem.Name = "listeyiYenileToolStripMenuItem";
            this.listeyiYenileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F5)));
            this.listeyiYenileToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.listeyiYenileToolStripMenuItem.Text = "Listeyi Yenile";
            this.listeyiYenileToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // örnekToolStripMenuItem
            // 
            this.örnekToolStripMenuItem.Name = "örnekToolStripMenuItem";
            this.örnekToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.örnekToolStripMenuItem.Text = "örnek";
            this.örnekToolStripMenuItem.Click += new System.EventHandler(this.örnekToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ LİSTESİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEkle,
            this.btnSil,
            this.btnGuncelle,
            this.toolStripSplitButton1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(638, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(919, 58);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(222, 52);
            this.btnEkle.Text = "Yeni Müşteri Ekle";
            this.btnEkle.ToolTipText = "Yeni Müşteri Ekle\r\n\r\nYeni müşteri kaydı eklemek için bu butonu kullanabilirsiniz." +
    "";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(162, 52);
            this.btnSil.Text = "Müşteri Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(221, 52);
            this.btnGuncelle.Text = "Müşteri Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdgdfgToolStripMenuItem,
            this.sdfgsdfgToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(52, 52);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // fdgdfgToolStripMenuItem
            // 
            this.fdgdfgToolStripMenuItem.Name = "fdgdfgToolStripMenuItem";
            this.fdgdfgToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.fdgdfgToolStripMenuItem.Text = "Form 2";
            this.fdgdfgToolStripMenuItem.Click += new System.EventHandler(this.fdgdfgToolStripMenuItem_Click);
            // 
            // sdfgsdfgToolStripMenuItem
            // 
            this.sdfgsdfgToolStripMenuItem.Name = "sdfgsdfgToolStripMenuItem";
            this.sdfgsdfgToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.sdfgsdfgToolStripMenuItem.Text = "Form 3";
            this.sdfgsdfgToolStripMenuItem.Click += new System.EventHandler(this.sdfgsdfgToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dgfToolStripMenuItem,
            this.dfgToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 52);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // dgfToolStripMenuItem
            // 
            this.dgfToolStripMenuItem.Name = "dgfToolStripMenuItem";
            this.dgfToolStripMenuItem.Size = new System.Drawing.Size(162, 40);
            this.dgfToolStripMenuItem.Text = "dgf";
            // 
            // dfgToolStripMenuItem
            // 
            this.dfgToolStripMenuItem.Name = "dfgToolStripMenuItem";
            this.dfgToolStripMenuItem.Size = new System.Drawing.Size(162, 40);
            this.dfgToolStripMenuItem.Text = "dfg";
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(638, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 889);
            this.tabControl1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgileriKaydetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 40);
            // 
            // bilgileriKaydetToolStripMenuItem
            // 
            this.bilgileriKaydetToolStripMenuItem.Name = "bilgileriKaydetToolStripMenuItem";
            this.bilgileriKaydetToolStripMenuItem.Size = new System.Drawing.Size(222, 36);
            this.bilgileriKaydetToolStripMenuItem.Text = "Bilgileri Kaydet";
            this.bilgileriKaydetToolStripMenuItem.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtTelefon);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSoyadi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtKayitTarihi);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtAdi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ImageKey = "musteri_bilgileri";
            this.tabPage1.Location = new System.Drawing.Point(4, 55);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 830);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdres.Location = new System.Drawing.Point(314, 357);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(578, 223);
            this.txtAdres.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(23, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(314, 303);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(578, 48);
            this.txtEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(23, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefon.Location = new System.Drawing.Point(314, 249);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(578, 48);
            this.txtTelefon.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(23, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoyadi.Location = new System.Drawing.Point(314, 195);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(578, 48);
            this.txtSoyadi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(23, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKayitTarihi.Location = new System.Drawing.Point(314, 89);
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.ReadOnly = true;
            this.txtKayitTarihi.Size = new System.Drawing.Size(578, 48);
            this.txtKayitTarihi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(23, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kayıt Tarihi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(314, 35);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(578, 48);
            this.txtId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(23, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Müşteri No :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdi
            // 
            this.txtAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdi.Location = new System.Drawing.Point(314, 141);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(578, 48);
            this.txtAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(23, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtVergiNo);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtVergiDairesi);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtUnvan);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.ImageKey = "fatura_bilgileri";
            this.tabPage2.Location = new System.Drawing.Point(4, 55);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 830);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fatura Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVergiNo.Location = new System.Drawing.Point(305, 137);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(578, 48);
            this.txtVergiNo.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(14, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 46);
            this.label9.TabIndex = 3;
            this.label9.Text = "Vergi No :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVergiDairesi.Location = new System.Drawing.Point(305, 83);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(578, 48);
            this.txtVergiDairesi.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(14, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 46);
            this.label10.TabIndex = 4;
            this.label10.Text = "Vergi Dairesi :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnvan.Location = new System.Drawing.Point(305, 29);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(578, 48);
            this.txtUnvan.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(14, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(285, 46);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ünvan :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "fatura_bilgileri");
            this.ımageList1.Images.SetKeyName(1, "musteri_bilgileri");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 947);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.contextListe.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnEkle;
        private ToolStripButton btnSil;
        private ToolStripButton btnGuncelle;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem fdgdfgToolStripMenuItem;
        private ToolStripMenuItem sdfgsdfgToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem dgfToolStripMenuItem;
        private ToolStripMenuItem dfgToolStripMenuItem;
        private ImageList ımageList1;
        private TextBox txtAdi;
        private Label label2;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtTelefon;
        private Label label4;
        private TextBox txtSoyadi;
        private Label label3;
        private TextBox txtAdres;
        private Label label6;
        private TextBox txtId;
        private Label label7;
        private TextBox txtVergiNo;
        private Label label9;
        private TextBox txtVergiDairesi;
        private Label label10;
        private TextBox txtUnvan;
        private Label label11;
        private TextBox txtKayitTarihi;
        private Label label8;
        public ListBox listBox1;
        private Button button1;
        private ContextMenuStrip contextListe;
        private ToolStripMenuItem müşteriyiSilToolStripMenuItem;
        private ToolStripMenuItem müşteriyiGüncelleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem yeniMüşteriEkleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem listeyiYenileToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem bilgileriKaydetToolStripMenuItem;
        private ToolStripMenuItem örnekToolStripMenuItem;
    }
}