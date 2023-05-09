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
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        public void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sample_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Welcome  " + Retreival.USER;
        }
    }
}
