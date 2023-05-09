namespace CafeManagementSystem
{
    partial class HomeScreen2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.foodmenuBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.loginBtn);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Size = new System.Drawing.Size(250, 656);
            this.leftPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.leftPanel.Controls.SetChildIndex(this.loginBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.button1, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(550, 656);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ordersBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.foodmenuBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 656);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.White;
            this.ordersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersBtn.FlatAppearance.BorderSize = 2;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.Font = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.ordersBtn.Image = global::CafeManagementSystem.Properties.Resources.order1;
            this.ordersBtn.Location = new System.Drawing.Point(369, 3);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(178, 322);
            this.ordersBtn.TabIndex = 7;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ordersBtn.UseVisualStyleBackColor = false;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.White;
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerBtn.FlatAppearance.BorderSize = 2;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.customerBtn.Image = global::CafeManagementSystem.Properties.Resources.customer2_0;
            this.customerBtn.Location = new System.Drawing.Point(186, 3);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(177, 322);
            this.customerBtn.TabIndex = 6;
            this.customerBtn.Text = "Customer";
            this.customerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // foodmenuBtn
            // 
            this.foodmenuBtn.BackColor = System.Drawing.Color.White;
            this.foodmenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodmenuBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodmenuBtn.FlatAppearance.BorderSize = 2;
            this.foodmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodmenuBtn.Font = new System.Drawing.Font("Leelawadee UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodmenuBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.foodmenuBtn.Image = global::CafeManagementSystem.Properties.Resources.food_menu;
            this.foodmenuBtn.Location = new System.Drawing.Point(3, 3);
            this.foodmenuBtn.Name = "foodmenuBtn";
            this.foodmenuBtn.Size = new System.Drawing.Size(177, 322);
            this.foodmenuBtn.TabIndex = 5;
            this.foodmenuBtn.Text = "Food Menu";
            this.foodmenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.foodmenuBtn.UseVisualStyleBackColor = false;
            this.foodmenuBtn.Click += new System.EventHandler(this.foodmenuBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::CafeManagementSystem.Properties.Resources.carrot;
            this.pictureBox2.Location = new System.Drawing.Point(3, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 322);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::CafeManagementSystem.Properties.Resources.chamach2;
            this.pictureBox3.Location = new System.Drawing.Point(186, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 322);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::CafeManagementSystem.Properties.Resources.pan2;
            this.pictureBox4.Location = new System.Drawing.Point(369, 331);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 322);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagementSystem.Properties.Resources.PUzzLE_CAFE;
            this.pictureBox1.Location = new System.Drawing.Point(22, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Crimson;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(22, 476);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(198, 64);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "LOG OUT";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Name = "HomeScreen2";
            this.Text = "HomeScreen2";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button foodmenuBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button button1;
    }
}