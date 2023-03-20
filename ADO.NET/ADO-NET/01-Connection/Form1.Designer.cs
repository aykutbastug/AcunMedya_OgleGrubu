namespace _01_Connection
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCategoryId = new TextBox();
            label2 = new Label();
            txtCategoryName = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 21);
            button1.Name = "button1";
            button1.Size = new Size(263, 73);
            button1.TabIndex = 0;
            button1.Text = "Kategorileri Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(30, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(755, 842);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "CategoryId";
            Column1.HeaderText = "Kategori No";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 175;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "CategoryName";
            Column2.HeaderText = "Kategori Adı";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 175;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Description";
            Column3.HeaderText = "Açıklama";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 175;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(920, 109);
            label1.Name = "label1";
            label1.Size = new Size(179, 35);
            label1.TabIndex = 2;
            label1.Text = "Kategori No :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryId.Location = new Point(1105, 99);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(115, 45);
            txtCategoryId.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(884, 160);
            label2.Name = "label2";
            label2.Size = new Size(215, 35);
            label2.TabIndex = 2;
            label2.Text = "Kategori Adı :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.Location = new Point(1105, 150);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(435, 45);
            txtCategoryName.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(884, 211);
            label3.Name = "label3";
            label3.Size = new Size(215, 35);
            label3.TabIndex = 2;
            label3.Text = "Açıklama :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(1105, 201);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(435, 45);
            txtDescription.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(1377, 287);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(163, 64);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(1208, 287);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(163, 64);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Location = new Point(1039, 287);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(163, 64);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 21);
            button2.Name = "button2";
            button2.Size = new Size(263, 73);
            button2.TabIndex = 0;
            button2.Text = "Kategorileri Getir Yeni";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1815, 984);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(txtCategoryId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label1;
        private TextBox txtCategoryId;
        private Label label2;
        private TextBox txtCategoryName;
        private Label label3;
        private TextBox txtDescription;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button button2;
    }
}