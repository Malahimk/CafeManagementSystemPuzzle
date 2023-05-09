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
    public partial class customersWindow : Sample2
    {
        public customersWindow()
        {
            InitializeComponent();
        }
        public override void button3_Click(object sender, EventArgs e)
        {
            if (MainClass.CheckControls(leftPanel).Count == 0)
            {
                if (edit == 0) //save 
                {
                    insertion.insertCustomer(nametext.Text, phonetext.Text, addresstext.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCustomers(dataGridView1, custIDGV, NameGV, phoneGV, AddressGV);

                }
                else if (edit == 1) //update
                {
                    Updation.updateCustomer(custID, nametext.Text,addresstext.Text, phonetext.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCustomers(dataGridView1, custIDGV, NameGV, phoneGV, AddressGV);

                }

                else
                {
                    MessageBox.Show("Please enter all required fields");
                }
            }
        }
        Int64 custID;
        public override void button4_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Questions...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteCustomer", "@cID",0, custID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCustomers(dataGridView1, custIDGV, NameGV,phoneGV, AddressGV);

                }

            }

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void button5_Click_1(object sender, EventArgs e)
        {
            Retreival.getCustomers(dataGridView1, custIDGV, NameGV, phoneGV, AddressGV);

        }
        private void customersWindow_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {
            if (nametext.Text =="") { nametext.BackColor= Color.Firebrick; } else { nametext.BackColor= Color.White ;}
        }

        private void phonetext_TextChanged(object sender, EventArgs e)
        {
            if (phonetext.Text == "") { phonetext.BackColor = Color.Firebrick; } else { phonetext.BackColor = Color.White; }

        }

        private void addresstext_TextChanged(object sender, EventArgs e)
        {
            if (addresstext.Text == "") { addresstext.BackColor = Color.Firebrick; } else { addresstext.BackColor = Color.White; }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControl(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                custID = Convert.ToInt16(row.Cells["custIDGV"].Value.ToString());
                nametext.Text = row.Cells["NameGV"].Value.ToString();
                phonetext.Text = row.Cells["phoneGV"].Value.ToString();
                addresstext.Text = row.Cells["addressGV"].Value.ToString();
                
            }

        }
    }
}
