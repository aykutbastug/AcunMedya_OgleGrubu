namespace _02_LinqSorgulama
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
            btnTumunuListele = new Button();
            listBox1 = new ListBox();
            btnAltidanFazlaOlanlar = new Button();
            btnAdanZyeSirala = new Button();
            btnZdenAyaSirala = new Button();
            btnAileBaslayanlar = new Button();
            btnYaIleBitenler = new Button();
            SuspendLayout();
            // 
            // btnTumunuListele
            // 
            btnTumunuListele.Location = new Point(31, 33);
            btnTumunuListele.Margin = new Padding(4, 4, 4, 4);
            btnTumunuListele.Name = "btnTumunuListele";
            btnTumunuListele.Size = new Size(626, 51);
            btnTumunuListele.TabIndex = 0;
            btnTumunuListele.Text = "Tümünü Listele";
            btnTumunuListele.UseVisualStyleBackColor = true;
            btnTumunuListele.Click += btnTumunuListele_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(750, 33);
            listBox1.Margin = new Padding(4, 4, 4, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(492, 878);
            listBox1.TabIndex = 1;
            // 
            // btnAltidanFazlaOlanlar
            // 
            btnAltidanFazlaOlanlar.Location = new Point(31, 91);
            btnAltidanFazlaOlanlar.Margin = new Padding(4, 4, 4, 4);
            btnAltidanFazlaOlanlar.Name = "btnAltidanFazlaOlanlar";
            btnAltidanFazlaOlanlar.Size = new Size(626, 51);
            btnAltidanFazlaOlanlar.TabIndex = 0;
            btnAltidanFazlaOlanlar.Text = "6 Karakterden Fazla Olanlar";
            btnAltidanFazlaOlanlar.UseVisualStyleBackColor = true;
            btnAltidanFazlaOlanlar.Click += btnAltidanFazlaOlanlar_Click;
            // 
            // btnAdanZyeSirala
            // 
            btnAdanZyeSirala.Location = new Point(31, 149);
            btnAdanZyeSirala.Margin = new Padding(4, 4, 4, 4);
            btnAdanZyeSirala.Name = "btnAdanZyeSirala";
            btnAdanZyeSirala.Size = new Size(626, 51);
            btnAdanZyeSirala.TabIndex = 0;
            btnAdanZyeSirala.Text = "A'dan Z'ye Sırala";
            btnAdanZyeSirala.UseVisualStyleBackColor = true;
            btnAdanZyeSirala.Click += btnAdanZyeSirala_Click;
            // 
            // btnZdenAyaSirala
            // 
            btnZdenAyaSirala.Location = new Point(31, 208);
            btnZdenAyaSirala.Margin = new Padding(4, 4, 4, 4);
            btnZdenAyaSirala.Name = "btnZdenAyaSirala";
            btnZdenAyaSirala.Size = new Size(626, 51);
            btnZdenAyaSirala.TabIndex = 0;
            btnZdenAyaSirala.Text = "Z'den A'ya Sırala";
            btnZdenAyaSirala.UseVisualStyleBackColor = true;
            btnZdenAyaSirala.Click += btnZdenAyaSirala_Click;
            // 
            // btnAileBaslayanlar
            // 
            btnAileBaslayanlar.Location = new Point(31, 267);
            btnAileBaslayanlar.Margin = new Padding(4);
            btnAileBaslayanlar.Name = "btnAileBaslayanlar";
            btnAileBaslayanlar.Size = new Size(626, 51);
            btnAileBaslayanlar.TabIndex = 0;
            btnAileBaslayanlar.Text = "'A' ile başlayanlar";
            btnAileBaslayanlar.UseVisualStyleBackColor = true;
            btnAileBaslayanlar.Click += btnAileBaslayanlar_Click;
            // 
            // btnYaIleBitenler
            // 
            btnYaIleBitenler.Location = new Point(31, 326);
            btnYaIleBitenler.Margin = new Padding(4);
            btnYaIleBitenler.Name = "btnYaIleBitenler";
            btnYaIleBitenler.Size = new Size(626, 51);
            btnYaIleBitenler.TabIndex = 0;
            btnYaIleBitenler.Text = "'Ya' ile bitenler";
            btnYaIleBitenler.UseVisualStyleBackColor = true;
            btnYaIleBitenler.Click += btnYaIleBitenler_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 941);
            Controls.Add(listBox1);
            Controls.Add(btnYaIleBitenler);
            Controls.Add(btnAileBaslayanlar);
            Controls.Add(btnZdenAyaSirala);
            Controls.Add(btnAdanZyeSirala);
            Controls.Add(btnAltidanFazlaOlanlar);
            Controls.Add(btnTumunuListele);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTumunuListele;
        private ListBox listBox1;
        private Button btnAltidanFazlaOlanlar;
        private Button btnAdanZyeSirala;
        private Button btnZdenAyaSirala;
        private Button btnAileBaslayanlar;
        private Button btnYaIleBitenler;
    }
}