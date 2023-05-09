using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace CafeManagementSystem
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void serverTxt_TextChanged(object sender, EventArgs e)
        {
            if (serverTxt.Text == "") { serverError.Visible = true; } else { serverError.Visible = false; }
        }

        private void databaseTxt_TextChanged(object sender, EventArgs e)
        {
            if (databaseTxt.Text == "") { databaseError.Visible = true; } else { databaseError.Visible = false; }
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (!inCB.Checked)
            {
                if (userTxt.Text == "") { userError.Visible = true; } else { userError.Visible = false; }
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!inCB.Checked)
            {
                if (passwordTxt.Text == "") { passwordError.Visible = true; } else { passwordError.Visible = false; }
            }
        }

        private void inCB_CheckedChanged(object sender, EventArgs e)
        {
            if (inCB.Checked)
            {
                userError.Visible = false;
                passwordError.Visible = false;
                userTxt.Enabled= false;
                passwordTxt.Enabled= false;
                userTxt.Text = "";
                passwordTxt.Text = "";    
            }
            else
            {
                userTxt.Enabled = true;
                passwordTxt.Enabled = true;

            }
         }
        public void updateConfigFile(string con)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in xmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");

        }

        string connection;

        private void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            File.WriteAllText(path, connection);
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(inCB.Checked)
            {
                if (serverTxt.Text == "") { serverError.Visible = true; } else { serverError.Visible = false; }
                if (databaseTxt.Text == "") { databaseError.Visible = true; } else { databaseError.Visible = false; }
                if (serverError.Visible || databaseError.Visible)
                {
                    MainClass.showMessage("fields with * are mandatory.", "Error");
                }
                else
                {
                    connection = "Data Source=" + serverTxt.Text +
                        ";Initial Catalog=" + databaseTxt.Text + 
                        ";Integrated Security=true;MultipleActiveResultSets= true;";
                    saveConnection();
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully.");
                    if (dr == DialogResult.OK) 
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);

                    }
                    
                   


                }
            }
            else
            {
                if (serverTxt.Text == "") { serverError.Visible = true; } else { serverError.Visible = false; }
                if (databaseTxt.Text == "") { databaseError.Visible = true; } else { databaseError.Visible = false; }
                if (userTxt.Text == "") { userError.Visible = true; } else { userError.Visible = false; }
                if (passwordTxt.Text == "") { passwordError.Visible = true; } else { passwordError.Visible = false; }
                if (serverError.Visible || databaseError.Visible || userError.Visible || passwordError.Visible )
                {
                    MainClass.showMessage("fields with * are mandatory.", "Error");
                }
                else
                {
                    connection = "Data Source=" + serverTxt.Text +
                        ";Intial Catalog=" + databaseTxt.Text +
                        ";User ID=" + userTxt.Text + ";Password=" + passwordTxt.Text + ";MultipleActiveResultSets= true";
                    updateConfigFile(connection);
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully.");
                    if (dr == DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }



                }
            }
        }
    }
}
