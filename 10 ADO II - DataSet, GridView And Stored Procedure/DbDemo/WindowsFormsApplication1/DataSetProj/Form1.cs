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

namespace DataSetProj
{
    public partial class Form1 : Form
    {
        /*static*/
        string conStr = @"Data Source=LAB400;Initial Catalog=UsersDb;Integrated Security=True";
        SqlConnection con;
        DataSet ds = new DataSet();
        SqlDataAdapter adpt;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }

        //insert
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].NewRow();
            //dr.SetField(0, ds.Tables[0].Rows.Count+1);

            dr.SetField(1, textBox2.Text);
            dr.SetField(2, textBox3.Text);
            ds.Tables[0].Rows.Add(dr);
            ds.AcceptChanges();

            adpt = new SqlDataAdapter("SELECT * FROM UsersTb ORDER BY Id", con);
            SqlCommandBuilder comb = new SqlCommandBuilder(adpt);
            adpt.Update(ds, "T1");

            RefreshLabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            adpt = new SqlDataAdapter("SELECT * FROM UsersTb ORDER BY " + (rbtName.Checked?"Name":"Id"), con);
            adpt.Fill(ds, "T1");
            DataTable dt = ds.Tables["T1"];
            
            RefreshLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            ds = new DataSet();
            
            adpt = new SqlDataAdapter("SELECT * FROM UsersTb ORDER BY Id", con);
            adpt.Fill(ds, "T1");
            DataTable dt = ds.Tables["T1"];
            RefreshLabel();
        }

        private void RefreshLabel()
        {
            string str = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    str += ds.Tables[0].Rows[i][j].ToString() + " , ";
                }
                str += "\r\n";
            }
            label4.Text = str;
        }

        //update
        private void button2_Click(object sender, EventArgs e)
        {
            //ds.Tables[0].Rows[3-1]["Id"] = "dana2";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["Id"].ToString() == textBox1.Text)
                {
                    ds.Tables[0].Rows[i]["Name"] = textBox2.Text;
                    ds.Tables[0].Rows[i][2] = textBox3.Text;
                }
            }
            ds.AcceptChanges();
            RefreshLabel();
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["Id"].ToString() == textBox1.Text)
                {
                    //DataRow dr = ds.Tables[0].Rows[i];
                    ds.Tables[0].Rows[i].Delete();
                    ds.AcceptChanges();
                }
            }

            RefreshLabel();
        }
    }
}
