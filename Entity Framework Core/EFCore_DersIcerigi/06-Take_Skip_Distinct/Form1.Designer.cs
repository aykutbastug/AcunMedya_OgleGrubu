namespace _06_Take_Skip_Distinct
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
            btnTumunuGetir = new Button();
            btnIlk2KaydiGetir = new Button();
            btnIlk2KaydiAtlaSonraki2KaydiGetir = new Button();
            btnPersonelIsimleriniTekilOlarakGetir = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTumunuGetir
            // 
            btnTumunuGetir.Location = new Point(45, 21);
            btnTumunuGetir.Name = "btnTumunuGetir";
            btnTumunuGetir.Size = new Size(388, 59);
            btnTumunuGetir.TabIndex = 0;
            btnTumunuGetir.Text = "Tümünü Getir";
            btnTumunuGetir.UseVisualStyleBackColor = true;
            btnTumunuGetir.Click += btnTumunuGetir_Click;
            // 
            // btnIlk2KaydiGetir
            // 
            btnIlk2KaydiGetir.Location = new Point(45, 86);
            btnIlk2KaydiGetir.Name = "btnIlk2KaydiGetir";
            btnIlk2KaydiGetir.Size = new Size(388, 59);
            btnIlk2KaydiGetir.TabIndex = 0;
            btnIlk2KaydiGetir.Text = "İlk 2 Kaydı Getir";
            btnIlk2KaydiGetir.UseVisualStyleBackColor = true;
            btnIlk2KaydiGetir.Click += btnIlk2KaydiGetir_Click;
            // 
            // btnIlk2KaydiAtlaSonraki2KaydiGetir
            // 
            btnIlk2KaydiAtlaSonraki2KaydiGetir.Location = new Point(45, 151);
            btnIlk2KaydiAtlaSonraki2KaydiGetir.Name = "btnIlk2KaydiAtlaSonraki2KaydiGetir";
            btnIlk2KaydiAtlaSonraki2KaydiGetir.Size = new Size(388, 59);
            btnIlk2KaydiAtlaSonraki2KaydiGetir.TabIndex = 0;
            btnIlk2KaydiAtlaSonraki2KaydiGetir.Text = "İlk 2 Kaydı Atla Sonraki 2 Kaydı Getir";
            btnIlk2KaydiAtlaSonraki2KaydiGetir.UseVisualStyleBackColor = true;
            btnIlk2KaydiAtlaSonraki2KaydiGetir.Click += btnIlk2KaydiAtlaSonraki2KaydiGetir_Click;
            // 
            // btnPersonelIsimleriniTekilOlarakGetir
            // 
            btnPersonelIsimleriniTekilOlarakGetir.Location = new Point(45, 216);
            btnPersonelIsimleriniTekilOlarakGetir.Name = "btnPersonelIsimleriniTekilOlarakGetir";
            btnPersonelIsimleriniTekilOlarakGetir.Size = new Size(388, 59);
            btnPersonelIsimleriniTekilOlarakGetir.TabIndex = 0;
            btnPersonelIsimleriniTekilOlarakGetir.Text = "Personel İsimlerini Tekil olarak Getir.";
            btnPersonelIsimleriniTekilOlarakGetir.UseVisualStyleBackColor = true;
            btnPersonelIsimleriniTekilOlarakGetir.Click += btnPersonelIsimleriniTekilOlarakGetir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(462, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(965, 580);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 613);
            Controls.Add(dataGridView1);
            Controls.Add(btnPersonelIsimleriniTekilOlarakGetir);
            Controls.Add(btnIlk2KaydiAtlaSonraki2KaydiGetir);
            Controls.Add(btnIlk2KaydiGetir);
            Controls.Add(btnTumunuGetir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTumunuGetir;
        private Button btnIlk2KaydiGetir;
        private Button btnIlk2KaydiAtlaSonraki2KaydiGetir;
        private Button btnPersonelIsimleriniTekilOlarakGetir;
        private DataGridView dataGridView1;
    }
}