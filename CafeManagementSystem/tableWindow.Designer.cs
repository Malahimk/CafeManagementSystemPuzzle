namespace CafeManagementSystem
{
    partial class tableWindow
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
            this.chairsDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.floorDD = new System.Windows.Forms.ComboBox();
            this.tableNumberDD = new System.Windows.Forms.ComboBox();
            this.detailsbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChairsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.tableNumberDD);
            this.leftPanel.Controls.Add(this.floorDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.chairsDD);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(250, 519);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.chairsDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.floorDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.tableNumberDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsbox);
            this.rightPanel.Size = new System.Drawing.Size(683, 519);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint_1);
            this.rightPanel.Controls.SetChildIndex(this.detailsbox, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Table Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. Of Chairs ";
            // 
            // chairsDD
            // 
            this.chairsDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chairsDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chairsDD.FormattingEnabled = true;
            this.chairsDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.chairsDD.Location = new System.Drawing.Point(15, 205);
            this.chairsDD.Name = "chairsDD";
            this.chairsDD.Size = new System.Drawing.Size(212, 23);
            this.chairsDD.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = " Floor # ";
            // 
            // floorDD
            // 
            this.floorDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floorDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.floorDD.FormattingEnabled = true;
            this.floorDD.Items.AddRange(new object[] {
            "1",
            "2"});
            this.floorDD.Location = new System.Drawing.Point(15, 271);
            this.floorDD.Name = "floorDD";
            this.floorDD.Size = new System.Drawing.Size(212, 23);
            this.floorDD.TabIndex = 7;
            // 
            // tableNumberDD
            // 
            this.tableNumberDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableNumberDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tableNumberDD.FormattingEnabled = true;
            this.tableNumberDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.tableNumberDD.Location = new System.Drawing.Point(12, 140);
            this.tableNumberDD.Name = "tableNumberDD";
            this.tableNumberDD.Size = new System.Drawing.Size(212, 23);
            this.tableNumberDD.TabIndex = 8;
            // 
            // detailsbox
            // 
            this.detailsbox.Controls.Add(this.dataGridView1);
            this.detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.detailsbox.Location = new System.Drawing.Point(0, 54);
            this.detailsbox.Name = "detailsbox";
            this.detailsbox.Size = new System.Drawing.Size(683, 465);
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
            this.floorIDGV,
            this.floorNameGV,
            this.tableidGV,
            this.TableNumberGV,
            this.ChairsGV});
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 423);
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
            // tableidGV
            // 
            this.tableidGV.HeaderText = "TableID";
            this.tableidGV.Name = "tableidGV";
            this.tableidGV.ReadOnly = true;
            this.tableidGV.Visible = false;
            // 
            // TableNumberGV
            // 
            this.TableNumberGV.HeaderText = "Table Number";
            this.TableNumberGV.Name = "TableNumberGV";
            this.TableNumberGV.ReadOnly = true;
            // 
            // ChairsGV
            // 
            this.ChairsGV.HeaderText = "Chairs";
            this.ChairsGV.Name = "ChairsGV";
            this.ChairsGV.ReadOnly = true;
            // 
            // tableWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "tableWindow";
            this.Text = "tableWindow";
            this.Load += new System.EventHandler(this.tableWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tableNumberDD;
        private System.Windows.Forms.ComboBox floorDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chairsDD;
        private System.Windows.Forms.GroupBox detailsbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumberGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChairsGV;
    }
}