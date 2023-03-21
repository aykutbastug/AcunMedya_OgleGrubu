namespace _02_SqlDataAdapterSinifi
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            gridViewOrders = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            gridViewOrderDetails = new DataGridView();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)gridViewOrders).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 0;
            label1.Text = "Müşteri :";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(178, 41);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(430, 46);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // gridViewOrders
            // 
            gridViewOrders.AllowUserToAddRows = false;
            gridViewOrders.AllowUserToDeleteRows = false;
            gridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewOrders.Dock = DockStyle.Fill;
            gridViewOrders.Location = new Point(3, 41);
            gridViewOrders.Name = "gridViewOrders";
            gridViewOrders.ReadOnly = true;
            gridViewOrders.RowHeadersWidth = 72;
            gridViewOrders.RowTemplate.Height = 37;
            gridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewOrders.Size = new Size(1929, 493);
            gridViewOrders.TabIndex = 2;
            gridViewOrders.SelectionChanged += gridViewOrders_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gridViewOrders);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1935, 537);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sipariş Listesi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridViewOrderDetails);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1935, 540);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sipariş Detatyları";
            // 
            // gridViewOrderDetails
            // 
            gridViewOrderDetails.AllowUserToAddRows = false;
            gridViewOrderDetails.AllowUserToDeleteRows = false;
            gridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewOrderDetails.Dock = DockStyle.Fill;
            gridViewOrderDetails.Location = new Point(3, 41);
            gridViewOrderDetails.Name = "gridViewOrderDetails";
            gridViewOrderDetails.ReadOnly = true;
            gridViewOrderDetails.RowHeadersWidth = 72;
            gridViewOrderDetails.RowTemplate.Height = 37;
            gridViewOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewOrderDetails.Size = new Size(1929, 496);
            gridViewOrderDetails.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 120);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1935, 1081);
            splitContainer1.SplitterDistance = 537;
            splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1959, 1213);
            Controls.Add(splitContainer1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewOrders).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridViewOrderDetails).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private DataGridView gridViewOrders;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView gridViewOrderDetails;
        private SplitContainer splitContainer1;
    }
}