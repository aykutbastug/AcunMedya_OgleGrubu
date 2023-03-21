namespace _03_StoredProcedure
{
    partial class Form2
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
            label1 = new Label();
            txtMusteriNo = new TextBox();
            label2 = new Label();
            txtMusteriAdi = new TextBox();
            label3 = new Label();
            txtTelefon = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(70, 71);
            label1.Name = "label1";
            label1.Size = new Size(209, 40);
            label1.TabIndex = 0;
            label1.Text = "Müşteri No :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriNo
            // 
            txtMusteriNo.Location = new Point(295, 76);
            txtMusteriNo.Name = "txtMusteriNo";
            txtMusteriNo.Size = new Size(268, 35);
            txtMusteriNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(70, 112);
            label2.Name = "label2";
            label2.Size = new Size(209, 40);
            label2.TabIndex = 0;
            label2.Text = "Müşteri Adı :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(295, 117);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(268, 35);
            txtMusteriAdi.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(70, 153);
            label3.Name = "label3";
            label3.Size = new Size(209, 40);
            label3.TabIndex = 0;
            label3.Text = "Telefon :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(295, 158);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(268, 35);
            txtTelefon.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(409, 256);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(154, 54);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 405);
            Controls.Add(btnKaydet);
            Controls.Add(txtTelefon);
            Controls.Add(label3);
            Controls.Add(txtMusteriAdi);
            Controls.Add(label2);
            Controls.Add(txtMusteriNo);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMusteriNo;
        private Label label2;
        private TextBox txtMusteriAdi;
        private Label label3;
        private TextBox txtTelefon;
        private Button btnKaydet;
    }
}