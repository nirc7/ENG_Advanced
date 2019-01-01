using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private string userName;

        public MainForm(LoginForm loginForm, string userName)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.userName = userName;
            
            label1.Text = "WELCOME "+ userName +" - " + this.loginForm.TxtPass + " TO OUR APP!!!";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
    }
}
