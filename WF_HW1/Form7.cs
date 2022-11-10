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

namespace WF_HW1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

        }


        private void dayOfWeek()
        {
            try 
            { 
                DateTime date;
                int dayofweek;
                date = Convert.ToDateTime(textBox1.Text);
                dayofweek = (int)date.DayOfWeek;
                textBox2.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(date.DayOfWeek).ToString();
            }
            catch
            {
                MessageBox.Show("ВНИМАНИЕ: введите дату в цифровом формате дд.мм.гггг");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dayOfWeek();
        }
    }
}
