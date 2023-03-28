namespace WinFormsApp1
{
    partial class frmAnaSayfa
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblAdiSoyadi = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblEmail = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            menuYoneticiPersonel = new ToolStripMenuItem();
            menuYoneticiHarcama = new ToolStripMenuItem();
            onayBekleyenlerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuPersonelHarcama = new ToolStripMenuItem();
            onayBekleyenlerToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            harcamaEkleToolStripMenuItem = new ToolStripMenuItem();
            menuBilgilerim = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(28, 28);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblAdiSoyadi, toolStripStatusLabel3, lblEmail });
            statusStrip1.Location = new Point(0, 610);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1738, 39);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(174, 30);
            toolStripStatusLabel1.Text = "Kullanıcı Bilgileri :";
            // 
            // lblAdiSoyadi
            // 
            lblAdiSoyadi.Name = "lblAdiSoyadi";
            lblAdiSoyadi.Size = new Size(135, 30);
            lblAdiSoyadi.Text = "Aykut Baştuğ";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(18, 30);
            toolStripStatusLabel3.Text = "|";
            // 
            // lblEmail
            // 
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(274, 30);
            lblEmail.Text = "aykut.bastug@codeove.com";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuYoneticiPersonel, menuYoneticiHarcama, menuPersonelHarcama, menuBilgilerim });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1738, 38);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuYoneticiPersonel
            // 
            menuYoneticiPersonel.Name = "menuYoneticiPersonel";
            menuYoneticiPersonel.Size = new Size(132, 34);
            menuYoneticiPersonel.Text = "Personeller";
            menuYoneticiPersonel.Click += menuYoneticiPersonel_Click;
            // 
            // menuYoneticiHarcama
            // 
            menuYoneticiHarcama.DropDownItems.AddRange(new ToolStripItem[] { onayBekleyenlerToolStripMenuItem, toolStripMenuItem2 });
            menuYoneticiHarcama.Name = "menuYoneticiHarcama";
            menuYoneticiHarcama.Size = new Size(137, 34);
            menuYoneticiHarcama.Text = "Harcamalar";
            // 
            // onayBekleyenlerToolStripMenuItem
            // 
            onayBekleyenlerToolStripMenuItem.Name = "onayBekleyenlerToolStripMenuItem";
            onayBekleyenlerToolStripMenuItem.Size = new Size(291, 40);
            onayBekleyenlerToolStripMenuItem.Text = "Onay Bekleyenler";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(291, 40);
            toolStripMenuItem2.Text = "...";
            // 
            // menuPersonelHarcama
            // 
            menuPersonelHarcama.DropDownItems.AddRange(new ToolStripItem[] { onayBekleyenlerToolStripMenuItem1, toolStripMenuItem3, harcamaEkleToolStripMenuItem });
            menuPersonelHarcama.Name = "menuPersonelHarcama";
            menuPersonelHarcama.Size = new Size(198, 34);
            menuPersonelHarcama.Text = "Harcama Personel";
            // 
            // onayBekleyenlerToolStripMenuItem1
            // 
            onayBekleyenlerToolStripMenuItem1.Name = "onayBekleyenlerToolStripMenuItem1";
            onayBekleyenlerToolStripMenuItem1.Size = new Size(291, 40);
            onayBekleyenlerToolStripMenuItem1.Text = "Onay Bekleyenler";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(291, 40);
            toolStripMenuItem3.Text = "...";
            // 
            // harcamaEkleToolStripMenuItem
            // 
            harcamaEkleToolStripMenuItem.Name = "harcamaEkleToolStripMenuItem";
            harcamaEkleToolStripMenuItem.Size = new Size(291, 40);
            harcamaEkleToolStripMenuItem.Text = "Harcama Ekle";
            // 
            // menuBilgilerim
            // 
            menuBilgilerim.Name = "menuBilgilerim";
            menuBilgilerim.Size = new Size(116, 34);
            menuBilgilerim.Text = "Bilgilerim";
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1738, 649);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmAnaSayfa";
            Text = "nay Bekleyenler";
            Load += frmAnaSayfa_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblAdiSoyadi;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblEmail;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuYoneticiPersonel;
        private ToolStripMenuItem menuYoneticiHarcama;
        private ToolStripMenuItem onayBekleyenlerToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem menuPersonelHarcama;
        private ToolStripMenuItem onayBekleyenlerToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem harcamaEkleToolStripMenuItem;
        private ToolStripMenuItem menuBilgilerim;
    }
}