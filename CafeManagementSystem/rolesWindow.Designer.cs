namespace CafeManagementSystem
{
    partial class rolesWindow
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
            this.labelrole = new System.Windows.Forms.Label();
            this.roletext = new System.Windows.Forms.TextBox();
            this.roleError = new System.Windows.Forms.Label();
            this.detailsbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.roleError);
            this.leftPanel.Controls.Add(this.roletext);
            this.leftPanel.Controls.Add(this.labelrole);
            this.leftPanel.Controls.SetChildIndex(this.labelrole, 0);
            this.leftPanel.Controls.SetChildIndex(this.roletext, 0);
            this.leftPanel.Controls.SetChildIndex(this.roleError, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsbox);
            this.rightPanel.Controls.SetChildIndex(this.detailsbox, 0);
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelrole.Location = new System.Drawing.Point(12, 110);
            this.labelrole.Name = "labelrole";
            this.labelrole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelrole.Size = new System.Drawing.Size(30, 15);
            this.labelrole.TabIndex = 3;
            this.labelrole.Text = "Role";
            // 
            // roletext
            // 
            this.roletext.Enabled = false;
            this.roletext.Location = new System.Drawing.Point(12, 130);
            this.roletext.Name = "roletext";
            this.roletext.Size = new System.Drawing.Size(213, 23);
            this.roletext.TabIndex = 3;
            this.roletext.TextChanged += new System.EventHandler(this.roletext_TextChanged);
            // 
            // roleError
            // 
            this.roleError.AutoSize = true;
            this.roleError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleError.ForeColor = System.Drawing.Color.White;
            this.roleError.Location = new System.Drawing.Point(205, 99);
            this.roleError.Name = "roleError";
            this.roleError.Size = new System.Drawing.Size(20, 28);
            this.roleError.TabIndex = 11;
            this.roleError.Text = "*";
            this.roleError.Visible = false;
            // 
            // detailsbox
            // 
            this.detailsbox.Controls.Add(this.dataGridView1);
            this.detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.detailsbox.Location = new System.Drawing.Point(0, 99);
            this.detailsbox.Name = "detailsbox";
            this.detailsbox.Size = new System.Drawing.Size(683, 420);
            this.detailsbox.TabIndex = 3;
            this.detailsbox.TabStop = false;
            this.detailsbox.Text = "Details";
            this.detailsbox.Enter += new System.EventHandler(this.detailsbox_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.roleNameGv,
            this.roleIDGV});
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(680, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.HeaderText = "";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            // 
            // roleNameGv
            // 
            this.roleNameGv.HeaderText = "Role";
            this.roleNameGv.Name = "roleNameGv";
            this.roleNameGv.ReadOnly = true;
            this.roleNameGv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleNameGv.Width = 505;
            // 
            // roleIDGV
            // 
            this.roleIDGV.HeaderText = "RoleID";
            this.roleIDGV.Name = "roleIDGV";
            this.roleIDGV.ReadOnly = true;
            this.roleIDGV.Visible = false;
            this.roleIDGV.Width = 200;
            // 
            // rolesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "rolesWindow";
            this.Text = "rolesWindow";
            this.Load += new System.EventHandler(this.rolesWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox roletext;
        private System.Windows.Forms.Label labelrole;
        private System.Windows.Forms.Label roleError;
        private System.Windows.Forms.GroupBox detailsbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDGV;
    }
}