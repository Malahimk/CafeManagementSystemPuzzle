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
    public partial class tableWindow : Sample2
    {
        int tableID;
        public override void button3_Click(object sender, EventArgs e)
        {
            if (MainClass.CheckControls(leftPanel).Count == 0)
            {
                if (edit == 0) //save 
                {
                    insertion.insertTable(Convert.ToInt32(tableNumberDD.SelectedItem.ToString()), Convert.ToInt16(chairsDD.SelectedItem.ToString()), Convert.ToInt16(floorDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTable(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableidGV, ChairsGV);
                    if (MainClass.CheckControls(leftPanel).Count == 0)
                    {

                    }
                    else if (edit == 1) //update
                    {
                        Updation.updateTable(tableID, Convert.ToInt32(tableNumberDD.SelectedItem.ToString()), Convert.ToInt16(chairsDD.SelectedItem.ToString()), Convert.ToInt16(floorDD.SelectedValue.ToString()));
                        MainClass.resetDisable(leftPanel);
                        Retreival.getTable(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableidGV, ChairsGV);


                    }
                }

            }
        }
        public override void button4_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Questions...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteTables", "@tableID", 0, tableID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTable(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableidGV, ChairsGV);


                }

            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void button5_Click_1(object sender, EventArgs e)
        {
            Retreival.getTable(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableidGV, ChairsGV);

        }
        public tableWindow()
        {
            InitializeComponent();
        }

        private void tableWindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("st_getFloors", floorDD, "Floor", "ID");
            floorDD.SelectedIndex = -1;
        }

        private void rightPanel_Paint_1(object sender, PaintEventArgs e)
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
                tableID = Convert.ToInt32(row.Cells["tableidGV"].Value.ToString());
                tableNumberDD.SelectedItem = row.Cells["TableNumberGV"].Value.ToString();
                chairsDD.SelectedItem = row.Cells["chairsGV"].Value.ToString();
                floorDD.SelectedValue = row.Cells["floorIDGV"].Value;

            }

        }
    }
}
