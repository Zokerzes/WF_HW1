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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
      
            this.MouseClick += new MouseEventHandler(MouseCl);
            this.MouseMove += new MouseEventHandler(MouseMove_);
        }
        private void MouseMove_(object sender, MouseEventArgs m)
        {
          
            this.Text =$" {this.Size.Width}x{this.Size.Height}{m.Location.ToString()}  ";
        }
    
        private void MouseCl(object sender, MouseEventArgs m1)
        {
            int x = m1.X;
            int y = m1.Y;
            if ((x == 50 || x == this.Width - 67) || (y == 50 || y == this.Height - 80))
                {
                    MessageBox.Show("Точка НА ГРАНИЦЕ прямоугольника");
                }
            else if ((x < 50 || x > this.Width - 67)||(y < 50 || y > this.Height - 80))
            {
                MessageBox.Show("Точка ВНЕ прямоугольника");
            }
            else if ((x > 50 || x < this.Width - 67) || (y > 50 || y < this.Height - 80))
            {
                MessageBox.Show("Точка ВНУТРИ прямоугольника");
            }
        }        
    }
}
