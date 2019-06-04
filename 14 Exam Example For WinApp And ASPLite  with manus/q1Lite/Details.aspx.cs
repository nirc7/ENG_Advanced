using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblDetails.Text = 
                Session["ID"].ToString() + " - " +
                Session["Name"].ToString() + " - " +
                Session["Course"].ToString() + " - " +
                Session["Grade"].ToString() ;
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=E440\SQLEXPRESS;Initial Catalog=Grades;Integrated Security=True;");
        SqlCommand com = new SqlCommand(
            $"SELECT avg(Grade) FROM GradesTable WHERE Course='{DropDownList1.SelectedItem}'", con);
        com.Connection.Open();
        SqlDataReader reader = com.ExecuteReader();
        if (reader.Read())
        {
            lblAVG.Text = reader[0].ToString();
        }
        else
        {
            lblAVG.Text = "ERR AVG!";
        }
        com.Connection.Close();
    }
}