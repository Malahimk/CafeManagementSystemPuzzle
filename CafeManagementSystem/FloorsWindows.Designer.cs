namespace CafeManagementSystem
{
    partial class FloorsWindows
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
            this.Floortxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FloorNumbeDD = new System.Windows.Forms.ComboBox();
            this.detailsbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.FloorNumbeDD);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.Floortxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(250, 550);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.Floortxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.FloorNumbeDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsbox);
            this.rightPanel.Size = new System.Drawing.Size(776, 550);
            this.rightPanel.Controls.SetChildIndex(this.detailsbox, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Floor";
            // 
            // Floortxt
            // 
            this.Floortxt.Location = new System.Drawing.Point(15, 134);
            this.Floortxt.MaxLength = 20;
            this.Floortxt.Name = "Floortxt";
            this.Floortxt.Size = new System.Drawing.Size(187, 23);
            this.Floortxt.TabIndex = 3;
            this.Floortxt.TextChanged += new System.EventHandler(this.Floortxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Floor number";
            // 
            // FloorNumbeDD
            // 
            this.FloorNumbeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FloorNumbeDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FloorNumbeDD.FormattingEnabled = true;
            this.FloorNumbeDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.FloorNumbeDD.Location = new System.Drawing.Point(15, 190);
            this.FloorNumbeDD.Name = "FloorNumbeDD";
            this.FloorNumbeDD.Size = new System.Drawing.Size(187, 23);
            this.FloorNumbeDD.TabIndex = 3;
            this.FloorNumbeDD.SelectedIndexChanged += new System.EventHandler(this.FloorNumbeDD_SelectedIndexChanged);
            // 
            // detailsbox
            // 
            this.detailsbox.Controls.Add(this.dataGridView1);
            this.detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.detailsbox.Location = new System.Drawing.Point(0, 99);
            this.detailsbox.Name = "detailsbox";
            this.detailsbox.Size = new System.Drawing.Size(776, 451);
            this.detailsbox.TabIndex = 5;
            this.detailsbox.TabStop = false;
            this.detailsbox.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGv,
            this.floorIDGV,
            this.floorNameGV,
            this.floorNumberGV});
            this.dataGridView1.Location = new System.Drawing.Point(0, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 423);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGv
            // 
            this.snoGv.HeaderText = "";
            this.snoGv.Name = "snoGv";
            // 
            // floorIDGV
            // 
            this.floorIDGV.HeaderText = "floorID";
            this.floorIDGV.Name = "floorIDGV";
            this.floorIDGV.ReadOnly = true;
            this.floorIDGV.Visible = false;
            // 
            // floorNameGV
            // 
            this.floorNameGV.HeaderText = "Floor";
            this.floorNameGV.Name = "floorNameGV";
            this.floorNameGV.ReadOnly = true;
            // 
            // floorNumberGV
            // 
            this.floorNumberGV.HeaderText = "Floor Number";
            this.floorNumberGV.Name = "floorNumberGV";
            this.floorNumberGV.ReadOnly = true;
            // 
            // FloorsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 550);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "FloorsWindows";
            this.Text = "FloorsWindows";
            this.Load += new System.EventHandler(this.FloorsWindows_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FloorNumbeDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Floortxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox detailsbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberGV;
    }
}