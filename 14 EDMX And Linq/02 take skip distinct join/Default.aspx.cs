using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoLibProjectV01Model;

public partial class _Default : System.Web.UI.Page
{
    VideoLibProjectV01Entities myVideoDB = new VideoLibProjectV01Entities();
    protected void Page_Load(object sender, EventArgs e)
    {
        //take7();
        //skip2();

        //distinctDemo();

        joinDemo();

    }

    private void joinDemo()
    {
        var movieYear = (from m in myVideoDB.Movies
                         join r in myVideoDB.Reviews
                         on m.MovieID equals r.MovieID
                         select new { m.MovieName, r.Rate }).Take(20);  //one-to-many join


        string str = "";
        foreach (var item in movieYear)
        {
            str += item.MovieName + ": " + item.Rate + "<br/>";
        }

        lblRes.Text = str;
    }

    private void distinctDemo()
    {
        var movieYear = (from m in myVideoDB.Movies
                         orderby m.Year
                         select m.Year);  //deferred excecution


        string str = "";
        int count = 1;
        foreach (var item in movieYear)
        {
            str +=  count + ": " + item + "<br/>";
            count++;

        }

        lblRes.Text = str;

        var movieYearDistinct = (from m in myVideoDB.Movies
                         orderby m.Year
                         select m.Year).Distinct();  //deferred excecution


         str = "";
         count = 1;
        foreach (var item in movieYearDistinct)
        {
            str += count + ": " + item + "<br/>";
            count++;

        }

        lblRes2.Text = str;
    }

    private void take7()
    {
        var _7TopRated = (from m in myVideoDB.Movies
                          orderby m.Reviews.Average(r => r.Rate) descending
                          select m).Take(7);  //deferred excecution


        string str = "";
        foreach (var item in _7TopRated)
        {
            str += "<hr/><br/><br/><br/>" + item.MovieName + "<br/>" + item.Reviews.Average(r => r.Rate);
            foreach (var actor in item.Actors)
            {
                str += "<br/>&nbsp&nbsp&nbsp" + actor.ActorName;
            }

        }

        lblRes.Text = str;
    }

    private void skip2()
    {
        var _2NotTopRated = (from m in myVideoDB.Movies
                          orderby m.Reviews.Average(r => r.Rate) descending
                          select m).Take(7).Skip(2);  //deferred excecution


        string str = "";
        foreach (var item in _2NotTopRated)
        {
            str += "<hr/><br/><br/><br/>" + item.MovieName + "<br/>" + item.Reviews.Average(r => r.Rate);
            foreach (var actor in item.Actors)
            {
                str += "<br/>&nbsp&nbsp&nbsp" + actor.ActorName;
            }

        }

        lblRes2.Text = str;
    }
}