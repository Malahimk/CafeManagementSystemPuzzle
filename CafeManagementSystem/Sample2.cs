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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {

        }
        public static int edit = 0;
        public static int delStatus = 0;

        public virtual void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.resetEnable(leftPanel);
            delStatus = 0;

        }

        public virtual void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.EnableControl(leftPanel);
            delStatus = 0;


        }


        private void rightPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
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



            //Adminmain adm = new Adminmain();
            //MainClass.showWindow(adm,MDI.ActiveForm);
        }

        public virtual void button3_Click(object sender, EventArgs e)
        {

        }

        public virtual void button4_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
