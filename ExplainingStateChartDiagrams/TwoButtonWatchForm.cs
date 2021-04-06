using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplainingStateChartDiagrams
{
    public partial class TwoButtonWatchForm : Form
    {
        TwoButonWatch watch = new TwoButonWatch();
        public TwoButtonWatchForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSeconds.Text = (int.Parse(txtSeconds.Text) + 1).ToString();
        }

        private void TwoButtonWatchForm_Load(object sender, EventArgs e)
        {
            watch.Hours = 0;
            watch.Minutes = 0;
            watch.Seconds = 0;
            watch.WatchState = WatchState.DisplayingTime;

            txtHours.Text = watch.Hours.ToString();
            txtMinutes.Text = watch.Minutes.ToString();
            txtSeconds.Text = watch.Seconds.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(watch.WatchState == WatchState.DisplayingTime)
            {
                txtHours.Enabled = true;
                txtMinutes.Enabled = false;
                txtSeconds.Enabled = false;
                watch.WatchState = WatchState.BlinkHours;
            }
            else if(watch.WatchState == WatchState.BlinkHours)
            {
                txtHours.Enabled = false;
                txtMinutes.Enabled = true;
                txtSeconds.Enabled = false;
                watch.WatchState = WatchState.BlinkMinutes;
            }
            else if (watch.WatchState == WatchState.BlinkMinutes)
            {
                txtHours.Enabled = false;
                txtMinutes.Enabled = false;
                txtSeconds.Enabled = true;
                watch.WatchState = WatchState.BlinkSeconds;
            }
            else if (watch.WatchState == WatchState.BlinkSeconds)
            {
                txtHours.Enabled = true;
                txtMinutes.Enabled = false;
                txtSeconds.Enabled = false;
                watch.WatchState = WatchState.BlinkHours;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(watch.WatchState == WatchState.BlinkHours)
            {
                watch.Hours += 1;
                txtHours.Text = watch.Hours.ToString();
            }
            else if (watch.WatchState == WatchState.BlinkMinutes)
            {
                watch.Minutes += 1;
                txtMinutes.Text = watch.Minutes.ToString();
            }
            else if (watch.WatchState == WatchState.BlinkSeconds)
            {
                watch.Seconds += 1;
                txtSeconds.Text = watch.Seconds.ToString();
            }
        }

        private void buttons1and2_Click(object sender, EventArgs e)
        {
            if(!(watch.WatchState == WatchState.DisplayingTime))
            {
                watch.WatchState = WatchState.DisplayingTime;
                txtHours.Enabled = false;
                txtMinutes.Enabled = false;
                txtSeconds.Enabled = false;
            }
            
        }
    }
}
