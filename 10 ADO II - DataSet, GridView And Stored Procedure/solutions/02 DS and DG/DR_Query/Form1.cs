using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DR_NoneQuery
{
    public partial class Form1 : Form
    {
        //string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + @"C:\לימודים\מתרגל\ruppin\ruppin 2013\ruppin 2013 II\08 ADO I - DataReader\db\asp.mdf" + @";Integrated Security=True;Connect Timeout=30;User Instance=True";
        string connectionString = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=asp;Integrated Security=True";
        DB mydb;
        DataTable Users;

        public Form1()
        {
            InitializeComponent();
            mydb = new DB(connectionString);
        }

       

        private void Select_Click(object sender, EventArgs e)
        {
            string order = ""; ;
            if (rbt_ID.Checked){order = "ID";}
            else if (rbt_Name.Checked){order = "Name";}
            else if (rbt_Family.Checked){order = "Family";}

            Users = mydb.AllUsersOrderBy(order);
            dataGridView1.DataSource = Users;            
        }

        private void btnCapital_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
			    if(dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    Users.Rows[i][1] = Users.Rows[i][1].ToString().ToUpper();
                   
                }
			}
            dataGridView1.DataSource = Users;
            mydb.UpdateDB(Users);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mydb.UpdateDB(Users);
        }

        private void btnParam_Click(object sender, EventArgs e)
        {
            Users = mydb.SelectByParam(txtSel.Text);
            dataGridView1.DataSource = Users;    
        }

       
    }
}
