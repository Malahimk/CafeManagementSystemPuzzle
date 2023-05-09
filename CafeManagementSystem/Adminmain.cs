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
    public partial class Adminmain : Sample
    {
        public Adminmain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rolesWindow rw = new rolesWindow();
            MainClass.showWindow(rw, this,MDI.ActiveForm);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            UsersWindow rw = new UsersWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            customersWindow rw = new customersWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void foodcategoriesBtn_Click(object sender, EventArgs e)
        {
            FoodCategories rw = new FoodCategories();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void foodmenuBtn_Click(object sender, EventArgs e)
        {
            menuwindow rw = new menuwindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void floorsBtn_Click(object sender, EventArgs e)
        {
            FloorsWindows rw = new FloorsWindows();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            ordersWindow rw = new ordersWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void tablesBtn_Click(object sender, EventArgs e)
        {
            tableWindow rw = new tableWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void billbtn_Click(object sender, EventArgs e)
        {
            OrderCompletionWindow rw = new OrderCompletionWindow();
            MainClass.showWindow (rw, this, MDI.ActiveForm);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
     

        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            LoginScreen rw = new LoginScreen();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
