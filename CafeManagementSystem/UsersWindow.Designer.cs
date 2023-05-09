namespace CafeManagementSystem
{
    partial class UsersWindow
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
            this.nametxt = new System.Windows.Forms.TextBox();
            this.labelrole = new System.Windows.Forms.Label();
            this.phonetxtBox = new System.Windows.Forms.TextBox();
            this.adresstext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rolesdropdown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.passwordtxt);
            this.leftPanel.Controls.Add(this.usernametxt);
            this.leftPanel.Controls.Add(this.passlabel);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.rolesdropdown);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.text);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.adresstext);
            this.leftPanel.Controls.Add(this.phonetxtBox);
            this.leftPanel.Controls.Add(this.labelrole);
            this.leftPanel.Controls.Add(this.nametxt);
            this.leftPanel.Size = new System.Drawing.Size(250, 519);
            this.leftPanel.Controls.SetChildIndex(this.nametxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.labelrole, 0);
            this.leftPanel.Controls.SetChildIndex(this.phonetxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.adresstext, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.rolesdropdown, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.passlabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernametxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordtxt, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(1120, 519);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint_1);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // nametxt
            // 
            this.nametxt.Enabled = false;
            this.nametxt.Location = new System.Drawing.Point(12, 122);
            this.nametxt.MaxLength = 30;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(213, 23);
            this.nametxt.TabIndex = 4;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelrole.Location = new System.Drawing.Point(12, 104);
            this.labelrole.Name = "labelrole";
            this.labelrole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelrole.Size = new System.Drawing.Size(39, 15);
            this.labelrole.TabIndex = 5;
            this.labelrole.Text = "Name";
            // 
            // phonetxtBox
            // 
            this.phonetxtBox.Enabled = false;
            this.phonetxtBox.Location = new System.Drawing.Point(12, 175);
            this.phonetxtBox.MaxLength = 15;
            this.phonetxtBox.Name = "phonetxtBox";
            this.phonetxtBox.Size = new System.Drawing.Size(213, 23);
            this.phonetxtBox.TabIndex = 13;
            this.phonetxtBox.TextChanged += new System.EventHandler(this.phonetxtBox_TextChanged);
            // 
            // adresstext
            // 
            this.adresstext.Enabled = false;
            this.adresstext.Location = new System.Drawing.Point(12, 224);
            this.adresstext.Name = "adresstext";
            this.adresstext.Size = new System.Drawing.Size(213, 23);
            this.adresstext.TabIndex = 14;
            this.adresstext.TextChanged += new System.EventHandler(this.adresstext_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.text.Location = new System.Drawing.Point(12, 206);
            this.text.Name = "text";
            this.text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text.Size = new System.Drawing.Size(49, 15);
            this.text.TabIndex = 17;
            this.text.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(10, 259);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Role";
            // 
            // rolesdropdown
            // 
            this.rolesdropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolesdropdown.Enabled = false;
            this.rolesdropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rolesdropdown.FormattingEnabled = true;
            this.rolesdropdown.Location = new System.Drawing.Point(12, 277);
            this.rolesdropdown.Name = "rolesdropdown";
            this.rolesdropdown.Size = new System.Drawing.Size(213, 23);
            this.rolesdropdown.TabIndex = 3;
            this.rolesdropdown.SelectedIndexChanged += new System.EventHandler(this.rolesdropdown_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 310);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Username";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passlabel.Location = new System.Drawing.Point(12, 367);
            this.passlabel.Name = "passlabel";
            this.passlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passlabel.Size = new System.Drawing.Size(57, 15);
            this.passlabel.TabIndex = 25;
            this.passlabel.Text = "Password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGv,
            this.userIDGV,
            this.NameGV,
            this.usernameGV,
            this.RoleNameGv,
            this.passGV,
            this.phoneGV,
            this.AddressGV,
            this.RoleIDGV});
            this.dataGridView1.Location = new System.Drawing.Point(3, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1057, 423);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGv
            // 
            this.snoGv.HeaderText = "";
            this.snoGv.Name = "snoGv";
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "UserID";
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "User";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // usernameGV
            // 
            this.usernameGV.HeaderText = "Username";
            this.usernameGV.Name = "usernameGV";
            this.usernameGV.ReadOnly = true;
            // 
            // RoleNameGv
            // 
            this.RoleNameGv.HeaderText = "Role";
            this.RoleNameGv.Name = "RoleNameGv";
            this.RoleNameGv.Width = 505;
            // 
            // passGV
            // 
            this.passGV.HeaderText = "Password";
            this.passGV.Name = "passGV";
            this.passGV.ReadOnly = true;
            this.passGV.Visible = false;
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
            // RoleIDGV
            // 
            this.RoleIDGV.HeaderText = "Role ID";
            this.RoleIDGV.Name = "RoleIDGV";
            this.RoleIDGV.Visible = false;
            // 
            // usernametxt
            // 
            this.usernametxt.Enabled = false;
            this.usernametxt.Location = new System.Drawing.Point(12, 328);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(213, 23);
            this.usernametxt.TabIndex = 27;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Enabled = false;
            this.passwordtxt.Location = new System.Drawing.Point(12, 385);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(213, 23);
            this.passwordtxt.TabIndex = 28;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // UsersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 519);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "UsersWindow";
            this.Text = "UsersWindow";
            this.Load += new System.EventHandler(this.UsersWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label labelrole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresstext;
        private System.Windows.Forms.TextBox phonetxtBox;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.ComboBox rolesdropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn passGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleIDGV;
    }
}