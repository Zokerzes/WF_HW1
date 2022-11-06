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
        }
        private void MouseMove_(object sender, MouseEventArgs m)
        {
            this.Text = m.Location.ToString();
        }

        private void MousePress(object sender, MouseEventArgs e)
        {
            begin.X = e.X;
            begin.Y = e.Y;
            //MessageBox.Show($"mouseDoun position {p}");
        }
        private void MouseRelise(object sender, MouseEventArgs e1)
        {
            end.X = e1.X;
            end.Y = e1.Y;
            //MessageBox.Show($"mouseUp  position {e1}");
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
                button.MouseClick += new MouseEventHandler(MouseDel);

            }
            else MessageBox.Show("Error: размеры меньше 10 px");
            this.label1.Text = $"start x {begin.X}\t start y {begin.Y}\n end x {x}\t end y{y}";
        }
        private void MouseDel(object sender, MouseEventArgs e2)
        {
            Button but = (Button)sender;
            this.Controls.Remove(but);
            but.Dispose();
        }

    }
}