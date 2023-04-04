namespace _08_Group_Join
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
            btnYasaGoreGrupla = new Button();
            dataGridView1 = new DataGridView();
            btnPersonelDepartman = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnYasaGoreGrupla
            // 
            btnYasaGoreGrupla.Location = new Point(27, 50);
            btnYasaGoreGrupla.Name = "btnYasaGoreGrupla";
            btnYasaGoreGrupla.Size = new Size(450, 65);
            btnYasaGoreGrupla.TabIndex = 0;
            btnYasaGoreGrupla.Text = "Yaşa Göre Gruplama";
            btnYasaGoreGrupla.UseVisualStyleBackColor = true;
            btnYasaGoreGrupla.Click += btnYasaGoreGrupla_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(582, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(776, 864);
            dataGridView1.TabIndex = 1;
            // 
            // btnPersonelDepartman
            // 
            btnPersonelDepartman.Location = new Point(27, 133);
            btnPersonelDepartman.Name = "btnPersonelDepartman";
            btnPersonelDepartman.Size = new Size(450, 65);
            btnPersonelDepartman.TabIndex = 0;
            btnPersonelDepartman.Text = "Personel Departman Bilgileri";
            btnPersonelDepartman.UseVisualStyleBackColor = true;
            btnPersonelDepartman.Click += btnPersonelDepartman_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 933);
            Controls.Add(dataGridView1);
            Controls.Add(btnPersonelDepartman);
            Controls.Add(btnYasaGoreGrupla);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnYasaGoreGrupla;
        private DataGridView dataGridView1;
        private Button btnPersonelDepartman;
    }
}