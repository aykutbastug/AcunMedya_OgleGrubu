namespace WinFormsApp1
{
    partial class frmPersoneller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtPersonelId = new TextBox();
            label2 = new Label();
            txtAdi = new TextBox();
            label3 = new Label();
            txtSoyadi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtSifre = new TextBox();
            label7 = new Label();
            txtTelefon = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            btnKaydet = new Button();
            btnSil = new Button();
            btnYeniKayit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(666, 813);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.Location = new Point(770, 47);
            label1.Name = "label1";
            label1.Size = new Size(246, 36);
            label1.TabIndex = 1;
            label1.Text = "No :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPersonelId
            // 
            txtPersonelId.Location = new Point(1022, 47);
            txtPersonelId.Name = "txtPersonelId";
            txtPersonelId.ReadOnly = true;
            txtPersonelId.Size = new Size(338, 35);
            txtPersonelId.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(770, 88);
            label2.Name = "label2";
            label2.Size = new Size(246, 36);
            label2.TabIndex = 1;
            label2.Text = "Adı :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(1022, 88);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(338, 35);
            txtAdi.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(770, 129);
            label3.Name = "label3";
            label3.Size = new Size(246, 36);
            label3.TabIndex = 1;
            label3.Text = "Soyadı :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(1022, 129);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(338, 35);
            txtSoyadi.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(770, 170);
            label4.Name = "label4";
            label4.Size = new Size(246, 36);
            label4.TabIndex = 1;
            label4.Text = "Doğum Tarihi :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(770, 211);
            label5.Name = "label5";
            label5.Size = new Size(246, 36);
            label5.TabIndex = 1;
            label5.Text = "Email :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1022, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 35);
            txtEmail.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1022, 170);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(338, 35);
            dateTimePicker1.TabIndex = 3;
            // 
            // label6
            // 
            label6.Location = new Point(770, 252);
            label6.Name = "label6";
            label6.Size = new Size(246, 36);
            label6.TabIndex = 1;
            label6.Text = "Şifre :";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(1022, 252);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(338, 35);
            txtSifre.TabIndex = 2;
            // 
            // label7
            // 
            label7.Location = new Point(770, 293);
            label7.Name = "label7";
            label7.Size = new Size(246, 36);
            label7.TabIndex = 1;
            label7.Text = "Telefon :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(1022, 293);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(338, 35);
            txtTelefon.TabIndex = 2;
            // 
            // label8
            // 
            label8.Location = new Point(770, 334);
            label8.Name = "label8";
            label8.Size = new Size(246, 36);
            label8.TabIndex = 1;
            label8.Text = "Görevi :";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Personel", "Yönetici" });
            comboBox1.Location = new Point(1022, 332);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(338, 38);
            comboBox1.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(1195, 405);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(168, 65);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1022, 405);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(168, 65);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYeniKayit
            // 
            btnYeniKayit.Location = new Point(752, 405);
            btnYeniKayit.Name = "btnYeniKayit";
            btnYeniKayit.Size = new Size(168, 65);
            btnYeniKayit.TabIndex = 5;
            btnYeniKayit.Text = "YENİ KAYIT";
            btnYeniKayit.UseVisualStyleBackColor = true;
            btnYeniKayit.Click += btnYeniKayit_Click;
            // 
            // frmPersoneller
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 837);
            Controls.Add(btnYeniKayit);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(txtTelefon);
            Controls.Add(label7);
            Controls.Add(txtSifre);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSoyadi);
            Controls.Add(label3);
            Controls.Add(txtAdi);
            Controls.Add(label2);
            Controls.Add(txtPersonelId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmPersoneller";
            Text = "frmPersoneller";
            Load += frmPersoneller_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtPersonelId;
        private Label label2;
        private TextBox txtAdi;
        private Label label3;
        private TextBox txtSoyadi;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txtSifre;
        private Label label7;
        private TextBox txtTelefon;
        private Label label8;
        private ComboBox comboBox1;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnYeniKayit;
    }
}