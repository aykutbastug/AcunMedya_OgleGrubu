namespace MusteriTakipUygulamasi
{
    partial class frmMusteriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriSil));
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSoru = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVazgec
            // 
            this.btnVazgec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVazgec.Location = new System.Drawing.Point(455, 278);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnVazgec.Size = new System.Drawing.Size(185, 67);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(646, 278);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnSil.Size = new System.Drawing.Size(149, 67);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 127);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblSoru
            // 
            this.lblSoru.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoru.Location = new System.Drawing.Point(174, 56);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(607, 127);
            this.lblSoru.TabIndex = 5;
            this.lblSoru.Text = "label1";
            this.lblSoru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMusteriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 354);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMusteriSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriyi Sil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVazgec;
        private Button btnSil;
        private PictureBox pictureBox1;
        public Label lblSoru;
    }
}