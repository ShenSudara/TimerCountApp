using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int count = 0;
        private int countLimit = 0;
        private int timeLimit = 0;
        private void count_btn_ClickAsync(object sender, EventArgs e)
        {
            //Check input Strings are valid or not
            if(int.TryParse(delay_txtbx.Text, out timeLimit)){
                if(int.TryParse(count_txtbx.Text,out countLimit)){
                    //Initialize a timer and reset variables
                    count = 0;
                    counterText_lbl.Text = "0";
                    if (timer != null) timer.Stop();
                    timer = new Timer();
                    //Subscribe to Tick event
                    timer.Tick += new EventHandler(timer_tick);
                    timer.Interval = timeLimit * 1000;
                    //Start a timer
                    timer.Start();
                }
                else{
                    MessageBox.Show(null, "Incorrect format of count limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else{
                MessageBox.Show(null, "Incorrect format of time delay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //When timer is ticking
        private void timer_tick(object sender, EventArgs e)
        {
           if(count < countLimit)
            {
                count++;
                counterText_lbl.Text = count.ToString();
            }else
            {
                timer.Stop(); //If count is exceed than count limit then timer will stop
            }


        }

        //When reset the timer
        private void reset_btn_Click(object sender, EventArgs e)
        {
            //Stop the timer
            timer.Stop();
            count = 0;
            timeLimit = 0;
            countLimit = 0;

            //Clear the text box and counter
            delay_txtbx.Clear();
            count_txtbx.Clear();
            delay_txtbx.Focus();
            counterText_lbl.Text = "0";

        }
    }
}
