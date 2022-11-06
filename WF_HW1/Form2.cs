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
    public partial class Task1 : Form
    {
        string fio = "Меня зовут Роман";
        string str = "Я являюсь студентом \"Аккадемии \"Шаг\"\"";
        string str1 = "И изучаю С#";
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float AverageCount =(fio.Length + str.Length + str1.Length)/3;
            MessageBox.Show(fio, "MessageBox1");
            MessageBox.Show(str, "MessageBox2");
            MessageBox.Show(str1,$"MessageBox3: среднее колличество символов на окне {AverageCount.ToString()}");
        }
    }
}
