using System;
using static System.Windows.Forms.AxHost;

namespace Risovka_05._06._23_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MyDraw(Graphics g, int N, int UPX, int UPY, int r)
        {
            if (N == 0)
                return;
            else
            {
                int LevX = UPX - r;
                int LevY = UPY - r;
                g.DrawEllipse(new Pen(Brushes.Blue, 2), LevX, LevY, r * 2, r * 2);
                UPX += r;
                UPY += r;
                r += 15;
                MyDraw(g, N - 1, UPX, UPY, r);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            MyDraw(g, 7,15, 15, 20);
        }
    }
}