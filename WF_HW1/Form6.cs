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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(button1_MouseMove);

        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int xLeft = button1.Location.X;
            int xRight = button1.Location.X + button1.Size.Width;
            int yTop = button1.Location.Y;
            int yBottom = button1.Location.Y + button1.Size.Height;

            
            if ((e.X > xLeft - 20 && e.X <= xLeft) && (e.Y >= yTop && e.Y <= yBottom)&& xRight<this.ClientSize.Width-10)
            {
                button1.Location = new Point(button1.Left + 1, button1.Top);
            }
            if ((e.Y > yTop - 20 && e.Y <= yTop) && (e.X >= xLeft && e.X <= xRight) && yBottom < this.ClientSize.Height-10)
            {
                button1.Location = new Point(button1.Left, button1.Top + 1);
            }
            if ((e.X < xRight + 20 && e.X > xRight) && (e.Y >= yTop && e.Y <= yBottom) && xLeft > 10)
            {
                button1.Location = new Point(button1.Left - 1, button1.Top);
            }
            if ((e.Y < yBottom + 20 && e.Y > yBottom) && (e.X >= xLeft && e.X <= xRight)&& yTop > 10)
            {
                button1.Location = new Point(button1.Left, button1.Top - 1);
            }
            

        }
    }
}
