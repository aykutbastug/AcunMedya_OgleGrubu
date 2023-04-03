namespace _05_First_Single_Last
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
            btnFirst = new Button();
            btnFirstOrDefault = new Button();
            btnLast = new Button();
            btnLastOrDefault = new Button();
            btnSingle = new Button();
            btnSingleOrDefault = new Button();
            btnFirstBos = new Button();
            btnFirstOrDefaultBos = new Button();
            btnLastBos = new Button();
            btnLastOrDefaultBos = new Button();
            btnSingleBos = new Button();
            btnSingleOrDefaultBos = new Button();
            SuspendLayout();
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(28, 30);
            btnFirst.Margin = new Padding(4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(318, 62);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "First()";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnFirstOrDefault
            // 
            btnFirstOrDefault.Location = new Point(28, 100);
            btnFirstOrDefault.Margin = new Padding(4);
            btnFirstOrDefault.Name = "btnFirstOrDefault";
            btnFirstOrDefault.Size = new Size(318, 62);
            btnFirstOrDefault.TabIndex = 0;
            btnFirstOrDefault.Text = "FirstOrDefault()";
            btnFirstOrDefault.UseVisualStyleBackColor = true;
            btnFirstOrDefault.Click += btnFirstOrDefault_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(446, 30);
            btnLast.Margin = new Padding(4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(318, 62);
            btnLast.TabIndex = 0;
            btnLast.Text = "Last()";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnLastOrDefault
            // 
            btnLastOrDefault.Location = new Point(446, 100);
            btnLastOrDefault.Margin = new Padding(4);
            btnLastOrDefault.Name = "btnLastOrDefault";
            btnLastOrDefault.Size = new Size(318, 62);
            btnLastOrDefault.TabIndex = 0;
            btnLastOrDefault.Text = "LastOrDefault()";
            btnLastOrDefault.UseVisualStyleBackColor = true;
            btnLastOrDefault.Click += btnLastOrDefault_Click;
            // 
            // btnSingle
            // 
            btnSingle.Location = new Point(898, 30);
            btnSingle.Margin = new Padding(4);
            btnSingle.Name = "btnSingle";
            btnSingle.Size = new Size(318, 62);
            btnSingle.TabIndex = 0;
            btnSingle.Text = "Single()";
            btnSingle.UseVisualStyleBackColor = true;
            btnSingle.Click += btnSingle_Click;
            // 
            // btnSingleOrDefault
            // 
            btnSingleOrDefault.Location = new Point(898, 100);
            btnSingleOrDefault.Margin = new Padding(4);
            btnSingleOrDefault.Name = "btnSingleOrDefault";
            btnSingleOrDefault.Size = new Size(318, 62);
            btnSingleOrDefault.TabIndex = 0;
            btnSingleOrDefault.Text = "SingleOrDefault()";
            btnSingleOrDefault.UseVisualStyleBackColor = true;
            btnSingleOrDefault.Click += btnSingleOrDefault_Click;
            // 
            // btnFirstBos
            // 
            btnFirstBos.Location = new Point(28, 170);
            btnFirstBos.Margin = new Padding(4);
            btnFirstBos.Name = "btnFirstBos";
            btnFirstBos.Size = new Size(318, 62);
            btnFirstBos.TabIndex = 0;
            btnFirstBos.Text = "First() Boş";
            btnFirstBos.UseVisualStyleBackColor = true;
            btnFirstBos.Click += btnFirstBos_Click;
            // 
            // btnFirstOrDefaultBos
            // 
            btnFirstOrDefaultBos.Location = new Point(28, 240);
            btnFirstOrDefaultBos.Margin = new Padding(4);
            btnFirstOrDefaultBos.Name = "btnFirstOrDefaultBos";
            btnFirstOrDefaultBos.Size = new Size(318, 62);
            btnFirstOrDefaultBos.TabIndex = 0;
            btnFirstOrDefaultBos.Text = "FirstOrDefault() Boş";
            btnFirstOrDefaultBos.UseVisualStyleBackColor = true;
            btnFirstOrDefaultBos.Click += btnFirstOrDefaultBos_Click;
            // 
            // btnLastBos
            // 
            btnLastBos.Location = new Point(446, 170);
            btnLastBos.Margin = new Padding(4);
            btnLastBos.Name = "btnLastBos";
            btnLastBos.Size = new Size(318, 62);
            btnLastBos.TabIndex = 0;
            btnLastBos.Text = "Last() Boş";
            btnLastBos.UseVisualStyleBackColor = true;
            btnLastBos.Click += btnLastBos_Click;
            // 
            // btnLastOrDefaultBos
            // 
            btnLastOrDefaultBos.Location = new Point(446, 240);
            btnLastOrDefaultBos.Margin = new Padding(4);
            btnLastOrDefaultBos.Name = "btnLastOrDefaultBos";
            btnLastOrDefaultBos.Size = new Size(318, 62);
            btnLastOrDefaultBos.TabIndex = 0;
            btnLastOrDefaultBos.Text = "LastOrDefault() Boş";
            btnLastOrDefaultBos.UseVisualStyleBackColor = true;
            btnLastOrDefaultBos.Click += btnLastOrDefaultBos_Click;
            // 
            // btnSingleBos
            // 
            btnSingleBos.Location = new Point(898, 170);
            btnSingleBos.Margin = new Padding(4);
            btnSingleBos.Name = "btnSingleBos";
            btnSingleBos.Size = new Size(318, 62);
            btnSingleBos.TabIndex = 0;
            btnSingleBos.Text = "Single() Boş";
            btnSingleBos.UseVisualStyleBackColor = true;
            btnSingleBos.Click += btnSingleBos_Click;
            // 
            // btnSingleOrDefaultBos
            // 
            btnSingleOrDefaultBos.Location = new Point(898, 240);
            btnSingleOrDefaultBos.Margin = new Padding(4);
            btnSingleOrDefaultBos.Name = "btnSingleOrDefaultBos";
            btnSingleOrDefaultBos.Size = new Size(318, 62);
            btnSingleOrDefaultBos.TabIndex = 0;
            btnSingleOrDefaultBos.Text = "SingleOrDefault() Boş";
            btnSingleOrDefaultBos.UseVisualStyleBackColor = true;
            btnSingleOrDefaultBos.Click += btnSingleOrDefaultBos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 365);
            Controls.Add(btnSingleOrDefaultBos);
            Controls.Add(btnSingleOrDefault);
            Controls.Add(btnLastOrDefaultBos);
            Controls.Add(btnLastOrDefault);
            Controls.Add(btnFirstOrDefaultBos);
            Controls.Add(btnSingleBos);
            Controls.Add(btnFirstOrDefault);
            Controls.Add(btnSingle);
            Controls.Add(btnLastBos);
            Controls.Add(btnLast);
            Controls.Add(btnFirstBos);
            Controls.Add(btnFirst);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnFirst;
        private Button btnFirstOrDefault;
        private Button btnLast;
        private Button btnLastOrDefault;
        private Button btnSingle;
        private Button btnSingleOrDefault;
        private Button btnFirstBos;
        private Button btnFirstOrDefaultBos;
        private Button btnLastBos;
        private Button btnLastOrDefaultBos;
        private Button btnSingleBos;
        private Button btnSingleOrDefaultBos;
    }
}