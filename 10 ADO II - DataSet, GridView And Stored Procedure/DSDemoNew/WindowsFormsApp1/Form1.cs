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
        SqlConnection con;
        SqlDataAdapter adptr;
        DataSet ds;
        DataTable table1;
        Label l1 = new Label();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {            
            l1.Location = new Point(100, 70);
            l1.Font = new Font(FontFamily.Families[0], 12);
            Controls.Add(l1);

            l1.Text = "rows=" + table1.Rows.Count;

            label1.Text = "";

            foreach (DataRow row in table1.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    label1.Text += row[0] + ", " + row["Name"] + ", " + row["Family"] + "\r\n";
                }                
            }

            dataGridView1.DataSource = table1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = table1.NewRow();
            dr["Id"] = 7;
            dr["Name"] = "benny";
            dr["Family"] = "bobo";

            table1.Rows.Add(dr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDSFromDB();
        }

        private void RefreshDSFromDB()
        {
            con = new SqlConnection(@"Data Source=Lab-400;Initial Catalog=UsersDB;Integrated Security=True");
            adptr = new SqlDataAdapter("SELECT * FROM UsersTB ORDER BY NAME", con);
            ds = new DataSet();

            adptr.Fill(ds, "T1");

            table1 = ds.Tables["T1"];
        }

        private void btnUpdate2DB_Click(object sender, EventArgs e)
        {
            UpdateDBFromDS();
        }

        private void UpdateDBFromDS()
        {
            new SqlCommandBuilder(adptr);

            //opt1
            //adptr.Update(ds,"T1");
            //opt2
            adptr.Update(table1);
        }

        private void btnRefreshDS_Click(object sender, EventArgs e)
        {
            RefreshDSFromDB();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in table1.Rows)
            {
                if (row["Name"].ToString() == "avi")
                {
                    row["Name"] = "zehavi";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                if (table1.Rows[i]["Name"].ToString() == "benny")
                {
                    table1.Rows[i].Delete();
                }
            }            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDBFromDS();
        }

        private void btnSelectByID_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adptr2 = new SqlDataAdapter("SELECT * FROM UsersTB WHERE ID=@parName1",con);

            SqlParameter par1 = new SqlParameter("parName1",SqlDbType.Int);
            par1.Value = txtId.Text;

            adptr2.SelectCommand.Parameters.Add(par1);

            if (ds.Tables["T2"] != null)
            {
                ds.Tables["T2"].Clear();
            }
            
            adptr2.Fill(ds, "T2");

            dataGridView1.DataSource = ds.Tables["T2"];
        }
    }
}
