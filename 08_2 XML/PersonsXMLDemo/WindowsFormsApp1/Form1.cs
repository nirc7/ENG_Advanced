using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        XDocument doc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc = XDocument.Load("Persons.xml");

            ShowPersons();
        }

        private void ShowPersons()
        {
            lblRes.Text = "the list:\r\n";
            foreach (var person in doc.Root.Elements("Person"))
            {
                lblRes.Text += person + "\r\n\r\n";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowPersons();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            doc.Root.Add(
                    new XElement("Person",
                                    new XAttribute("id", txtID.Text),
                                    new XElement("Name", txtName.Text),
                                    new XElement("Grade", txtGrade.Text))
                    );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doc.Save("Persons.xml");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            XElement perElm = FindElementById(txtID.Text);
            if (perElm != null)
            {
                txtName.Text = perElm.Element("Name").Value;
                txtGrade.Text = perElm.Element("Grade").Value;
            }
        }

        private XElement FindElementById(string id)
        {
            foreach (var person in doc.Root.Elements("Person"))
            {
                if (person.Attribute("id").Value == id)
                {
                    return person;
                }
            }
            return null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XElement perElm = FindElementById(txtID.Text);
            if (perElm != null)
            {
                perElm.Remove();
            }
        }
    }
}
