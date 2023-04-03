namespace _07_Sum_Avg_Min_Max_Count
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
            btnKacTanePersonelVar = new Button();
            btnYasi25denBuyukKacPersonelVar = new Button();
            btnEnYasliPersonelinYasiKac = new Button();
            btnEnKucukPersonelinYasiKac = new Button();
            btnTumPersonelYaslariToplami = new Button();
            btnYaslarinOrtalamasi = new Button();
            SuspendLayout();
            // 
            // btnKacTanePersonelVar
            // 
            btnKacTanePersonelVar.Location = new Point(23, 23);
            btnKacTanePersonelVar.Name = "btnKacTanePersonelVar";
            btnKacTanePersonelVar.Size = new Size(619, 65);
            btnKacTanePersonelVar.TabIndex = 0;
            btnKacTanePersonelVar.Text = "Kaç Tane Personel Var";
            btnKacTanePersonelVar.UseVisualStyleBackColor = true;
            btnKacTanePersonelVar.Click += btnKacTanePersonelVar_Click;
            // 
            // btnYasi25denBuyukKacPersonelVar
            // 
            btnYasi25denBuyukKacPersonelVar.Location = new Point(23, 94);
            btnYasi25denBuyukKacPersonelVar.Name = "btnYasi25denBuyukKacPersonelVar";
            btnYasi25denBuyukKacPersonelVar.Size = new Size(619, 65);
            btnYasi25denBuyukKacPersonelVar.TabIndex = 0;
            btnYasi25denBuyukKacPersonelVar.Text = "Yaşı 25 den Büyük Kaç Tane Personel Var";
            btnYasi25denBuyukKacPersonelVar.UseVisualStyleBackColor = true;
            btnYasi25denBuyukKacPersonelVar.Click += btnYasi25denBuyukKacPersonelVar_Click;
            // 
            // btnEnYasliPersonelinYasiKac
            // 
            btnEnYasliPersonelinYasiKac.Location = new Point(23, 165);
            btnEnYasliPersonelinYasiKac.Name = "btnEnYasliPersonelinYasiKac";
            btnEnYasliPersonelinYasiKac.Size = new Size(619, 65);
            btnEnYasliPersonelinYasiKac.TabIndex = 0;
            btnEnYasliPersonelinYasiKac.Text = "En Yaşlı Personelin Yaşı Kaç";
            btnEnYasliPersonelinYasiKac.UseVisualStyleBackColor = true;
            btnEnYasliPersonelinYasiKac.Click += btnEnYasliPersonelinYasiKac_Click;
            // 
            // btnEnKucukPersonelinYasiKac
            // 
            btnEnKucukPersonelinYasiKac.Location = new Point(23, 236);
            btnEnKucukPersonelinYasiKac.Name = "btnEnKucukPersonelinYasiKac";
            btnEnKucukPersonelinYasiKac.Size = new Size(619, 65);
            btnEnKucukPersonelinYasiKac.TabIndex = 0;
            btnEnKucukPersonelinYasiKac.Text = "En Küçük Personelin Yaşı Kaç";
            btnEnKucukPersonelinYasiKac.UseVisualStyleBackColor = true;
            btnEnKucukPersonelinYasiKac.Click += btnEnKucukPersonelinYasiKac_Click;
            // 
            // btnTumPersonelYaslariToplami
            // 
            btnTumPersonelYaslariToplami.Location = new Point(23, 307);
            btnTumPersonelYaslariToplami.Name = "btnTumPersonelYaslariToplami";
            btnTumPersonelYaslariToplami.Size = new Size(619, 65);
            btnTumPersonelYaslariToplami.TabIndex = 0;
            btnTumPersonelYaslariToplami.Text = "Tüm Personellerin Yaşları Toplamı Kaç";
            btnTumPersonelYaslariToplami.UseVisualStyleBackColor = true;
            btnTumPersonelYaslariToplami.Click += btnTumPersonelYaslariToplami_Click;
            // 
            // btnYaslarinOrtalamasi
            // 
            btnYaslarinOrtalamasi.Location = new Point(23, 378);
            btnYaslarinOrtalamasi.Name = "btnYaslarinOrtalamasi";
            btnYaslarinOrtalamasi.Size = new Size(619, 65);
            btnYaslarinOrtalamasi.TabIndex = 0;
            btnYaslarinOrtalamasi.Text = "Tüm Personellerin Yaşlarının Ortalaması Kaç";
            btnYaslarinOrtalamasi.UseVisualStyleBackColor = true;
            btnYaslarinOrtalamasi.Click += btnYaslarinOrtalamasi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 570);
            Controls.Add(btnYaslarinOrtalamasi);
            Controls.Add(btnTumPersonelYaslariToplami);
            Controls.Add(btnEnKucukPersonelinYasiKac);
            Controls.Add(btnEnYasliPersonelinYasiKac);
            Controls.Add(btnYasi25denBuyukKacPersonelVar);
            Controls.Add(btnKacTanePersonelVar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnKacTanePersonelVar;
        private Button btnYasi25denBuyukKacPersonelVar;
        private Button btnEnYasliPersonelinYasiKac;
        private Button btnEnKucukPersonelinYasiKac;
        private Button btnTumPersonelYaslariToplami;
        private Button btnYaslarinOrtalamasi;
    }
}