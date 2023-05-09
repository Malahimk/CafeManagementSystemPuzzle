using CafeManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class ordersWindow : Sample2
    {
        public ordersWindow()
        {
            InitializeComponent();
        }

        private void ordersWindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("st_getCategories", ordcatDD, "Category", "ID");
            ordcatDD.SelectedIndex = -1;
            Retreival.loadItems("st_getFloors", floororddd, "Floor", "ID");
            floororddd.SelectedIndex = -1;
            ordcatDD.BackColor = Color.White;
            floororddd.BackColor = Color.White;
            tableordDD.BackColor = Color.White;
            numericUpDown1.BackColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ordcatDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordcatDD.SelectedIndex != -1)
            {
                ordcatDD.BackColor = Color.White;   

                Retreival.loadItems("st_getMenuWRTCategory", itemdd, "Menu Item", "MenuID","@cid",Convert.ToInt32(ordcatDD.SelectedValue.ToString()));
                itemdd.SelectedIndex = -1;
                itemdd.BackColor = Color.White;
            }
            else
            {
                ordcatDD.BackColor = Color.Firebrick;
            }
        }
        
        private void itemdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemdd.SelectedIndex != -1)
            {
                try
                {
                    itemdd.BackColor = Color.White;
                    SqlCommand cmd = new SqlCommand("st_getPriceWRTItem", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(itemdd.SelectedValue.ToString()));
                    MainClass.con.Open();
                    priceordertxt.Text= Math.Round(Convert.ToDouble(cmd.ExecuteScalar().ToString()),0).ToString();
                    MainClass.con.Close();
                    Image i = Retreival.getItemImage(Convert.ToInt32(itemdd.SelectedValue.ToString()));
                    pictureBox1.Image = i;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex) 
                {
                    MainClass.con.Close();
                    MainClass.showMessage(ex.Message,"Error");
                }
        
            }
            else
            {
                priceordertxt.Text = "";
                priceordertxt.BackColor = Color.White;
                pictureBox1.Image = Resources.foodm;
                itemdd.BackColor = Color.Firebrick;
            }
        }

        private void floororddd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (floororddd.SelectedIndex != -1)
            {
                floororddd.BackColor = Color.White;
                Retreival.loadItems("st_getTableWRTFloor", tableordDD, "Table Number", "Table ID", "FloorID",Convert.ToInt32(floororddd.SelectedValue.ToString()));
                tableordDD.SelectedIndex = -1;
            }
            else
            {
                floororddd.BackColor = Color.Firebrick;
            }
        }

        private void ordtypDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordtypDD.SelectedIndex != -1) 
            {
                ordtypDD.BackColor = Color.White;
                if (ordtypDD.SelectedIndex == 0) 
                {
                    floororddd.Enabled = true;
                    tableordDD.Enabled = true;
                    custordphonetxt.Visible = false;
                    phonelabel.Visible = false;
                    floororddd.BackColor = Color.Firebrick;
                    tableordDD.BackColor = Color.Firebrick;
                    floororddd.BackColor = Color.Firebrick;
                    custordphonetxt.BackColor = Color.White;

                }
                else
                {
                    floororddd.Enabled = false;
                    tableordDD.Enabled = false;
                    custordphonetxt.Visible = true;
                    phonelabel.Visible = true;
                    floororddd.BackColor = Color.White;
                    tableordDD.BackColor = Color.White;
                    custordphonetxt.BackColor = Color.Firebrick;


                }
            }
            else 
            {
                ordtypDD.BackColor = Color.Firebrick;
            }
        }

        private void phonelabel_Click(object sender, EventArgs e)
        {

        }
        float totalAmount = 0;
        private void cartbtn_Click(object sender, EventArgs e)
        {
            if (MainClass.CheckControls(leftPanel).Count != 0)
            {
                MainClass.showMessage("Field with red are mandatory.", "Error");
            }
            else
            {
                bool check = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["itemIDGV"].Value == itemdd.SelectedValue)
                    {
                        check = true;
                        break;
                    }
                }
                DataRowView drvFloor = floororddd.SelectedItem as DataRowView;
                DataRowView drvTable = tableordDD.SelectedItem as DataRowView;
                DataRowView drvItem = itemdd.SelectedItem as DataRowView;
                DataRowView drvCat = ordcatDD.SelectedItem as DataRowView;
                if (check)
                {
                    MainClass.showMessage("Item added Already", "Error");
                }
                else
                {




                    if (ordtypDD.SelectedIndex == 0)
                    {

                        totalAmount += Convert.ToSingle(priceordertxt.Text)*Convert.ToSingle(numericUpDown1.Value);
                        totallabel.Text = totalAmount.ToString();
                       
                        dataGridView1.Rows.Add(null, Convert.ToInt32(tableordDD.SelectedValue.ToString()),
                            Convert.ToInt32(floororddd.SelectedValue.ToString()),
                            Convert.ToInt32(ordcatDD.SelectedValue.ToString()), drvCat["Category"],
                            Convert.ToInt32(itemdd.SelectedValue.ToString()),
                            drvItem["Menu Item"],
                            Convert.ToSingle(priceordertxt.Text),
                            Convert.ToInt32(numericUpDown1.Text),
                            ordtypDD.SelectedItem.ToString(),
                            drvFloor["Floor"], drvTable["Table Number"],
                            tableordDD.SelectedItem.ToString(),
                            null);

                    }   
                    else if (ordtypDD.SelectedIndex == 1 || ordtypDD.SelectedIndex == 2)
                    {
                        totalAmount += Convert.ToSingle(priceordertxt.Text) * Convert.ToSingle(numericUpDown1.Value);
                        amountlabel.Text = totalAmount.ToString();



                        dataGridView1.Rows.Add(null, null, null,
                           Convert.ToInt32(ordcatDD.SelectedValue.ToString()), drvCat["Category"],
                           Convert.ToInt32(itemdd.SelectedValue.ToString()),
                           drvItem["Menu Item"],
                           Convert.ToSingle(priceordertxt.Text),
                           Convert.ToInt32(numericUpDown1.Text),
                           ordtypDD.SelectedItem.ToString(),
                           null,
                           null, custordphonetxt.Text);

                    }
                }
                
            }
            MainClass.sno(dataGridView1, "snoGV");
        }

        private void priceordertxt_TextChanged(object sender, EventArgs e)
        {
            if (priceordertxt.Text != "") { priceordertxt.BackColor = Color.White; } else { priceordertxt.BackColor = Color.Firebrick; }
        }

        private void tableordDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableordDD.SelectedIndex !=-1) { tableordDD.BackColor = Color.White; } else { tableordDD.BackColor = Color.Firebrick; }

        }
        Int64 custID;
        private void custordphonetxt_TextChanged(object sender, EventArgs e)
        {
            if (custordphonetxt.Text != "") 
            { 
                custordphonetxt.BackColor = Color.White;
               
            } else { custordphonetxt.BackColor = Color.Firebrick; }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0) 
            {
                numericUpDown1.BackColor = Color.Firebrick;
            }
            else
            {
                numericUpDown1.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 13) 
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    float prc = Convert.ToSingle(row.Cells["priceGV"].Value.ToString()) * Convert.ToSingle(numericUpDown1.Value);
                    totalAmount -= prc;
                    amountlabel.Text = totalAmount.ToString();
                    dataGridView1.Rows.Remove(row);
                    MainClass.sno(dataGridView1, "snoGV");

                }
            }
        }
        private void InsertOrderDetails()
        {
            Int64 orderID = Retreival.lastOrderID();
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               count += insertion.insertOrderDetails(orderID, Convert.ToInt32(row.Cells["itemIDGV"].Value));
                
            }
            if (count > 0)
            {
                MainClass.showMessage("Order Placed Generated Bill", "success");
            }
            else
            {
                MainClass.showMessage("Error Occured", "success");
            }


        }
        public override void button3_Click(object sender, EventArgs e)
        {
            using (TransactionScope sc = new TransactionScope())
            {
                try
                {
                    if (ordtypDD.SelectedIndex== 0) 
                    {
                      insertion.insertOrder(DateTime.Today,1, Convert.ToInt16(ordtypDD.SelectedIndex),Convert.ToInt16(floororddd.SelectedValue.ToString()),Convert.ToInt16(tableordDD.SelectedValue.ToString()),Convert.ToSingle(totallabel.Text), 0, 0, Convert.ToInt16(statusdd.SelectedIndex));
                        InsertOrderDetails();                           
                    }
                    else 
                    {
                        insertion.insertOrder(DateTime.Today,custID, Convert.ToInt16(ordtypDD.SelectedIndex),0,0,Convert.ToSingle(amountlabel.Text), 0, 0, Convert.ToInt16(statusdd.SelectedIndex));
                        InsertOrderDetails();
                        
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                    
                }
                sc.Complete();
            }
        }
        
        public override void button4_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void custordphonetxt_Leave(object sender, EventArgs e)
        {
            if (custordphonetxt.Text != "")
            {       
                custordphonetxt.BackColor = Color.White;
                custID = Retreival.getCustomerIDWRTPhone(custordphonetxt.Text);
                if (custID == 0) 
                {
                    customersWindow cw = new customersWindow();
                    MainClass.showWindow(cw, this, MDI.ActiveForm);
                }
                else
                {
                    MainClass.showMessage(Retreival.CUSTOMER + "\n" + Retreival.ADDRESS + "\n", "success");
                }
            }
            


        }

        private void amountlabel_Click(object sender, EventArgs e)
        {

        }
    }
}