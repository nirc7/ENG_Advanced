using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterAndLogin
{
    public partial class MainPage : Form
    {
        LoginPage lp;
        public MainPage(LoginPage lp)
        {
            InitializeComponent();
            this.lp = lp;
            lp.Hide();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            lp.Show();
            //lp.Close();
        }
    }
}
