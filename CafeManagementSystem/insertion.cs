using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace CafeManagementSystem
{
   public class insertion
    {
        public static int insertOrderDetails(Int64 orderID, int proID)
        {
            int res = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertOrderDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@proID", proID);
                
                MainClass.con.Open();
                res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
               
            }
            catch (Exception)
            {
                MainClass.con.Close();
                //MainClass.showMessage("Unable to save order", "Error");

            }
            return res;
        }
        public static void insertOrder(DateTime date,Int64 custID,Int16 orderType,Int16 floorID,Int16 tableID,float tamount,float amtpaid, float amtReturned, Int16 status)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_insertOrder", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date",date );
                cmd.Parameters.AddWithValue("@custID",custID );
                cmd.Parameters.AddWithValue("@orderType", orderType );
                cmd.Parameters.AddWithValue("@floorID", floorID );
                cmd.Parameters.AddWithValue("@tableID", tableID );
                cmd.Parameters.AddWithValue("@tAmount", tamount);
                cmd.Parameters.AddWithValue("@amtPaid", amtpaid);
                cmd.Parameters.AddWithValue("@amtReturned", amtReturned);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Order placed successfully...", "Success");

                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save order","Error");

            }
        }
        public static void insertMenuItem(string menuItem,float price,int catID,Int16 status, Image im)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                im.Save(ms, ImageFormat.Png);
                byte[] arr = ms.ToArray();
                SqlCommand cmd = new SqlCommand("st_insertMenuItem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", menuItem);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@image", arr);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(menuItem + "added successfully into the system", "Success");

                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save menu.\nPossible error: \n menu may exist already. \nContact technical support ", "Error");

            }
        }
        public static void insertCategory(string category)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", category);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0) 
                {
                    MainClass.showMessage(category + "added successfully into the system", "Success");

                }   
            }catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save Category.\nPossible error: \n Category may exist already. \nContact technical support ","Error");

            }
        }
        public static void insertTable(int tableNUmber,Int16 chairs,Int16 floorID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tableNUmber);
                cmd.Parameters.AddWithValue("@chairs", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(tableNUmber + " added Successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save tables.\nPossible error : \n table may exist already. \nContact technical support", "error");
            }
        }
        public static void insertFloors(string name, Int16 number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floorNumber", number);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " added Successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save floor.\nPossible error : \n Floor may exist already. \nContact technical support", "error");
            }
        }
        public static void insertCustomer(string name, string phone, string address)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@phone",phone);
                cmd.Parameters.AddWithValue("@address",address);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " added Successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save customer.\nPossible error : \n customer may exist already. \nContact technical support", "error");
            }
        }
            public static void insertRole(string role)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(role + " added Successfully into the system","success");
                }
                

            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save role.\nPossible error : \n Role may exist already. \nContact technical support", "error");
            }


    }
        public static void insertUsers(string name,string uname,string pass,string address,string phone,Int16 roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roleID", roleID);


                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "added Successfully into the system", "sucess");
                }

            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save role.\nPossible error : \n Role may exist already. \nContact technical support", "error");
            }


        }

    }
}

