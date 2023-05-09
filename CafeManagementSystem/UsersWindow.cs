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
    public partial class UsersWindow : Sample2
    {
        public UsersWindow()
        {
            InitializeComponent();
        }

        private void UsersWindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("st_getRoles", rolesdropdown, "Role", "RoleID");
            rolesdropdown.SelectedIndex = -1;
            
        }

        private void rightPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            if (nametxt.Text == "") { nametxt.BackColor = Color.Firebrick; } else { nametxt.BackColor = Color.White; }

        }

        private void phonetxtBox_TextChanged(object sender, EventArgs e)
        {
            if (phonetxtBox.Text == "") { phonetxtBox.BackColor = Color.Firebrick; } else { phonetxtBox.BackColor = Color.White; }


        }

        private void adresstext_TextChanged(object sender, EventArgs e)
        {
            if (adresstext.Text == "") { adresstext.BackColor = Color.Firebrick; } else { adresstext.BackColor = Color.White; }


        }

        private void rolesdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolesdropdown.SelectedIndex == -1) { rolesdropdown.BackColor = Color.Firebrick; } else { rolesdropdown.BackColor = Color.White; }
        }
        int userID;
        public override void button3_Click(object sender, EventArgs e)
        {
            if (MainClass.CheckControls(leftPanel).Count == 0)
            {
                if (edit == 0) //save 
                {
                    insertion.insertUsers(nametxt.Text, usernametxt.Text, passwordtxt.Text, adresstext.Text, phonetxtBox.Text, Convert.ToInt16(rolesdropdown.SelectedValue.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, AddressGV, RoleIDGV, RoleNameGv);
                }
                else if (edit == 1) //update
                {
                    Updation.updateUsers(userID, nametxt.Text, usernametxt.Text, passwordtxt.Text, adresstext.Text, phonetxtBox.Text, Convert.ToInt16(rolesdropdown.SelectedValue.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, AddressGV, RoleIDGV, RoleNameGv);

                }

                else
                {
                    MessageBox.Show("Please enter all required fields");
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
                    Deletion.deleteData("st_deleteUsers", "@userID", userID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, AddressGV, RoleIDGV, RoleNameGv);

                }

            }

        }
        public override void button5_Click_1(object sender, EventArgs e)
        {
            Retreival.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, AddressGV, RoleIDGV, RoleNameGv);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControl(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt16(row.Cells["userIDGV"].Value.ToString());
                nametxt.Text = row.Cells["NameGV"].Value.ToString();
                usernametxt.Text = row.Cells["usernameGV"].Value.ToString();
                passwordtxt.Text = row.Cells["passGV"].Value.ToString();
                phonetxtBox.Text = row.Cells["phoneGV"].Value.ToString();
                adresstext.Text = row.Cells["addressGV"].Value.ToString();
                rolesdropdown.SelectedText = row.Cells["RoleNameGv"].Value.ToString();
            }

        }

        private void usertext_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "") { passwordtxt.BackColor = Color.Firebrick; } else { passwordtxt.BackColor = Color.White; }
        }
    }
}
