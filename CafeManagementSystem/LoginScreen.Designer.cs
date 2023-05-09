namespace CafeManagementSystem
{
    partial class LoginScreen
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
            this.userTxt = new System.Windows.Forms.Label();
            this.usertxtBox = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.Label();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.pictureBox7);
            this.leftPanel.Controls.Add(this.loginBtn);
            this.leftPanel.Controls.Add(this.passwordtxtbox);
            this.leftPanel.Controls.Add(this.passTxt);
            this.leftPanel.Controls.Add(this.usertxtBox);
            this.leftPanel.Controls.Add(this.userTxt);
            this.leftPanel.Size = new System.Drawing.Size(250, 629);
            this.leftPanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.usertxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordtxtbox, 0);
            this.leftPanel.Controls.SetChildIndex(this.loginBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.pictureBox7, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rightPanel.BackgroundImage = global::CafeManagementSystem.Properties.Resources.wallpaper_5;
            this.rightPanel.Controls.Add(this.pictureBox1);
            this.rightPanel.Size = new System.Drawing.Size(1079, 629);
            // 
            // userTxt
            // 
            this.userTxt.AutoSize = true;
            this.userTxt.BackColor = System.Drawing.Color.SteelBlue;
            this.userTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.ForeColor = System.Drawing.Color.White;
            this.userTxt.Location = new System.Drawing.Point(12, 331);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(87, 19);
            this.userTxt.TabIndex = 2;
            this.userTxt.Text = "Username";
            this.userTxt.Click += new System.EventHandler(this.label3_Click);
            // 
            // usertxtBox
            // 
            this.usertxtBox.Location = new System.Drawing.Point(12, 362);
            this.usertxtBox.Name = "usertxtBox";
            this.usertxtBox.Size = new System.Drawing.Size(207, 23);
            this.usertxtBox.TabIndex = 2;
            this.usertxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passTxt
            // 
            this.passTxt.AutoSize = true;
            this.passTxt.BackColor = System.Drawing.Color.SteelBlue;
            this.passTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.ForeColor = System.Drawing.Color.White;
            this.passTxt.Location = new System.Drawing.Point(12, 397);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(86, 19);
            this.passTxt.TabIndex = 3;
            this.passTxt.Text = "Password";
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(13, 426);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(207, 23);
            this.passwordtxtbox.TabIndex = 4;
            this.passwordtxtbox.UseSystemPasswordChar = true;
            this.passwordtxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Crimson;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(12, 466);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(207, 65);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CafeManagementSystem.Properties.Resources.PUzzLE_CAFE;
            this.pictureBox7.Location = new System.Drawing.Point(13, 59);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(223, 232);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagementSystem.Properties.Resources.loginimpage;
            this.pictureBox1.Location = new System.Drawing.Point(373, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 629);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.Label passTxt;
        private System.Windows.Forms.TextBox usertxtBox;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}