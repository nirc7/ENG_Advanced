using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Files2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //the StreamWriter sw is not needed here because we dont delete
            //anything in this function, so the returned sw will be destroyed at function end!
            if (!File.Exists("notes.txt"))
            {
                StreamWriter sw2 = File.CreateText("notes.txt");
                sw2.Close();
            }

            StreamWriter sw = new StreamWriter("notes.txt", true);
            sw.WriteLine(txtWord.Text);
            sw.Close();
            ShowAll();
        }

        private void ShowAll()
        {
            string str;
            txtScreen.Text = "";
            if (File.Exists("notes.txt"))
            {
                StreamReader sr = new StreamReader("notes.txt");
                //while (sr.Peek() >= 0)
                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine();
                    txtScreen.Text += str + "\r\n"; //new line for windows application!!!
                }
                sr.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str;
            int index = 0, index2, line;
            if (File.Exists("notes.txt"))
            {
                StreamReader sr = new StreamReader("notes.txt");
                str = sr.ReadToEnd();

                for (line = 1; line <= int.Parse(txtWord.Text); line++)
                {
                    index2 = str.IndexOf("\r\n", index);
                    if (index2 == -1) /*for lines number that is bigger than existing line number*/
                    {
                        break;
                    }
                    if (int.Parse(txtWord.Text) == line )
                        str = str.Substring(0, index) + str.Substring(index2 + 2);
                    index = index2 + 2;
                }

                sr.Close();

                StreamWriter sw = new StreamWriter("notes.txt", false);
                sw.Write(str);
                sw.Close();
                ShowAll();
            }
        }

        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtWord.Text))
                Directory.CreateDirectory(txtWord.Text);
        }

        private void btnDeleteDir_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtWord.Text))
                Directory.Delete(txtWord.Text);
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            //the StreamWriter sw is not needed here because we dont delete
            //anything in this function, so the returned sw will be destroyed at function end!
            if (!File.Exists(txtWord.Text))
            {
                StreamWriter sw = File.CreateText(txtWord.Text);
                sw.Close();
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtWord.Text))
            {  
                File.Delete(txtWord.Text);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fullName = openFileDialog1.FileName;
            FileInfo fi = new FileInfo(fullName);
            textBox1.Text = fi.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.ShowDialog();

        }
    }
}