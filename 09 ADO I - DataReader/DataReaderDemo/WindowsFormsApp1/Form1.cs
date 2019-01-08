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
        string conStr = @"Data Source=LAB-400;Initial Catalog=UsersDB;Integrated Security=True";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcNonQ("INSERT INTO UsersTB(Name, Family) VALUES('"+txtName.Text+"','"+txtFamily.Text+"')");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcNonQ($"UPDATE UsersTB SET Name='{txtName.Text}' , Family='{txtFamily.Text}' WHERE Id={txtID.Text}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcNonQ("DELETE UsersTB WHERE Id=" + txtID.Text);
        }

        private void ExcNonQ(string commndStr)
        {
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand com = new SqlCommand(commndStr, con);

            con.Open();//opt1
            // com.Connection.Open();//opt2

            int res = com.ExecuteNonQuery();
            MessageBox.Show("res=" + res);

            con.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string outputStr = "";

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand com = new SqlCommand("SELECT * FROM UsersTB ORDER BY ID", con);

            com.Connection.Open();
            SqlDataReader reader =  com.ExecuteReader();

            while (reader.Read())
            {
                outputStr += reader[0] + ", " + reader["Name"] + ", " + reader["Family"] + "\r\n";
            }

            reader.Close();
            com.Connection.Close();

            lblRes.Text = outputStr;
        }
    }
}
