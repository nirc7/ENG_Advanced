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

namespace RegisterAndLogin
{
    public partial class LoginPage : Form
    {
        string strCon = @"Data Source=LAB-400;Initial Catalog=RegisterAndLoginDB;Integrated Security=True";
        SqlConnection con;

        public LoginPage()
        {
            InitializeComponent();
            con = new SqlConnection(strCon);
        }

        private void lnkBtnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage rP = new RegisterPage(this);
            rP.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand($"SELECT * FROM UsersTB WHERE Email='{txtMail.Text}' AND Pass='{txtPass.Text}'", con);
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                MainPage mp = new MainPage(this);
                mp.Show();
                Hide();
            }
            else
            {
                lblErr.Text = "does not exists!!!";
            }
            reader.Close();
            comm.Connection.Close();

        }
    }
}
