using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //SelectDemo();
        InsertDemo();
        //UpdateDemo();
        //DeleteDemo();
    }


    private void UpdateDemo()
    {
        using (VideoLibProjectV01Entities myVideoEDMX = new VideoLibProjectV01Entities())
        {
            //select the new movie
            var myMovie = from m in myVideoEDMX.Movies
                          where m.MovieName.StartsWith("The Magical")
                          select m;  //deferred excecution

            string str = "";
            foreach (var item in myMovie)
            {
                str += "<hr>OLD<br/><br/><br/>" + item.MovieName + "<br/>" + item.DateAdded.ToString();
                item.DateAdded = item.DateAdded.AddDays(1);
            }

            myVideoEDMX.SaveChanges();

            //select the new movie
            myMovie = from m in myVideoEDMX.Movies
                      where m.MovieName.StartsWith("The Magical")
                      select m;  //deferred excecution


            foreach (var item in myMovie)
            {
                str += "<hr>NEW<br/><br/><br/>" + item.MovieName + "<br/>" + item.DateAdded.ToString() + item.MovieID + "<br/>";
            }

            lblRes.Text = str;
        }
    }

    private void InsertDemo()
    {
        using (VideoLibProjectV01Entities myVideoEDMX = new VideoLibProjectV01Entities())
        {
            //pay attention the Local is runing only on the local inserted info!
            //you cant see the DB through it!
            //pay attention also the the EDMX is not using any DS But it is only an interface to the DB.
            var myMovie2 = (from m in myVideoEDMX.Movies.Local
                          where m.MovieName.StartsWith("The Magical")
                          select m).Count();  //deferred excecution

            Response.Write("myMovie2=" + myMovie2 + "</br>");
            Response.Write(myVideoEDMX.Movies.Count() + "</br>");
            Response.Write("local= " + myVideoEDMX.Movies.Local.Count() + "</br>");

            Movie m1 = new Movie();
            m1.MovieID = "N 780";   //has to be change every run for a unique number!
            m1.MovieName = "The Magical Honeymoon in Cancun:)";
            m1.DateAdded = new DateTime(2011, 07, 15);
            m1.Summary = "";    //required field!
            m1.MoviePicUrl = "";//required field!
            m1.TrailerUrl = "";//required field!
            m1.CountryID = 1;//required field!
            m1.MovieTypeID = 2;//required field!

            myVideoEDMX.Movies.Add(m1);
            //myVideoEDMX.AddToMovies(m1);
            Response.Write(myVideoEDMX.Movies.Count() + "</br>");
            //myVideoEDMX.SaveChanges();
            Response.Write(myVideoEDMX.Movies.Count() + "</br>");
            Response.Write("local= " + myVideoEDMX.Movies.Local.Count() + "</br>");
            //select the new movie
            var myMovie3 = (from m in myVideoEDMX.Movies.Local
                          //where m.MovieName.StartsWith("The Magical")
                          select m).Count();  //deferred excecution
            Response.Write("myMovie3=" + myMovie3 + "</br>");

            var myMovie = from m in myVideoEDMX.Movies.Local
                          where m.MovieName.StartsWith("The Magical")
                          select m;  //deferred excecution

            Response.Write("myMovie=" + myMovie);

            string str = "";
            foreach (var item in myMovie)
            {
                str += "<hr><br/><br/><br/>" + item.MovieName + "<br/>" + item.DateAdded.ToString() + item.MovieID + "<br/>";
            }

            lblRes.Text = str;
            //DeleteDemo();
        }
    }


    private void DeleteDemo()
    {
        using (VideoLibProjectV01Entities myVideoEDMX = new VideoLibProjectV01Entities())
        {
            //select the new movie
            var myMovie = from m in myVideoEDMX.Movies
                          where m.MovieName.StartsWith("The Magical")
                          select m;  //deferred excecution


            foreach (var item in myMovie)
            {
                myVideoEDMX.Movies.Remove(item);
            }

            myVideoEDMX.SaveChanges();

            //select the new movie
            myMovie = from m in myVideoEDMX.Movies
                      where m.MovieName.StartsWith("The Magical")
                      select m;  //deferred excecution

            string str = "the items left: ";
            foreach (var item in myMovie)
            {
                str += "<hr>NEW<br/><br/><br/>" + item.MovieName + "<br/>" + item.DateAdded.ToString() + item.MovieID + "<br/>";
            }

            lblRes.Text = str + "<br/>END";
        }
    }

    private void SelectDemo()
    {
        using (VideoLibProjectV01Entities myVideoEDMX = new VideoLibProjectV01Entities())
        {
            var MostActorsInAMovie = from m in myVideoEDMX.Movies
                                     orderby m.Actors.Count() descending
                                     select m;  //deferred excecution


            string str = "";
            foreach (var item in MostActorsInAMovie)
            {
                str += "<hr><br/><br/><br/>" + item.MovieName + "<br/>" + item.MovieID + "<br/>";
                foreach (var actor in item.Actors)
                {
                    str += "<br/>&nbsp&nbsp&nbsp" + actor.ActorName;
                }

            }

            lblRes.Text = str;
        }
    }
}