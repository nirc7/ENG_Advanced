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
        static int TIMES = 1000;
        //string sqlCon = @"Data Source=MERCAZI-1\SQLSERVERR2;Initial Catalog=asp;Integrated Security=True";
        static void Main(string[] args)
        {
            string sqlCon = @"Data Source=LAB400\SQLR22008;Initial Catalog=asp;Integrated Security=True";
            //string sqlCon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + @"F:\1קורסים\2014\ruppin eng\Lectures\Part II - Advanced C#\13 LINQ\DataSet\db\asp.mdf" + @";Integrated Security=True;Connect Timeout=30;User Instance=True";


            SqlConnection con = new SqlConnection(sqlCon);
            DataSet ds = new DataSet();
            string select = "SELECT * FROM tbUser ORDER BY NAME";
            SqlDataAdapter adtr = new SqlDataAdapter(select,con);
            adtr.Fill(ds, "users");

            
            Console.WriteLine("____LINQ________");
            DataTable usersTableLinq = ds.Tables["users"];
            
            var users = from user in usersTableLinq.AsEnumerable()
                        select user;

            foreach (var item in users)
            {
                Console.WriteLine(item[0]);
            }

            Console.WriteLine("\n____LINQ BIG 10________\n");
            var usersBig10 = from user in usersTableLinq.AsEnumerable()
                             //where (int)user[0] >= 10  
                             where user.Field<int>("ID") >= 10 
                             select user;

            foreach (var item in usersBig10)
            {
                Console.WriteLine(item.Field<int>("ID") + " - "+  item["Family"].ToString()  );
            }

            //DataTable usersTable = ds.Tables["users"];
            //Console.WriteLine(usersTable.Rows[4][1]);

            ////update
            //usersTable.Rows[4][1] +=  "4";
            //Console.WriteLine(usersTable.Rows[4][1]);
            
            ////insert
            //DataRow dr = usersTable.NewRow();
            //dr["ID"] = 100;
            //dr["Name"] = "nir100";
            //dr["Family"] = "chen";
            //usersTable.Rows.Add(dr);

            ////delete
            ////usersTable.Rows[4].Delete();

            //foreach (DataRow item in usersTable.Rows)
            //{
            //    Console.WriteLine("id:" + item[0] + " NAME:"+item[1] +" Family:"+ item[2]);
            //}
            ////adtr = new SqlDataAdapter(select, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adtr);
            //adtr.Update(ds, "users");

            RunManyLinq(sqlCon); 
            RunManySQL(sqlCon);
        }

        private static void RunManySQL(string sqlCon)
        {
            
            SqlConnection con = new SqlConnection(sqlCon);
            DataSet ds = new DataSet();
            
            Console.WriteLine("____SQL________");
            DateTime start = DateTime.Now;
            int num;
            for (int i = 0; i < TIMES; i++)
            {
                string select = "SELECT * FROM tbUser WHERE ID >="+ (i%20) +" ORDER BY NAME";
                SqlDataAdapter adtr = new SqlDataAdapter(select, con);
                adtr.Fill(ds, "users");

                num = (int)ds.Tables["users"].Rows[0][0];
            }
            DateTime end = DateTime.Now;
            Console.WriteLine(end - start);
        }

        private static void RunManyLinq(string sqlCon)
        {
            
            SqlConnection con = new SqlConnection(sqlCon);
            DataSet ds = new DataSet();
            string select = "SELECT * FROM tbUser ORDER BY NAME";


            Console.WriteLine("____LINQ________");
            DateTime start = DateTime.Now;
            SqlDataAdapter adtr = new SqlDataAdapter(select, con);
            adtr.Fill(ds, "users");            
            
            DataTable usersTableLinq = ds.Tables["users"];
            int num;
            for (int i = 0; i < TIMES; i++)
			{
                var users = from user in usersTableLinq.AsEnumerable()
                            where user.Field<int>("ID") >= i%20
                            orderby user.Field<string>("Name")
                            select user;

                foreach (var item in users)
                {
                    num = (int)item[0];
                }
            }

            DateTime end = DateTime.Now;
            Console.WriteLine(end-start);

        }
    }
}
