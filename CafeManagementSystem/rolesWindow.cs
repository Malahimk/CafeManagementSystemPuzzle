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
    public partial class rolesWindow : Sample2
    {
        public rolesWindow()
        {
            InitializeComponent();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.resetEnable(leftPanel);
            delStatus = 0;

        }

        public override void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.EnableControl(leftPanel);
            delStatus = 0;


        }



        public override void button3_Click(object sender, EventArgs e)
        {
            if(roletext.Text == "") { roleError.Visible = true; } else { roleError.Visible = false; }
            if (roleError.Visible)
            {
                MainClass.showMessage(" Field with * are mandatory", "Error");
            }
            else
            {
                if (edit == 0) // for save operation
                {
                    insertion.insertRole(roletext.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getRoles(dataGridView1, roleIDGV, roleNameGv);
                }
                else if (edit == 1) // for update operation
                {
                    Updation.updateRole(roletext.Text, roleID);
                    MainClass.resetEnable(leftPanel);
                    Retreival.getRoles(dataGridView1, roleIDGV, roleNameGv);
                }
                
            }

        }
        public override void button4_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Questions...",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteRole", "@rid", roleID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getRoles(dataGridView1, roleIDGV, roleNameGv);
                }
                { 
                    
                }
            }

        }
        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
        public override void button5_Click_1(object sender, EventArgs e)
        {
            Retreival.getRoles(dataGridView1,roleIDGV, roleNameGv);
        }




        private void rolesWindow_Load(object sender, EventArgs e)
        {   

        }

        private void roletext_TextChanged(object sender, EventArgs e)
        {
            if (roletext.Text == "") { roleError.Visible= true; } else { roleError.Visible= false; }
        }
        Int16 roleID;
        

        private void Datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus= 1;
                MainClass.DisableControl(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt16(row.Cells["roleIDGV"].Value.ToString());
                roletext.Text = row.Cells["roleNameGV"].Value.ToString();
            }
        }

        private void detailsbox_Enter(object sender, EventArgs e)
        {
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
