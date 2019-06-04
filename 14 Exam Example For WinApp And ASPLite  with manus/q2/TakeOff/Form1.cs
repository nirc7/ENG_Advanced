using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TakeOff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void takeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeOff frmChild = new TakeOff();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

      

        private void byeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(toolStripTextBox2.Text)*1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
