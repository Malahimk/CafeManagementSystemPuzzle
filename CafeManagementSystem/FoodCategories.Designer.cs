namespace CafeManagementSystem
{
    partial class FoodCategories
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
            this.detailsbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorytext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.categorytext);
            this.leftPanel.Size = new System.Drawing.Size(250, 542);
            this.leftPanel.Controls.SetChildIndex(this.categorytext, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsbox);
            this.rightPanel.Size = new System.Drawing.Size(730, 542);
            this.rightPanel.Controls.SetChildIndex(this.detailsbox, 0);
            // 
            // detailsbox
            // 
            this.detailsbox.Controls.Add(this.dataGridView1);
            this.detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.detailsbox.Location = new System.Drawing.Point(0, 54);
            this.detailsbox.Name = "detailsbox";
            this.detailsbox.Size = new System.Drawing.Size(730, 488);
            this.detailsbox.TabIndex = 6;
            this.detailsbox.TabStop = false;
            this.detailsbox.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGv,
            this.catIDGV,
            this.catNameGV});
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 466);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGv
            // 
            this.snoGv.HeaderText = "";
            this.snoGv.Name = "snoGv";
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "catID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catNameGV
            // 
            this.catNameGV.HeaderText = "Categories";
            this.catNameGV.Name = "catNameGV";
            this.catNameGV.ReadOnly = true;
            // 
            // categorytext
            // 
            this.categorytext.Enabled = false;
            this.categorytext.Location = new System.Drawing.Point(12, 152);
            this.categorytext.Name = "categorytext";
            this.categorytext.Size = new System.Drawing.Size(213, 23);
            this.categorytext.TabIndex = 4;
            this.categorytext.TextChanged += new System.EventHandler(this.categorytext_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FoodCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 542);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "FoodCategories";
            this.Text = "FoodCategories";
            this.Load += new System.EventHandler(this.FoodCategories_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameGV;
        private System.Windows.Forms.TextBox categorytext;
        private System.Windows.Forms.Label label3;
    }
}