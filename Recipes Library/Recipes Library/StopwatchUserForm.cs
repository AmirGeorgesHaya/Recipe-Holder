using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Recipes_Library
{
    public partial class StopwatchUserForm : UserControl
    {
        private Stopwatch stopwatch = new Stopwatch();
        public StopwatchUserForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the timer label with the elapsed time from the stopwatch
            timerLabel.Text= stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // Stop the stopwatch

            stopwatch.Stop();
            // Stop the timer as well to prevent unnecessary UI updates

            timer1.Stop();  
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Start the stopwatch

            stopwatch.Start();
            timer1.Start();  // Start the timer to update the UI
        }

        private void resetButton_Click(object sender, EventArgs e)
        {    // Reset the stopwatch

            stopwatch.Reset();
            // Reset the label to zero
            timerLabel.Text = "00:00:00.00";  // Reset the label to zero
        }
    }
}
