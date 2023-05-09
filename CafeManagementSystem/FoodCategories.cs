using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class FoodCategories : Sample2
    {
        public FoodCategories()
        {
            InitializeComponent();
        }
        int catID;
        private void FoodCategories_Load(object sender, EventArgs e)
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
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                categorytext.Text = row.Cells["catNameGV"].Value.ToString();


            }   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void categorytext_TextChanged(object sender, EventArgs e)
        {
            if (categorytext.Text == "") { categorytext.BackColor = Color.Firebrick; } else { categorytext.BackColor = Color.White; }

        }
        public override void button3_Click(object sender, EventArgs e)
        {
            if (MainClass.CheckControls(leftPanel).Count== 0) 
            {
                if (edit == 0) //Save
                {
                    insertion.insertCategory(categorytext.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategories(dataGridView1, catIDGV, catNameGV);
                    
                }
                else if (edit == 1) //update 
                {
                    Updation.updateCategory(catID, categorytext.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategories(dataGridView1, catIDGV, catNameGV);

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
                DialogResult dr = MessageBox.Show ("Are you sure you want to delete this record?","Question...",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteCategory","@id",catID );
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
            Retreival.getCategories(dataGridView1, catIDGV, catNameGV);
        }
    }
}
