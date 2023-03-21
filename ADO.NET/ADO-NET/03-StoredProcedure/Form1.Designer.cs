namespace _03_StoredProcedure
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnGuncelle = new Button();
            btnYeniMusteriEkle = new Button();
            btnBul = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1755, 990);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += btnGuncelle_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(btnYeniMusteriEkle);
            panel1.Controls.Add(btnBul);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1755, 136);
            panel1.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(1310, 36);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(198, 66);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Müşteri Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnYeniMusteriEkle
            // 
            btnYeniMusteriEkle.Location = new Point(1525, 36);
            btnYeniMusteriEkle.Name = "btnYeniMusteriEkle";
            btnYeniMusteriEkle.Size = new Size(198, 66);
            btnYeniMusteriEkle.TabIndex = 3;
            btnYeniMusteriEkle.Text = "Yeni Müşteri Ekle";
            btnYeniMusteriEkle.UseVisualStyleBackColor = true;
            btnYeniMusteriEkle.Click += btnYeniMusteriEkle_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(602, 58);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(131, 40);
            btnBul.TabIndex = 2;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(449, 35);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Bul :";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1093, 36);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(198, 66);
            btnSil.TabIndex = 3;
            btnSil.Text = "Müşteri Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1755, 1126);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnBul;
        private TextBox textBox1;
        private Label label1;
        private Button btnYeniMusteriEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}