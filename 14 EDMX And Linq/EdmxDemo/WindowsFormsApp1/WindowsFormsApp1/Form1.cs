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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VIDEOLIBPROJECTV01Entities videos = new VIDEOLIBPROJECTV01Entities();
            var longMovienamesstartsWithA = from mov in videos.Movies
                                            where mov.MovieName.Length > 5 && mov.MovieName.ToLower().StartsWith("s")
                                            select mov;
            label1.Text = "";
            foreach (var m in longMovienamesstartsWithA)
            {
                label1.Text += m.MovieName + ", "  + m.MovieID +"\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VIDEOLIBPROJECTV01Entities videos = new VIDEOLIBPROJECTV01Entities();
            var actorsInlongMovienamesstartsWithA = from mov in videos.Movies
                                            where mov.MovieName.Length > 5 && mov.MovieName.ToLower().StartsWith("s")
                                            select  new { mov.MovieName,  mov.Actors };
            label1.Text = "";
            foreach (var actorsInMovie in actorsInlongMovienamesstartsWithA)
            {
                label1.Text += "\r\n_____" + actorsInMovie.MovieName +  "____________\r\n";
                foreach (var act in actorsInMovie.Actors)
                {
                    label1.Text += "  " + act.ActorName + ", " + act.ActorID + "\r\n";
                }                
            }
        }
    }
}
