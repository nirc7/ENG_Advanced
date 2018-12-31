using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonsDemo
{
    public partial class Form1 : Form
    {
        Person[] persons;
        string inputFilePath = @"Files\PersonsData.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillPersonsArrFromTxt();
        }

        private void FillPersonsArrFromTxt()
        {
            string inputStr = File.ReadAllText(inputFilePath);
            string[] peronsStrArr = inputStr.Split(new string[] { "\r\n" },
                                                    StringSplitOptions.RemoveEmptyEntries);
            persons = new Person[peronsStrArr.Length];
            for (int i = 0; i < persons.Length; i++)
            {
                string[] personValues = peronsStrArr[i].Split(',');
                persons[i] = new Person(
                                            int.Parse(personValues[0]),
                                            personValues[1],
                                            int.Parse(personValues[2])
                                        );
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblRes.Text = $"{"ID",-10}| {"Name",-10}| {"Grade",-10}\r\n";
            foreach (var person in persons)
            {
                lblRes.Text += person.PersonAsLabelStr() + "\r\n";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Array.Resize(ref persons, persons.Length + 1);
            persons[persons.Length - 1] = new Person(
                                                        int.Parse(txtID.Text),
                                                        txtName.Text,
                                                        int.Parse(txtGrade.Text)
                                                    );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string personsStr = "";
            foreach (var person in persons)
            {
                personsStr += person.PersonAsString() + "\r\n";
            }

            StreamWriter writer = new StreamWriter(inputFilePath);
            writer.Write(personsStr);
            writer.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int index = FindIndexById(int.Parse(txtID.Text));

            if (index != -1)
            {
                Person[] newPersons = new Person[persons.Length - 1];
                for (int i = 0; i < persons.Length; i++)
                {
                    if (i==index)
                    {
                        continue;
                    }
                    newPersons[counter++] = persons[i];
                }
                persons = newPersons;
            }            
        }

        private int FindIndexById(int v)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].ID == v)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = FindIndexById(int.Parse(txtID.Text));
            if (index==-1)
            {
                return;
            }
            txtName.Text = persons[index].Name;
            txtGrade.Text =persons[index].Grade.ToString();
        }
    }
}
