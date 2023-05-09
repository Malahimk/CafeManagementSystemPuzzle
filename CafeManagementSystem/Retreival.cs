using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Drawing;

namespace CafeManagementSystem
{
  


   public class Retreival
    {
        public static Int64 lastOrderID()
        {
            Int64 orderID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastOrderId", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                orderID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception ) 
            {
                
            }
            return orderID;
            

        }
        private static string customer, address;

        public static string CUSTOMER
        {
            get { return customer; 
        }
            private set 
            { 
                customer = value; 
            }
        }
        public static string ADDRESS
        {
            get
            {
                return address;
            }
            private set
            {
                address = value;
            }
        }
        public static Int64 getCustomerIDWRTPhone(string phone)
        {
            Int64 custID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCustIdWRTPhone", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read()) 
                    {
                        custID = Convert.ToInt64(dr["CustomerID"].ToString());
                        CUSTOMER = dr["Name"].ToString();
                        ADDRESS = dr["Address"].ToString();


                    }
                }
                else
                {
                    custID = 0;
                    CUSTOMER= "";
                    ADDRESS = "";
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");

            }
            return custID;
        }
        public static void getMenu(DataGridView gv,
      DataGridViewColumn catIDGV,
      DataGridViewColumn catNameGV,
      DataGridViewColumn menuItemGV,
      DataGridViewColumn menuItemIDGV,
      DataGridViewColumn priceGV,
      DataGridViewColumn statusGV,
      DataGridViewColumn imageGV)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getMenu", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                menuItemGV.DataPropertyName = dt.Columns["Menu Item"].ToString();
                menuItemIDGV.DataPropertyName = dt.Columns["MenuID"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                imageGV.DataPropertyName = dt.Columns["Image"].ToString();











                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");


            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategories", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                









                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");


            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }


        public static void getTable(DataGridView gv, DataGridViewColumn floorIDGv, DataGridViewColumn floorNameGV,
        DataGridViewColumn tableNameGv,DataGridViewColumn tableidGV, DataGridViewColumn chairsGV     )

        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                floorIDGv.DataPropertyName = dt.Columns["FLoor ID"].ToString();
                floorNameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                tableNameGv.DataPropertyName = dt.Columns["Table Number"].ToString();
                tableidGV.DataPropertyName = dt.Columns["Table ID"].ToString();
                chairsGV.DataPropertyName = dt.Columns["Chairs"].ToString();









                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");


            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }

        public static void getFloors(DataGridView gv, DataGridViewColumn floorIDGv, DataGridViewColumn nameGV,
          DataGridViewColumn floorNumberGV)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                floorIDGv.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                floorNumberGV.DataPropertyName = dt.Columns["Floor Number"].ToString();
               








                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");


            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getCustomers(DataGridView gv, DataGridViewColumn custIDgv, DataGridViewColumn nameGV,
            DataGridViewColumn phoneGV, DataGridViewColumn addressGV)
            
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCustomers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                custIDgv.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Customer"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                







                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");


            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }

        public static void getRoles(DataGridView gv, DataGridViewColumn roleIDGV, DataGridViewColumn roleNameGv)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_getRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                roleIDGV.DataPropertyName = dt.Columns["RoleID"].ToString();
                roleNameGv.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV");

            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        private static string name;
        private static string role;

        public static string USER
        {
            get
            {
                return name;
            }
            private set
            {
                name= value;    
            }
        }

        public static string ROLE
        {
            get
            {
                return role;
            }
            private set
            {   
                role = value;   
            }
        }
        public static bool isValidUser(string user, string pass)
        {
            bool status = false;
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_getUsers4Auth", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user",user);
                cmd.Parameters.AddWithValue("@pass",pass);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (user == dr["Username"].ToString() && pass == dr["Password"].ToString())
                        {
                            USER = dr["User"].ToString();
                            ROLE = dr["Role"].ToString();
                            status= true;
                            
                        }
                          else
                         {
                            MainClass.showMessage("Invalid username or password", "Error");
                            status = false;
                        }
                       
                    }
                }
                else
                {
                    MainClass.showMessage("Invalid username or password", "Error");
                    status= false;

                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
            return status;
        }
         
        public static void getUsers(DataGridView gv, DataGridViewColumn userIDgv,
            DataGridViewColumn nameGV,DataGridViewColumn usernameGV, 
            DataGridViewColumn passGV, DataGridViewColumn phoneGV, DataGridViewColumn addressGV,
            DataGridViewColumn roleIDGV, DataGridViewColumn roleGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDgv.DataPropertyName = dt.Columns["User ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["User"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                roleIDGV.DataPropertyName = dt.Columns["Role ID"].ToString();
                roleGV.DataPropertyName = dt.Columns["Role"].ToString();







                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");


            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static Image getItemImage(int mid)
        {
            byte[] arr;
            Image i= null;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getItemimage", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", mid);
                MainClass.con.Open();
                arr = (byte[]) cmd.ExecuteScalar();
                MemoryStream ms = new MemoryStream(arr);
                i = Image.FromStream(ms);
                MainClass.con.Close();

            } 
            catch (Exception ex) 
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "error");
                
            }
            return i;
        }


        public static void loadItems(string proc, ComboBox cb, string dMember,string vMember,string param = null, int val = 0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType= CommandType.StoredProcedure;
                if (param == null && val == 0) 
                {
                    
                }
                else
                {
                    cmd.Parameters.AddWithValue(param, val);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource= dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //internal static void getUsers(DataGridView dataGridView1, DataGridViewTextBoxColumn userIDGV, DataGridViewTextBoxColumn nameGV, DataGridViewTextBoxColumn usernameGV, DataGridViewTextBoxColumn passGV, DataGridViewTextBoxColumn phoneGV, DataGridViewTextBoxColumn addressGV, object roleIDGV, object roleGV)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
