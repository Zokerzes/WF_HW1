using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_HW1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

        }
        private void dateIn()
        {
            DateTime dateBegin, dateEnd, date;

            dateEnd = Convert.ToDateTime(textBox1.Text);
            dateBegin = DateTime.Now;




            TimeSpan ts = dateEnd - dateBegin;

            if (inYear.Checked)
            {
                textBox2.Text = (ts.TotalDays / 360).ToString();
            }
            if (inMonth.Checked)
            {
                textBox2.Text = (ts.TotalDays / 30).ToString();
            }
            if (inHours.Checked)
            {
                textBox2.Text = (ts.TotalHours).ToString();
            }
            if (inMinute.Checked)
            {
                textBox2.Text = (ts.TotalMinutes).ToString();
            }
            if (inSecunde.Checked)
            {
                textBox2.Text = (ts.TotalSeconds).ToString();

                // Define two dates.
                DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
                DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);

                // Calculate the interval between the two dates.


                // Display individual properties of the resulting TimeSpan object.
                //Console.WriteLine("   {0,-35} {1,20}", "Value of Days Component:", interval.Days);
                //Console.WriteLine("   {0,-35} {1,20}", "Total Number of Days:", interval.TotalDays);
                //Console.WriteLine("   {0,-35} {1,20}", "Value of Hours Component:", interval.Hours);
                //Console.WriteLine("   {0,-35} {1,20}", "Total Number of Hours:", interval.TotalHours);
                //Console.WriteLine("   {0,-35} {1,20}", "Value of Minutes Component:", interval.Minutes);
                //Console.WriteLine("   {0,-35} {1,20}", "Total Number of Minutes:", interval.TotalMinutes);
                //Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Seconds Component:", interval.Seconds);
                //Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Seconds:", interval.TotalSeconds);
                //Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Milliseconds Component:", interval.Milliseconds);
                //Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
                //Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            dateIn();
        }

       
    }
}

