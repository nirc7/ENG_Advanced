using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace lecture07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (Decimal2binary(int.Parse(textBox1.Text))).ToString();
            //label1.Text = ((int)'a').ToString();
            //label1.Text = ((int)'A').ToString();
            //label1.Text = ((int)'%').ToString();
        }

        public int Decimal2binary(int number)
        {
            int result = 0, digit = 0;
            while (number > 0)
            {
                int shift = (int)Math.Pow(10, digit);
                result = result + (number % 2) * shift;
                number = number / 2;
                digit = digit + 1;
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"c:\temp\file.txt");
            string firstline = sr.ReadLine();
            int n1 = sr.Read();
            string strInput = sr.ReadToEnd();
            string strPeek, strPeek2;
            if (sr.Peek() >= 0)
                strPeek = "there is more to read";
            else
                strPeek = "nothing to read";
            if (!sr.EndOfStream) // checking if there is something to read
                strPeek2 = "there is more to read";
            else
                strPeek2 = "nothing to read";

            sr.Close();
            label2.Text = "firstLine: " + firstline + "\n" +
                            "one char: " + ((char)n1).ToString() + "\n" +
                            "the rest: " + strInput + "\n" +
                            "peek: " + strPeek + "\n" +
                            "peek2: " + strPeek2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "content:\n";
            StreamReader sr = new StreamReader(@"c:\temp\file.txt");
            while (!sr.EndOfStream)
            {
                label3.Text += sr.ReadLine().TrimEnd() + "\n";
            }
            sr.Close(); //if we comment this, after running this function 
                        //we could not change the file.txt 
                        //from windows because it is still used by this process
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] arr = new string[] {"This is my data", 
                                        "that i need to store" };

            StreamWriter sw = new StreamWriter(@"c:\temp\mydata.txt"); 
            //will create the file if not existed

            for (int i = 0; i < arr.Length; i++)
            {
                sw.Write(arr[i] + "\r\n");
                //sw.WriteLine(arr[i]); //the same as above
            }
            sw.Close();
        }
    }
}
