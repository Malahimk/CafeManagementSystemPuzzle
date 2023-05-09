using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem
{
    public partial class menuwindow : Sample2
    {
        public menuwindow()
        {
            InitializeComponent();
        }
        int menuId;
        public override void button3_Click(object sender, EventArgs e)
        {
            if (MainClass.CheckControls(leftPanel).Count == 0)
            {
                short status = statusDD.SelectedItem.ToString() == "Available" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                if (edit == 0) //Save
                {
      
                    insertion.insertMenuItem(menuItemtxt.Text,Convert.ToSingle(pricetxt.Text),Convert.ToInt32(catDD.SelectedValue.ToString()),status,pictureBox1.Image);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getMenu(dataGridView1, catIDGV,catNameGV,MenuitemGV,menuIDGV,priceGV,statusGV, imageGv);

                }
                else if (edit == 1) //update 
                {
                    Updation.updateMenuItem(menuId,menuItemtxt.Text, Convert.ToSingle(pricetxt.Text), Convert.ToInt32(catDD.SelectedValue.ToString()), status,pictureBox1.Image);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getMenu(dataGridView1, catIDGV, catNameGV, MenuitemGV, menuIDGV, priceGV, statusGV,imageGv);

                }
            }
            else
            {
                MessageBox.Show("Please enter all required fields.");
            }

        }

        public override void button4_Click(object sender, EventArgs e)
        {

            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteMenuItem", "@mid", menuId);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategories(dataGridView1, catIDGV, catNameGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void button5_Click_1(object sender, EventArgs e)
        {
            Retreival.getMenu(dataGridView1, catIDGV, catNameGV, MenuitemGV, menuIDGV, priceGV, statusGV,imageGv);

        }

        private void menuwindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("st_getCategories", catDD, "Category", "ID");
            catDD.SelectedIndex = -1;
        }

        private void leftPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControl(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                menuId = Convert.ToInt32(row.Cells["menuIDGV"].Value.ToString());
                catDD.SelectedValue = row.Cells["catIDGV"].Value.ToString();
                menuItemtxt.Text = row.Cells["MenuItemGV"].Value.ToString();
                pricetxt.Text = row.Cells["priceGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();

                


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK) 
            {
                Image im = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = im;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void catDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
