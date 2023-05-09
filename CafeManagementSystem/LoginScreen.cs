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
    public partial class LoginScreen : Sample
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (MainClass.CheckControls(leftPanel).Count == 0)
            {

                if (Retreival.isValidUser(usertxtBox.Text, passwordtxtbox.Text))
                {
                    if (Retreival.ROLE == "Manager")
                    {
                        Adminmain adm = new Adminmain();
                        MainClass.showWindow(adm, this, MDI.ActiveForm);
                    }
                    else if (Retreival.ROLE == "Staff")
                            
                    {
                        HomeScreen2 adm = new HomeScreen2();
                        MainClass.showWindow(adm, this, MDI.ActiveForm);
                    }
                }
                else
                {

                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (usertxtBox.Text == "") { usertxtBox.BackColor = Color.Firebrick; } else { usertxtBox.BackColor = Color.White;}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (passwordtxtbox.Text == "") { passwordtxtbox.BackColor = Color.Firebrick; } else { passwordtxtbox.BackColor = Color.White; }

        }
    }
}
    

