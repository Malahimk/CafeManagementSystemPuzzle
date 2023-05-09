namespace CafeManagementSystem
{
    partial class menuwindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuItemtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.catDD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.detailsbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuitemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageGv = new System.Windows.Forms.DataGridViewImageColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.loadBtn);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.pricetxt);
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.catDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.menuItemtxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(250, 689);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint_1);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.menuItemtxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.catDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.pricetxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.leftPanel.Controls.SetChildIndex(this.loadBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsbox);
            this.rightPanel.Size = new System.Drawing.Size(915, 689);
            this.rightPanel.Controls.SetChildIndex(this.detailsbox, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu Item";
            // 
            // menuItemtxt
            // 
            this.menuItemtxt.Location = new System.Drawing.Point(21, 142);
            this.menuItemtxt.MaxLength = 50;
            this.menuItemtxt.Name = "menuItemtxt";
            this.menuItemtxt.Size = new System.Drawing.Size(191, 23);
            this.menuItemtxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category";
            // 
            // catDD
            // 
            this.catDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.catDD.FormattingEnabled = true;
            this.catDD.Location = new System.Drawing.Point(21, 195);
            this.catDD.Name = "catDD";
            this.catDD.Size = new System.Drawing.Size(191, 23);
            this.catDD.TabIndex = 10;
            this.catDD.SelectedIndexChanged += new System.EventHandler(this.catDD_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.statusDD.Location = new System.Drawing.Point(21, 307);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(191, 23);
            this.statusDD.TabIndex = 14;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(21, 252);
            this.pricetxt.MaxLength = 5;
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(191, 23);
            this.pricetxt.TabIndex = 15;
            this.pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // detailsbox
            // 
            this.detailsbox.Controls.Add(this.dataGridView1);
            this.detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.detailsbox.Location = new System.Drawing.Point(0, 99);
            this.detailsbox.Name = "detailsbox";
            this.detailsbox.Size = new System.Drawing.Size(915, 590);
            this.detailsbox.TabIndex = 7;
            this.detailsbox.TabStop = false;
            this.detailsbox.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGv,
            this.menuIDGV,
            this.MenuitemGV,
            this.priceGV,
            this.catNameGV,
            this.statusGV,
            this.catIDGV,
            this.imageGv});
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 568);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGv
            // 
            this.snoGv.HeaderText = "";
            this.snoGv.Name = "snoGv";
            // 
            // menuIDGV
            // 
            this.menuIDGV.HeaderText = "MenuID";
            this.menuIDGV.Name = "menuIDGV";
            this.menuIDGV.ReadOnly = true;
            this.menuIDGV.Visible = false;
            // 
            // MenuitemGV
            // 
            this.MenuitemGV.HeaderText = "Menu Item";
            this.MenuitemGV.Name = "MenuitemGV";
            this.MenuitemGV.ReadOnly = true;
            // 
            // priceGV
            // 
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // catNameGV
            // 
            this.catNameGV.HeaderText = "Categories";
            this.catNameGV.Name = "catNameGV";
            this.catNameGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "catID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // imageGv
            // 
            this.imageGv.HeaderText = "Image";
            this.imageGv.Image = global::CafeManagementSystem.Properties.Resources.foodm;
            this.imageGv.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageGv.Name = "imageGv";
            this.imageGv.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(18, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagementSystem.Properties.Resources.foodm;
            this.pictureBox1.Location = new System.Drawing.Point(43, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 77);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Firebrick;
            this.loadBtn.FlatAppearance.BorderSize = 2;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadBtn.Location = new System.Drawing.Point(21, 369);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(191, 30);
            this.loadBtn.TabIndex = 18;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 689);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "menuwindow";
            this.Text = "menuwindow";
            this.Load += new System.EventHandler(this.menuwindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox catDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox menuItemtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox detailsbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuitemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewImageColumn imageGv;
    }
}