namespace _03_StoredProcedure
{
    partial class Form3
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
            btnKaydet = new Button();
            txtTelefon = new TextBox();
            label3 = new Label();
            txtMusteriAdi = new TextBox();
            label2 = new Label();
            txtMusteriNo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(374, 224);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(154, 54);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(260, 126);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(268, 35);
            txtTelefon.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(35, 121);
            label3.Name = "label3";
            label3.Size = new Size(209, 40);
            label3.TabIndex = 3;
            label3.Text = "Telefon :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(260, 85);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(268, 35);
            txtMusteriAdi.TabIndex = 7;
            // 
            // label2
            // 
            label2.Location = new Point(35, 80);
            label2.Name = "label2";
            label2.Size = new Size(209, 40);
            label2.TabIndex = 4;
            label2.Text = "Müşteri Adı :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriNo
            // 
            txtMusteriNo.Location = new Point(260, 44);
            txtMusteriNo.Name = "txtMusteriNo";
            txtMusteriNo.ReadOnly = true;
            txtMusteriNo.Size = new Size(268, 35);
            txtMusteriNo.TabIndex = 8;
            // 
            // label1
            // 
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(209, 40);
            label1.TabIndex = 5;
            label1.Text = "Müşteri No :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 347);
            Controls.Add(btnKaydet);
            Controls.Add(txtTelefon);
            Controls.Add(label3);
            Controls.Add(txtMusteriAdi);
            Controls.Add(label2);
            Controls.Add(txtMusteriNo);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtTelefon;
        public TextBox txtMusteriAdi;
        public TextBox txtMusteriNo;
    }
}