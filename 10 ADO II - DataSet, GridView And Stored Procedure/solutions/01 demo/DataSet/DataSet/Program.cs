using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace DataSetNS
{
    class Program
    {
        //string sqlCon = @"Data Source=MERCAZI-1\SQLSERVERR2;Initial Catalog=asp;Integrated Security=True";
        static void Main(string[] args)
        {
            string sqlCon = @"Data Source=MERCAZI-1\SQLSERVERR2;Initial Catalog=asp;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlCon);
            DataSet ds = new DataSet();
            string select = "SELECT * FROM tbUser ORDER BY NAME";
            SqlDataAdapter adtr = new SqlDataAdapter(select,con);
            adtr.Fill(ds, "users");

            DataTable usersTable = ds.Tables["users"];
            Console.WriteLine(usersTable.Rows[4][1]);

            //update
            usersTable.Rows[4][1] +=  "4";
            Console.WriteLine(usersTable.Rows[4][1]);
            
            //insert
            DataRow dr = usersTable.NewRow();
            dr["ID"] = 100;
            dr["Name"] = "nir100";
            dr["Family"] = "chen";
            usersTable.Rows.Add(dr);

            //delete
            //usersTable.Rows[4].Delete();

            foreach (DataRow item in usersTable.Rows)
            {
                Console.WriteLine("id:" + item[0] + " NAME:"+item[1] +" Family:"+ item[2]);
            }
            //adtr = new SqlDataAdapter(select, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adtr);
            adtr.Update(ds, "users");


        }
    }
}
