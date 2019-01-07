using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=LAB-400;Initial Catalog=UsersDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            SqlCommand com = new SqlCommand("INSERT INTO UsersTB(Name, Family) VALUES('Dora','Bora')", con);
            int res = com.ExecuteNonQuery();
            MessageBox.Show("res="+ res);

            con.Close();



        }
    }
}
