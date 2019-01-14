using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stored_Procedure
{
    public partial class Form1 : Form
    {
        //string conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + @"C:\לימודים\מתרגל\ruppin\ruppin 2013\ruppin 2013 II\09 ADO II - DataSet, GridView And Stored Procedure\db\asp.mdf" + @";Integrated Security=True;Connect Timeout=30;User Instance=True";
        //private SqlConnection myCon = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + @"C:\לימודים\מתרגל\ruppin\ruppin 2013\ruppin 2013 II\09 ADO II - DataSet, GridView And Stored Procedure\db\asp.mdf" + @";Integrated Security=True;Connect Timeout=30;User Instance=True");

        string conString = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=asp;Integrated Security=True";
        private SqlConnection myCon = new System.Data.SqlClient.SqlConnection(@"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=asp;Integrated Security=True");
        //private SqlConnection myCon2 ;

        //private SqlDataReader myReader = new SqlDataReader() ;
        private SqlCommand mycomm = new SqlCommand();
        private SqlDataAdapter adpt1;
        private SqlCommandBuilder SqlCommandBuilder1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void RefreshWindow()
        {
            adpt1 = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tbUser ORDER BY ID", conString);
            ds1.Clear();
            adpt1.Fill(ds1, "T1");
            DataGridView1.DataSource = ds1.Tables[0];
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            switch (((Button)(sender)).Name.ToString())
            {
                case "btnInsert":
                    mycomm.CommandText = "INSERT INTO tbUser(Name,Family) VALUES('" + txtName.Text + "', '" + txtFamily.Text + "')";
                    break;
                case "btnDelete":
                    mycomm.CommandText = "DELETE tbUser WHERE ID=" + txtID.Text;
                    break;
                case "btnUpdate":
                    mycomm.CommandText = "UPDATE tbUser SET Name='" + txtName.Text +
                    "' , Family='" + txtFamily.Text + "' where ID=" + txtID.Text;
                    break;
            }

            mycomm.Connection = myCon;
            myCon.Open();
            mycomm.ExecuteNonQuery();
            myCon.Close();
            RefreshWindow();

        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            adpt1 = new SqlDataAdapter("SELECT * FROM tbUser ORDER BY ID", conString);
            SqlCommandBuilder1 = new SqlCommandBuilder(adpt1); //builds automatically commands
            adpt1.Update(ds1, "T1");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mycomm.CommandText = "UPDATE tbUser SET Name=@txtName, Family=@txtFamily WHERE ID=@txtID";
            mycomm.Parameters.Add(new SqlParameter("@txtName", txtName.Text));
            mycomm.Parameters.Add(new SqlParameter("@txtFamily", txtFamily.Text));
            mycomm.Parameters.Add(new SqlParameter("@txtID", txtID.Text));

            mycomm.Connection = myCon;
            myCon.Open();
            mycomm.ExecuteNonQuery();
            myCon.Close();
            RefreshWindow();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            myCon.Open();
            SqlCommand MySPCommand = new SqlCommand("SearchUser", myCon);
            MySPCommand.CommandType = CommandType.StoredProcedure;
            
            SqlParameter parID = new SqlParameter("@MyID", SqlDbType.Int);
            parID.Value = int.Parse(txtID.Text);
            parID.Direction = ParameterDirection.Input;
            
            SqlParameter parFN = new SqlParameter("@FamilyName", SqlDbType.VarChar, 20);
            parFN.Direction = ParameterDirection.Output;
            
            SqlParameter returnValue = new SqlParameter();
            returnValue.Direction = ParameterDirection.ReturnValue;

            MySPCommand.Parameters.Add(parID);
            MySPCommand.Parameters.Add(parFN);
            MySPCommand.Parameters.Add(returnValue);
            MySPCommand.ExecuteNonQuery();
            myCon.Close();

            if ((int)returnValue.Value == 0)
                MessageBox.Show("Succeeded! \nthe family name is :  " + parFN.Value);
            else
                MessageBox.Show("Failed! ERROR- " + returnValue.Value);

        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            //DataSet tblEmployees = new DataSet();

            //myCon.Open();
            SqlCommand MySPCommand = new SqlCommand("SearchUserTable", myCon);
            MySPCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter parID = new SqlParameter("@MyID", SqlDbType.Int);
            parID.Value = int.Parse(txtID.Text);
            parID.Direction = ParameterDirection.Input;
            MySPCommand.Parameters.Add(parID);
            
            adpt1 = new SqlDataAdapter(MySPCommand);
            ds1.Clear();
            adpt1.Fill(ds1, "T2");
            //myCon.Close();
            DataGridView1.DataSource = ds1.Tables["T2"];
            
        }

    }
}