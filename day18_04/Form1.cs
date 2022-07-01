using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day18_04
{
    public partial class Form1 : Form
    {
        Rectangle Rect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "Left: " + Rect.X +
                         "  Top: " + Rect.Y +
                         "  Right: " + Rect.Right +
                         "  Bottom: " + Rect.Bottom;
            
            e.Graphics.FillRectangle(Brushes.Red, Rect);
            e.Graphics.DrawString(str, Font, Brushes.Black, Rect.X - 20, Rect.Y - 20);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Rect.X = e.X;
            Rect.Y = e.Y;
            Rect.Height = 0;
            Rect.Width = 0;
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Rect.Width = e.X - Rect.X + 1;
                Rect.Height = e.Y - Rect.Y + 1;
                Invalidate();
            }
        }
    }
}
