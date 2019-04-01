using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedQueueProj
{
    public partial class AthleteForm : Form
    {
        TimedQueue<Athlte> tq = new TimedQueue<Athlte>();
        static int counter = 1;

        public AthleteForm()
        {
            InitializeComponent();
        }

        private void btnArriaved_Click(object sender, EventArgs e)
        {
            Athlte t = new Athlte() { AthleteID = counter, AthleteName = "Athlete " + counter };

            counter++;
            tq.Enqueue(t);
            RefreshLabel();
        }

        private void RefreshLabel()
        {
            lblRes.Text = tq.ToString();
        }

        private void btnDeparted_Click(object sender, EventArgs e)
        {
            try
            {
                Athlte returnTeam = tq.Dequeue();
                RefreshLabel();
                lblComp.Text = returnTeam.ToString();
            }
            catch (TimedOutException te)
            {
                MessageBox.Show(te.Message);
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
