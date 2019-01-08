using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    
    class DAL
    {

        string conStr = @"Data Source=LABM00;Initial Catalog=UsersDb;Integrated Security=True";
        SqlConnection con;
        SqlCommand com;

        public int InsertUser(string n, string f)
        {
             return ExecuteNonQ("INSERT INTO UsersTb(Name, Family) VALUES('" + n + "','" + f + "') ");
        }

        //public int UpdateUser(int i, string n, string f)
        //{
        //    return ExecuteNonQ("INSERT INTO UsersTb(Name, Family) VALUES('" + n + "','" + f + "') ");
        //}

        int  ExecuteNonQ(string SQLStr)
        {
            try
            {
                con = new SqlConnection(conStr);
                com = new SqlCommand(SQLStr, con);
                com.Connection.Open();
                int res = com.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("insert error " + ex.Message);
            }
            finally
            {
                com.Connection.Close();
            }

            return -1;
        }

        public int UpdateUser(int p1, string p2, string p3)
        {
            return ExecuteNonQ("UPDATE UsersTb SET Name='" + p2 + "' ,Family='"+p3+"' WHERE Id=" + p1);
        }
    }
}
