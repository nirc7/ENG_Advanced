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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DAL myDb = new DAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res =  myDb.InsertUser(textBox2.Text, textBox3.Text);
            if (res != 1)
            {
                MessageBox.Show("insert ERROR!");
            }
            else
            {
                MessageBox.Show("DONE :) ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res = myDb.UpdateUser(int.Parse(textBox1.Text),  textBox2.Text, textBox3.Text);
            if (res != 1)
            {
                MessageBox.Show("insert ERROR!");
            }
            else
            {
                MessageBox.Show("DONE :) ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string[,] res = myDb.SelectUsers(string order);
           
                      //code???
    //        while (true)
    //{
	         
    //}
    //        label4.Text +=;
        }
    }
}
