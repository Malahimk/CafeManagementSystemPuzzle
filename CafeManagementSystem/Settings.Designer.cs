namespace CafeManagementSystem
{
    partial class Settings
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
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.inCB = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.serverError = new System.Windows.Forms.Label();
            this.databaseError = new System.Windows.Forms.Label();
            this.userError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.inCB);
            this.leftPanel.Controls.Add(this.passwordTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.userTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.databaseTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.serverTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.serverError);
            this.leftPanel.Controls.Add(this.databaseError);
            this.leftPanel.Controls.Add(this.userError);
            this.leftPanel.Controls.Add(this.passwordError);
            this.leftPanel.Size = new System.Drawing.Size(250, 450);
            this.leftPanel.Controls.SetChildIndex(this.passwordError, 0);
            this.leftPanel.Controls.SetChildIndex(this.userError, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseError, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.inCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(550, 450);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(15, 130);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(218, 23);
            this.serverTxt.TabIndex = 2;
            this.serverTxt.TextChanged += new System.EventHandler(this.serverTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(12, 190);
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(221, 23);
            this.databaseTxt.TabIndex = 4;
            this.databaseTxt.TextChanged += new System.EventHandler(this.databaseTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(12, 251);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(221, 23);
            this.userTxt.TabIndex = 6;
            this.userTxt.TextChanged += new System.EventHandler(this.userTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(12, 307);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(221, 23);
            this.passwordTxt.TabIndex = 8;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // inCB
            // 
            this.inCB.AutoSize = true;
            this.inCB.ForeColor = System.Drawing.Color.White;
            this.inCB.Location = new System.Drawing.Point(12, 346);
            this.inCB.Name = "inCB";
            this.inCB.Size = new System.Drawing.Size(125, 19);
            this.inCB.TabIndex = 2;
            this.inCB.Text = "Integrated Security";
            this.inCB.UseVisualStyleBackColor = true;
            this.inCB.CheckedChanged += new System.EventHandler(this.inCB_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(12, 381);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(221, 36);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // serverError
            // 
            this.serverError.AutoSize = true;
            this.serverError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverError.ForeColor = System.Drawing.Color.White;
            this.serverError.Location = new System.Drawing.Point(213, 99);
            this.serverError.Name = "serverError";
            this.serverError.Size = new System.Drawing.Size(20, 28);
            this.serverError.TabIndex = 10;
            this.serverError.Text = "*";
            this.serverError.Visible = false;
            // 
            // databaseError
            // 
            this.databaseError.AutoSize = true;
            this.databaseError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseError.ForeColor = System.Drawing.Color.White;
            this.databaseError.Location = new System.Drawing.Point(213, 161);
            this.databaseError.Name = "databaseError";
            this.databaseError.Size = new System.Drawing.Size(20, 28);
            this.databaseError.TabIndex = 11;
            this.databaseError.Text = "*";
            this.databaseError.Visible = false;
            // 
            // userError
            // 
            this.userError.AutoSize = true;
            this.userError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userError.ForeColor = System.Drawing.Color.White;
            this.userError.Location = new System.Drawing.Point(213, 222);
            this.userError.Name = "userError";
            this.userError.Size = new System.Drawing.Size(20, 28);
            this.userError.TabIndex = 12;
            this.userError.Text = "*";
            this.userError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError.ForeColor = System.Drawing.Color.White;
            this.passwordError.Location = new System.Drawing.Point(213, 276);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(20, 28);
            this.passwordError.TabIndex = 13;
            this.passwordError.Text = "*";
            this.passwordError.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox inCB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label serverError;
        private System.Windows.Forms.Label databaseError;
        private System.Windows.Forms.Label userError;
        private System.Windows.Forms.Label passwordError;
    }
}