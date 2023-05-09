namespace CafeManagementSystem
{
    partial class OrderCompletionWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.billlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FloorNumbeDD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.FloorNumbeDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.billlabel);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.textBox1);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.dataGridView1);
            this.leftPanel.Size = new System.Drawing.Size(501, 568);
            this.leftPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.textBox1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.billlabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.button1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.FloorNumbeDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(501, 0);
            this.rightPanel.Size = new System.Drawing.Size(409, 568);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.itemGV,
            this.quantGV,
            this.amountGV,
            this.orderIDGV});
            this.dataGridView1.Location = new System.Drawing.Point(-8, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            // 
            // itemGV
            // 
            this.itemGV.HeaderText = "Item";
            this.itemGV.Name = "itemGV";
            this.itemGV.ReadOnly = true;
            // 
            // quantGV
            // 
            this.quantGV.HeaderText = "Quantity";
            this.quantGV.Name = "quantGV";
            this.quantGV.ReadOnly = true;
            // 
            // amountGV
            // 
            this.amountGV.HeaderText = "Amount";
            this.amountGV.Name = "amountGV";
            this.amountGV.ReadOnly = true;
            // 
            // orderIDGV
            // 
            this.orderIDGV.HeaderText = "Order ID";
            this.orderIDGV.Name = "orderIDGV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Bill:";
            // 
            // billlabel
            // 
            this.billlabel.AutoSize = true;
            this.billlabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billlabel.Location = new System.Drawing.Point(141, 429);
            this.billlabel.Name = "billlabel";
            this.billlabel.Size = new System.Drawing.Size(53, 37);
            this.billlabel.TabIndex = 5;
            this.billlabel.Text = "0.0";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "generate bill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Order Type";
            // 
            // FloorNumbeDD
            // 
            this.FloorNumbeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FloorNumbeDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FloorNumbeDD.FormattingEnabled = true;
            this.FloorNumbeDD.Items.AddRange(new object[] {
            "DIne-In",
            "Takeaway",
            "HomeDelievery"});
            this.FloorNumbeDD.Location = new System.Drawing.Point(15, 138);
            this.FloorNumbeDD.Name = "FloorNumbeDD";
            this.FloorNumbeDD.Size = new System.Drawing.Size(432, 23);
            this.FloorNumbeDD.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Order Type";
            // 
            // OrderCompletionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 568);
            this.Name = "OrderCompletionWindow";
            this.Text = "OrderCompletionWindow";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label billlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FloorNumbeDD;
    }
}