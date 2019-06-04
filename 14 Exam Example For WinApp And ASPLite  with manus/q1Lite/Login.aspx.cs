using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=E440\SQLEXPRESS;Initial Catalog=Grades;Integrated Security=True;");
        SqlCommand com = new SqlCommand(
            $"SELECT * FROM GradesTable WHERE ID='{txtID.Text}' and name ='{txtName.Text}'", con);
        com.Connection.Open();
        SqlDataReader reader = com.ExecuteReader();
        if (reader.Read())
        {
            Session["ID"] = reader["ID"].ToString();
            Session["Name"] = reader["Name"].ToString();
            Session["Course"] = reader["Course"].ToString();
            Session["Grade"] = reader["Grade"].ToString();
            Server.Transfer("Details.aspx");
        }
        else
        {
            lblRes.Text = "ERR Log In!";
        }
        com.Connection.Close();
    }
}