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
            //try
            //{
            dateEnd = Convert.ToDateTime(textBox1.Text);
            dateBegin = DateTime.Now;


            textBox2.Text = Convert.ToDateTime(dateEnd.Subtract(dateBegin)).ToString();
            //date.AddMonths(dateEnd.Month - dateBegin.Month);
            //date.AddDays(dateEnd.Day - dateBegin.Day);
            //date.AddHours(dateEnd.Hour - dateBegin.Hour);
            //date.AddMinutes(dateEnd.Minute - dateBegin.Minute);
            //date.AddSeconds(dateEnd.Second - dateBegin.Second);
            //textBox2.Text =date.ToString();

            //textBox2.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(date.DayOfWeek).ToString();
            //if (inYear.Checked)
            //{
            //    textBox2.Text = (date.Year).ToString();
            //}
            //if (inMonth.Checked)
            //{
            //    textBox2.Text = (date.Month).ToString();
            //}
            //if (inHours.Checked)
            //{
            //    textBox2.Text = (date.Hour).ToString();
            //}
            //if (inMinute.Checked)
            //{
            //    textBox2.Text = (date.Minute).ToString();
            //}
            //if (inSecunde.Checked)
            //{
            //    textBox2.Text = (date.Second).ToString();
            //}
            //}

            //catch
            //{
            //    MessageBox.Show("ВНИМАНИЕ: введите дату в цифровом формате дд.мм.гггг");
            //}

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
              dateIn();
        }
    }
}

