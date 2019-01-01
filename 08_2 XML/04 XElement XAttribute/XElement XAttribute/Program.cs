using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XElement_XAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteXmlFile();
           
            //PrintPersons();

            //PrintStudents();

            ChangeStudents();

            Console.ReadLine();
        }

        private static void ChangeStudents()
        {
            XDocument StudentDocument = XDocument.Load("Students.xml");
            XElement studentsRoot = StudentDocument.Root;
            IEnumerable<XElement> students = studentsRoot.Elements("person");
            
            IEnumerable<XElement> grades = students.Elements("Grade");
            Console.WriteLine("\nGRADES:");

            //option1
            foreach (var grade in grades)
            {
                //grade = new XElement("Grade",100); //ERROR because the ienumerator interface is read only (but not for inner properties!)
                Console.WriteLine(grade.Value);
                grade.Value = "100";
                Console.WriteLine(grade.Value);
            }

            //option2
            //foreach (var item in students)
            //{
            //    foreach (var g in item.Elements("Grade"))
            //    {
            //        g.Value = "100";    
            //    }
            //}

            StudentDocument.Save("Students after changes.xml");
        }

        private static void PrintStudents()
        {
            XDocument StudentDocument = XDocument.Load("Students.xml");
            XElement studentsRoot = StudentDocument.Root;
            IEnumerable<XElement> students = studentsRoot.Elements("person");
            IEnumerable<XElement> names = students.Elements("Name");
            
            //this will return an empty collection because the name element is not under the root element at all!
            IEnumerable<XElement> names2 = studentsRoot.Elements("Name");

            Console.WriteLine("\nNAMES:");
            foreach (var name in names)
            {
                Console.WriteLine(name.Value);
            }


            IEnumerable<XElement> grades = students.Elements("Grade");
            Console.WriteLine("\nGRADES:");

            foreach (var grade in grades)
            {
                Console.WriteLine(grade.Value);
            }


            Console.WriteLine("\nNAMES AND GRADES:");
            foreach (XElement student in students)
            {
                Console.WriteLine("\n" + student.Element("Name").Value);
                foreach (XElement grade in student.Elements("Grade"))
                {
                    Console.WriteLine("\t" + grade.Attribute("course").Value + ": " + grade.Value);
                }
            }
        }

        private static void PrintPersons()
        {
            XDocument personsXml = XDocument.Load("Perons.xml");
            //print all the xml
            Console.WriteLine(personsXml);
            Console.WriteLine("\n___________________________\n");

            //XName asd =  XName.Get("Name");
            XElement root = personsXml.Root;
            IEnumerable<XElement> persons = root.Elements();

          
            Console.WriteLine();
            foreach (var person in persons)
            {
                if (int.Parse((person.Attribute("Age").Value)) > 20)
                {
                    Console.WriteLine(person);    
                }
                
            }
        }

        private static void WriteXmlFile()
        {
            XDocument persons = new XDocument(
                new XElement("persons",
                    new XElement("person",
                        new XElement("Name", "chipopo"),
                        new XElement("Address", "street one 7"),
                        new XAttribute("Age", 32)),
                    new XElement("person",
                        new XElement("Name", "yakov"),
                        new XElement("Address", "street two 2"),
                        new XAttribute("Age", 20)),
                    new XElement("person",
                        new XElement("Name", "sarit"),
                        new XElement("Address", "street sham 40"),
                        new XAttribute("Age", 3)),
                    new XElement("person",
                        new XElement("Name", "rona"),
                        new XElement("Address", "street po 10"),
                        new XAttribute("Age", 23))
                )
            );

            persons.Save("Perons.xml");

            XDocument studentsDocument = persons;
            IEnumerable<XElement> students = studentsDocument.Elements();//get the ROOT
            int gr = 70;
            foreach (var student in students.Elements())
            {
                student.Add(
                    new XElement("Grade", gr+=5,
                    new XAttribute("course", "math")),
                    new XElement("Grade", gr ,
                    new XAttribute("course", "eng"))
                    );
            }

            studentsDocument.Save("Students.xml");
        }
    }
}
