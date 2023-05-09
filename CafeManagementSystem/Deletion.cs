using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CafeManagementSystem
{
  public class Deletion
    {
        public static void deleteData(string procedure,string param, int value1 = 0, Int64 value2 = 0)
        {
            try
            {   
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (value1 != 0)
                {
                    cmd.Parameters.AddWithValue(param, value1);

                }
                else if (value2 != 0) 
                {
                    cmd.Parameters.AddWithValue(param, value2);

                }
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Data Deleted sucessfully from the system", "Sucess");

                }

            }
            catch(Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");


            }

        }

    }
}
