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
    public partial class HomeScreen2 : Sample
    {
        public HomeScreen2()
        {
            InitializeComponent();
        }

        private void foodmenuBtn_Click(object sender, EventArgs e)
        {
            menuwindow rw = new menuwindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            customersWindow rw = new customersWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            ordersWindow rw = new ordersWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginScreen rw = new LoginScreen();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
