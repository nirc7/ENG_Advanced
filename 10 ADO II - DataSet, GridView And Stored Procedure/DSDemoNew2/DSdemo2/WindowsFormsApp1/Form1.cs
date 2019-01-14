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

        string strCon = @"Data Source=lab-400;Initial Catalog=UsersDB;Integrated Security=True";
        DataSet ds = new DataSet();
        DataTable usersTable;
        SqlConnection con;
        SqlDataAdapter adtr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strCon);
            adtr = new SqlDataAdapter("SELECT * FROM UsersTB", con);
            adtr.Fill(ds, "usersTable");
            usersTable = ds.Tables["usersTable"];
            RefreshGV();
        }

        private void RefreshGV()
        {
            dataGridView1.DataSource = usersTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = usersTable.NewRow();
            dr["ID"] = txtID.Text;
            dr["Name"] = txtName.Text;
            dr["Family"] = txtFamily.Text;
            dr["Grade"] = txtGrade.Text;

            usersTable.Rows.Add(dr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < usersTable.Rows.Count; i++)
            {
                if (usersTable.Rows[i]["Id"].ToString() == txtID.Text)
                {
                    usersTable.Rows[i].Delete();
                }
            }
        }

        private void btnUpDS2DB_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(adtr);
            adtr.Update(usersTable);
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("SELECT Grade FROM UsersTB WHERE Id=@idPar AND Name=@namePar",con);
            
            //opt1
            SqlParameter idPar = new SqlParameter("idPar",txtID.Text);
            comm.Parameters.Add(idPar);

            //opt2
            //comm.Parameters.Add(new SqlParameter("idPar", txtID.Text));

            SqlParameter namePar = new SqlParameter("namePar",SqlDbType.NVarChar,50 );
            namePar.Value = txtName.Text;
            comm.Parameters.Add(namePar);


            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("grade = " + reader["Grade"]);
            }
            comm.Connection.Close();
        }

        private void btnSELECTWhSP_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("SearchUser", con);
            comm.CommandType = CommandType.StoredProcedure;

            //opt1
            SqlParameter idPar = new SqlParameter("MyID", int.Parse(txtID.Text));
            idPar.Direction = ParameterDirection.Input;
            comm.Parameters.Add(idPar);

            //opt2
            //comm.Parameters.Add(new SqlParameter("idPar", txtID.Text));

            SqlParameter namePar = new SqlParameter("FamilyName", SqlDbType.VarChar, 20);
            namePar.Direction = ParameterDirection.Output;
            namePar.Value = txtName.Text;
            comm.Parameters.Add(namePar);

            SqlParameter returnPar = new SqlParameter();
            returnPar.Direction = ParameterDirection.ReturnValue;
            comm.Parameters.Add(returnPar);


            con.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();

            if ((int)returnPar.Value == 0)
            {
                MessageBox.Show("family = " + namePar.Value.ToString());
            }
            else
            {
                MessageBox.Show("ERR!");
            }
            
        }

        private void btnSelectTableWhSP_Click(object sender, EventArgs e)
        {
            //create a command 
            SqlCommand comm = new SqlCommand("SearchUserTable", con);
            //define it as SP
            comm.CommandType = CommandType.StoredProcedure;

            //add input parameter to the command
            SqlParameter idPar = new SqlParameter("MyID", int.Parse(txtID.Text));
            idPar.Direction = ParameterDirection.Input;
            comm.Parameters.Add(idPar);

            //set the command into the adapter
            SqlDataAdapter adtr2 = new SqlDataAdapter(comm);

            //clear the table if necessary
            if (ds.Tables["TableGreaterEquelThanParId"] != null)
            {
                ds.Tables["TableGreaterEquelThanParId"].Clear();
            }            

            //create the table into the DS
            adtr2.Fill(ds, "TableGreaterEquelThanParId");
            //set the table to be the source of the GV
            dataGridView1.DataSource = ds.Tables["TableGreaterEquelThanParId"];
        }
    }
}
