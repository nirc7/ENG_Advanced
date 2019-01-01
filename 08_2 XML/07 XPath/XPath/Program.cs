using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace XPath
{
    class Program
    {
        static XmlDocument doc;
        static void Main(string[] args)
        {
            doc = new XmlDocument();
            string xPathExp= string.Empty;
            try
            {
                doc.Load("Books.xml");

                //select root element
                 XmlNode nd =  doc.SelectSingleNode("/");
                

                //selct all element with name
                 xPathExp = "/books/book";
                 PrintResults(xPathExp);
                //select price
                 Console.WriteLine("\nselect price");
                 xPathExp = "/books/book/price";
                 PrintResults(xPathExp);


                //all authors last name - Attribute
                 Console.WriteLine("\nall authors last name - Attribute");
                 xPathExp = "/books/book/authors/author/@lname";
                 PrintResults(xPathExp);

                 Console.WriteLine("\n title of first book");
                //title of first book
                 xPathExp = "/books/book[1]/title";
                 PrintResults(xPathExp);

                //last
                 Console.WriteLine("\n title of last book");

                 xPathExp = "/books/book[last()]/title";
                 PrintResults(xPathExp);

                 Console.WriteLine("\n title of position book");
                 xPathExp = "/books/book[position() = last() - 1]/title";
                 PrintResults(xPathExp);

                Console.WriteLine("\n conditions");
                xPathExp = "/books/book[price>20]/title";
                 PrintResults(xPathExp);

              

                /*
                Operators :
         "/books/book/title | /books/book/price" - All book titles and prices 
          "/books/book[count(authors/author) >= 3]">Books with >=3 authors 
          "/books/book[starts-with(@isbn, '1')]">Books, ISBN starts with 1 
          "/books/book/@isbn[starts-with(., '1')]">ISBNs, starting with 1 
          "/books/book[contains(title, 'X')]">Books, X in the title 
          "/books/book[count(authors/author) mod 2 != 0]">Books, even authors 
          "(/books/book//* | /books/book//@*)[not(self::price)]">All book info except price 
  */              


            }
            catch (SystemException se)
            {

            }
        }
        static void PrintResults(string XPathExpression)
        {
            Console.WriteLine("-------------------------------");
            XmlNodeList list = doc.SelectNodes(XPathExpression);
            foreach (XmlNode node in list)
            {
                Console.WriteLine("Node Name : " + node.Name + "  " + "Node value : " + node.InnerText); //node.Value will get 
                                                                                                        //you the attribute and not the element value!
            }

        }
    }
}
