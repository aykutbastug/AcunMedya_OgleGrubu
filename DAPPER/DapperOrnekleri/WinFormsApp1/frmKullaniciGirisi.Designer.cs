namespace WinFormsApp1
{
    partial class frmKullaniciGirisi
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
            txtEmail = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 71);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Email ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(183, 71);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 35);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 112);
            label2.Name = "label2";
            label2.Size = new Size(54, 30);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(183, 112);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(420, 35);
            txtSifre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(421, 172);
            button1.Name = "button1";
            button1.Size = new Size(182, 51);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmKullaniciGirisi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 280);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "frmKullaniciGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSifre;
        private Button button1;
    }
}