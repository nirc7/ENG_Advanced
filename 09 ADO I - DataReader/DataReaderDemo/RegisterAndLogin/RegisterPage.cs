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
    public partial class RegisterPage : Form
    {
        string strCon = @"Data Source=LAB-400;Initial Catalog=RegisterAndLoginDB;Integrated Security=True";
        SqlConnection con;
        LoginPage lp;

        public RegisterPage(LoginPage lp)
        {
            InitializeComponent();
            this.lp = lp;
            con = new SqlConnection(strCon);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool IsAlreadyExists = false;
            SqlCommand comm = new SqlCommand($"SELECT * FROM UsersTB WHERE Email='{txtMail.Text}'",con);
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                lblErr.Text = "already exists!!!";
                IsAlreadyExists = true;
            }
            comm.Connection.Close();

            if (!IsAlreadyExists)
            {
                comm.CommandText = $"INSERT INTO UsersTB(Name, Email,Pass) VALUES('{txtName.Text}','{txtMail.Text}','{txtPass.Text}')";
                comm.Connection.Open();
                int res = comm.ExecuteNonQuery();
                comm.Connection.Close();

                if (res==1)
                {
                    MessageBox.Show("Succeeded!");
                    MainPage mP = new MainPage(lp);
                    mP.Show();
                    Close();
                }
                else
                {
                    lblErr.Text = "sothing went wrong";
                }                
            }
        }
    }
}