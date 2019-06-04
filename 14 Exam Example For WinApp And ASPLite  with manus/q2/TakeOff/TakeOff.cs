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
    public partial class TakeOff : Form
    {
        int number = 1;
        public TakeOff()
        {
            InitializeComponent();
        }

        private void TakeOff_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = number.ToString();
            switch (number)
            {
                case 1:
                    pictureBox1.ImageLocation = "airplane_l.gif";
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    break;
                case 2:
                    pictureBox1.Image = null;
                    pictureBox2.ImageLocation = "airplane_l.gif";
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    break;
                case 3:
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.ImageLocation = "airplane_l.gif";
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    break;
                case 4:
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.ImageLocation = "airplane_l.gif";
                    pictureBox5.Image = null;
                    break;
                case 5:
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.ImageLocation = "airplane_l.gif";                    
                    break;
            }
            number++;
            if (number==6)
            {
                timer1.Enabled = false;
            }
        }

    }
}
