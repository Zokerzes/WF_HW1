using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW1
{
    public partial class Form3 : Form
    {
        int a = 0, b = 2000, n = -1, gn=-2;
       
        Random r = new Random();
       
        public Form3()
        {
            InitializeComponent();
            this.Text = "Угадываем число";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
            gn = Convert.ToInt32(textBox1.Text);
                if (gn < 0 || gn > 2000) throw new Exception();
            textBox1.Enabled=false;
            button1.Enabled =false;
            GuessingNumber();
            }
            catch
            {
                MessageBox.Show("Ошибка: Необходимо ввести число от 0 до 2000");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

       
        private void GuessingNumber()
        {
            
            do
            {
                NextStep();
                DialogResult result = MessageBox.Show($"Ваше число больше{n}?", "угадываем",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if (n == gn)
                {
                   
                    MessageBox.Show($"Ваше число {n}  :)");
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    a = n;
                }
                else if (result == DialogResult.No)
                {
                    b = n;
                }
                else if (result == DialogResult.Cancel)
                {
                    
                    MessageBox.Show($"Выходим. Остановились на {n}");
                    
                    return;
                }
            } while (n != gn );
        }

        private void NextStep()
        {
            n = r.Next(a, b);
        }
       
    }
}
