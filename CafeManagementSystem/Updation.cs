using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace CafeManagementSystem
{
   public class Updation
    {
        public static void updateMenuItem(int menuID ,string menuItem, float price, int catID, Int16 status, Image im)
        {
            try
            {
                MemoryStream ms = new MemoryStream ();
                im.Save(ms, ImageFormat.Png);
                byte[] arr = ms.ToArray();

                SqlCommand cmd = new SqlCommand("st_updateMenuItem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", menuItem);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@mid", menuID);
                cmd.Parameters.AddWithValue("@image", arr);


                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(menuItem + "updated successfully into the system", "Success");

                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update menu.\nPossible error: \n menu may exist already. \nContact technical support ", "Error");

            }
        }
            public static void updateCategory(int id, string category)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", category);
                cmd.Parameters.AddWithValue ("id", id);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0) 
                {
                    MainClass.showMessage(category + "updated sucessfully into the system", "success");

                }

            }
            catch(Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage(category + "Unable to update Category.\nPossible error: \n Category may exist already. \nContact technical support ", "error");

            }
        }
        public static void updateTable(int tableId,int tableNUmber, Int16 chairs, Int16 floorID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tableNUmber);
                cmd.Parameters.AddWithValue("@chairs", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                cmd.Parameters.AddWithValue("@tableID", tableId);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(tableNUmber + " updates Successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update tables.\nPossible error : \n table may exist already. \nContact technical support", "error");
            }
        }
        public static void updateFloors(Int16 floorID,string name, Int16 number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floorNumber", number);
                cmd.Parameters.AddWithValue("@floorID", floorID);
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
                MainClass.showMessage("Unable to update floor.\nPossible error : \n Floor may exist already. \nContact technical support", "error");
            }
        }
        public static void updateCustomer(Int64 cid, string name, string phone, string address)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@cID", cid);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " updated Successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update customer.\nPossible error : \n customer may exist already. \nContact technical support", "error");
            }
        }
        public static void updateRole(string role,Int16 roleID) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                cmd.Parameters.AddWithValue("@rid", roleID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(role + "updated succesfully into the system", "success ");
                }


            }
            catch (Exception ex) 
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void updateUsers(int userID, string name, string uname, string pass, string address, string phone, Int16 roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roleID", roleID); 
                cmd.Parameters.AddWithValue("@userID", userID);



                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "updated Successfully into the system", "sucess");
                }

            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update user.\nPossible error :\nContact technical support", "error"  );
            }


        }

    }
}
