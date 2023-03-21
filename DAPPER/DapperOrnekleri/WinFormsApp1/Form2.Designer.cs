namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            txtMusteriNo = new TextBox();
            label2 = new Label();
            txtMusteriAdi = new TextBox();
            label3 = new Label();
            txtTelefon = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(448, 271);
            button1.Name = "button1";
            button1.Size = new Size(151, 58);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(51, 65);
            label1.Name = "label1";
            label1.Size = new Size(182, 35);
            label1.TabIndex = 1;
            label1.Text = "Müşteri No :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriNo
            // 
            txtMusteriNo.Location = new Point(249, 65);
            txtMusteriNo.Name = "txtMusteriNo";
            txtMusteriNo.Size = new Size(350, 35);
            txtMusteriNo.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(51, 106);
            label2.Name = "label2";
            label2.Size = new Size(182, 35);
            label2.TabIndex = 1;
            label2.Text = "Müşteri Adı :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(249, 106);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(350, 35);
            txtMusteriAdi.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(51, 147);
            label3.Name = "label3";
            label3.Size = new Size(182, 35);
            label3.TabIndex = 1;
            label3.Text = "Telefon :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(249, 147);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(350, 35);
            txtTelefon.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 363);
            Controls.Add(txtTelefon);
            Controls.Add(label3);
            Controls.Add(txtMusteriAdi);
            Controls.Add(label2);
            Controls.Add(txtMusteriNo);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtMusteriNo;
        private Label label2;
        private TextBox txtMusteriAdi;
        private Label label3;
        private TextBox txtTelefon;
    }
}