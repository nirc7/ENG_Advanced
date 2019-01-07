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
            ExcNonQ("INSERT INTO UsersTB(Name, Family) VALUES('Dora','Bora')");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcNonQ("UPDATE UsersTB SET Family='lechlech' WHERE Id=2 ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcNonQ("DELETE UsersTB WHERE Id=" + txtID.Text);
        }

        private void ExcNonQ(string commndStr)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            SqlCommand com = new SqlCommand(commndStr, con);
            int res = com.ExecuteNonQuery();
            MessageBox.Show("res=" + res);

            con.Close();
        }

       
    }
}
