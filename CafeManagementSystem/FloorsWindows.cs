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
    public partial class FloorsWindows : Sample2
    {
        public FloorsWindows()
        {
            InitializeComponent();
        }
        Int16 floorID;
        public override void button3_Click(object sender, EventArgs e)
        {
            if (MainClass.CheckControls(leftPanel).Count == 0)
            {
                if (edit == 0) //save 
                {
                    insertion.insertFloors(Floortxt.Text, Convert.ToInt16(FloorNumbeDD.SelectedItem.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);
                    if (MainClass.CheckControls(leftPanel).Count == 0)
                    {

                    }
                    else if (edit == 1) //update
                    {
                        Updation.updateFloors(floorID, Floortxt.Text, Convert.ToInt16(FloorNumbeDD.SelectedItem.ToString()));
                        MainClass.resetDisable(leftPanel);
                        Retreival.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);

                    }

                    else
                    {
                        MessageBox.Show("Please enter all required fields");
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
                    Deletion.deleteData("st_deleteFloor", "@floorID", 0, floorID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);


                }


            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void button5_Click_1(object sender, EventArgs e)
        {
            Retreival.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);


        }

        private void FloorsWindows_Load(object sender, EventArgs e)
        {

        }

        private void Floortxt_TextChanged(object sender, EventArgs e)
        {
            if (Floortxt.Text == "") { Floortxt.BackColor = Color.Firebrick; } else { Floortxt.BackColor = Color.White; }

        }

        private void FloorNumbeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FloorNumbeDD.SelectedIndex == -1) { FloorNumbeDD.BackColor = Color.Firebrick; } else { FloorNumbeDD.BackColor = Color.White; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControl(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                floorID = Convert.ToInt16(row.Cells["floorIDGV"].Value.ToString());
                Floortxt.Text = row.Cells["floorNameGV"].Value.ToString();
                FloorNumbeDD.SelectedItem = row.Cells["floorNumberGV"].Value.ToString();



            }
        }
    }
}