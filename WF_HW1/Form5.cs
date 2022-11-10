using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW1
{
    public partial class Form5 : Form
    {
        Point begin;
        Point end;
        int ti = 0;
        int x, y;
        public Form5()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MousePress);
            this.MouseUp += new MouseEventHandler(MouseRelise);
            this.MouseMove += new MouseEventHandler(MouseMove_);
           // this.MouseClick += new MouseEventHandler(MouseClick_);
        }
        private void MouseClick_(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) MessageBox.Show("right Click");
        }
        private void MouseMove_(object sender, MouseEventArgs m)
        {
            //this.Text = m.Location.ToString();
        }

        private void MousePress(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                begin.X = e.X;
                begin.Y = e.Y;
            }
            //MessageBox.Show($"mouseDoun position {p}");
        }
        private void MouseRelise(object sender, MouseEventArgs e1)
        {
            if (e1.Button == MouseButtons.Left)
            {
                end.X = e1.X;
                end.Y = e1.Y;
                //MessageBox.Show($"mouseUp  position {e1}");
                createStatic();
            }
        }
        private void MouseButtonClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button but = (Button)sender;
                this.Controls.Remove(but);
                but.Dispose();
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("right Click");
                Button but = (Button)sender;
                label2.Text = $"позиция статика {but.Location.ToString()} его площадь {but.Size.Width * but.Size.Height}";
            }
        }
        private void MouseButtDondoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) MessageBox.Show("right Click");
            if (e.Button == MouseButtons.Left) MessageBox.Show("left Click");
        }



        private void createStatic()
        {
            Button button = new Button();
            button.Location = begin;
            if (end.X - begin.X >= 10 || end.Y - begin.Y >= 10)
            {
                x = end.X - begin.X;
                y = end.Y - begin.Y;
                
                button.Size = new System.Drawing.Size(x, y);
                button.TabIndex = ti++;
                button.Text = button.TabIndex.ToString();
                this.Controls.Add(button);
                button.MouseClick += new MouseEventHandler(MouseButtonClick);
                
            }
            else MessageBox.Show("Error: размеры меньше 10 px");
            this.label1.Text = $"start x {begin.X}\t start y {begin.Y}\n end x {x}\t end y{y}";

        }
    }
}