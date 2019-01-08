using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DR_NoneQuery
{
    class DB
    {
        //string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+@"C:\לימודים\מתרגל\ruppin\ruppin 2013\ruppin 2013 II\08 ADO I - DataReader\db\asp.mdf"+@";Integrated Security=True;Connect Timeout=30;User Instance=True";
        //string connectionString = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=asp;Integrated Security=True";
        SqlConnection con;
        //SqlCommand cmd;
        public DB(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }


        public DataTable ExcQuery(string command)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adptr = new SqlDataAdapter(command, con);
                adptr.Fill(ds,"t1"); //opens and closes the DB!
                return ds.Tables["t1"];
            }
            catch (Exception exp)
            {
                throw new Exception("DB ERROR " + exp.Message);
            }
            finally
            {
                //cmd.Connection.Close(); no need!
            }
        }

        public DataTable AllUsersOrderBy(string orderBy)
        {
            string cmd = "SELECT * FROM tbUser ORDER BY "+ orderBy +" ";
            return ExcQuery(cmd);        
        }


        //DOES NOT WORK!!! can't use parameter on ORDER BY!
        public DataTable AllUsersOrderByParam(string orderBy)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbUser ORDER BY @orderBy", con);
                cmd.Parameters.Add(new SqlParameter("@orderBy",orderBy));
                //string cmd = "SELECT * FROM tbUser ORDER BY " + orderBy + " ";
                DataSet ds = new DataSet();
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                adptr.Fill(ds, "t1"); //opens and closes the DB!
                return ds.Tables["t1"];
            }
            catch (Exception exp)
            {
                throw new Exception("DB ERROR " + exp.Message);
            }
        }


        public DataTable SelectByParam(string userID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbUser WHERE ID=@UserID", con);
                cmd.Parameters.Add(new SqlParameter("@UserID" , userID));
                //string cmd = "SELECT * FROM tbUser ORDER BY " + orderBy + " ";
                DataSet ds = new DataSet();
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                adptr.Fill(ds, "t1"); //opens and closes the DB!
                return ds.Tables["t1"];
            }
            catch (Exception exp)
            {
                throw new Exception("DB ERROR " + exp.Message);
            }
        }


        public void UpdateDB(DataTable t)
        {
            string cmd = "SELECT * FROM tbUser";
            SqlDataAdapter adptr = new SqlDataAdapter(cmd, con);
            SqlCommandBuilder comb = new SqlCommandBuilder(adptr); //must be coded!
            adptr.Update(t); //opens and closes the DB!
        }
        
    }
}
