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
                    

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            mydb.UpdateDB(Users);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Users = mydb.AllUsersOrderBy("ID");
            dataGridView1.DataSource = Users;  
        }

       
    }
}
