namespace CafeManagementSystem
{
    partial class customersWindow
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
            this.nametext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detailsbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.addresstext);
            this.leftPanel.Controls.Add(this.phonetext);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.nametext);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.nametext, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.phonetext, 0);
            this.leftPanel.Controls.SetChildIndex(this.addresstext, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsbox);
            this.rightPanel.Controls.SetChildIndex(this.detailsbox, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(15, 136);
            this.nametext.MaxLength = 50;
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(214, 23);
            this.nametext.TabIndex = 3;
            this.nametext.TextChanged += new System.EventHandler(this.nametext_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(15, 193);
            this.phonetext.MaxLength = 15;
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(214, 23);
            this.phonetext.TabIndex = 5;
            this.phonetext.TextChanged += new System.EventHandler(this.phonetext_TextChanged);
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(15, 251);
            this.addresstext.MaxLength = 100;
            this.addresstext.Multiline = true;
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(214, 71);
            this.addresstext.TabIndex = 4;
            this.addresstext.TextChanged += new System.EventHandler(this.addresstext_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // detailsbox
            // 
            this.detailsbox.Controls.Add(this.dataGridView1);
            this.detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.detailsbox.Location = new System.Drawing.Point(0, 99);
            this.detailsbox.Name = "detailsbox";
            this.detailsbox.Size = new System.Drawing.Size(683, 420);
            this.detailsbox.TabIndex = 4;
            this.detailsbox.TabStop = false;
            this.detailsbox.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGv,
            this.custIDGV,
            this.NameGV,
            this.phoneGV,
            this.AddressGV});
            this.dataGridView1.Location = new System.Drawing.Point(0, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 400);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGv
            // 
            this.snoGv.HeaderText = "";
            this.snoGv.Name = "snoGv";
            // 
            // custIDGV
            // 
            this.custIDGV.HeaderText = "custID";
            this.custIDGV.Name = "custIDGV";
            this.custIDGV.ReadOnly = true;
            this.custIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Customer";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // AddressGV
            // 
            this.AddressGV.HeaderText = "Address";
            this.AddressGV.Name = "AddressGV";
            this.AddressGV.ReadOnly = true;
            // 
            // customersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "customersWindow";
            this.Text = "customersWindow";
            this.Load += new System.EventHandler(this.customersWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox detailsbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressGV;
    }
}