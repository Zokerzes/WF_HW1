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
            this.MouseDown += new MouseEventHandler(Form4_MouseDown);
            this.MouseClick += new MouseEventHandler(MouseCl);
            this.MouseMove += new MouseEventHandler(MouseMove_);
            
            
        }
        private void MouseMove_(object sender, MouseEventArgs m)
        {
          
            this.Text =$" {this.Size.Width}x{this.Size.Height}{m.Location.ToString()}  ";
        }
    
        private void MouseCl(object sender, MouseEventArgs m1)
        {
            if (m1.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.Text = $"Ширина-{this.ClientSize.Width}xВысота-{this.ClientSize.Height}  ";
            }
            if (m1.Button == System.Windows.Forms.MouseButtons.Left)
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
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Close();
                this.Dispose();
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.Text = $"Ширина-{this.ClientSize.Width}xВысота-{this.ClientSize.Height}  ";
            }
        }

    }
}
