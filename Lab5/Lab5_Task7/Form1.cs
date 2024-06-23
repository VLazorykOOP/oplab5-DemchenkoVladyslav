using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5_Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            var g = CreateGraphics();

            g.Clear(Color.White);
            int a = int.Parse(AValue.Text);
            int x0 = 300, y0 = 300;
            int x2 = 300, y2 = 100;
            Point[] points = new Point[a];
            int j = 0;
            points[j++] = new Point((int)((x2 - x0) * Math.Cos(-90 * Math.PI / 180) - (y2 - y0) * Math.Sin(-90 * Math.PI / 180) + x0),
                  (int)((x2 - x0) * Math.Sin(-90 * Math.PI / 180) + (y2 - y0) * Math.Cos(-90 * Math.PI / 180) + y0));
            if (a > 1)
            {
                a -= 1;
                for (int i = 90; i > -90 && j <= a; i -= (int)Math.Ceiling((double)(180 / a)))
                {
                    points[j++] = new Point((int)((x2 - x0) * Math.Cos(i * Math.PI / 180) - (y2 - y0) * Math.Sin(i * Math.PI / 180) + x0),
                        (int)((x2 - x0) * Math.Sin(i * Math.PI / 180) + (y2 - y0) * Math.Cos(i * Math.PI / 180) + y0));
                }
            }
            foreach (Point p in points)
            {
                Pen pen = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
                Branch(g, pen, x0, y0, p.X, p.Y, int.Parse(kvalue.Text));
            }
        }

        public void Branch(Graphics g, Pen pen, int x1, int y1, int x2, int y2, int num)
        {
            double alpha = 0;
            double beta = Math.PI / 4;
            double lmin = 100.0;

            if (num != 0 && Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) > lmin)
            {
                double x3 = (x2 - x1) * Math.Cos(alpha) - (y2 - y1) * Math.Sin(alpha) + x1;
                double y3 = (x2 - x1) * Math.Sin(alpha) + (y2 - y1) * Math.Cos(alpha) + y1;
                double k = 0.2;
                double k1 = 0.5;

                double x4 = (1 - k) * x1 + k * x3;
                double y4 = (1 - k) * y1 + k * y3;

                double x5 = (1 - k1) * x3 + k1 * x4;
                double y5 = (1 - k1) * y3 + k1 * y4;

                double x6 = (x5 - x4) * Math.Cos(beta) - (y5 - y4) * Math.Sin(beta) + x4;
                double y6 = (x5 - x4) * Math.Sin(beta) + (y5 - y4) * Math.Cos(beta) + y4;

                double x7 = (x5 - x4) * Math.Cos(beta) + (y5 - y4) * Math.Sin(beta) + x4;
                double y7 = -(x5 - x4) * Math.Sin(beta) + (y5 - y4) * Math.Cos(beta) + y4;

                g.DrawLine(pen, x1, y1, (int)x4, (int)y4); // Drawing the trunk line

                Branch(g, pen, (int)x4, (int)y4, (int)x3, (int)y3, num); // Continuing the trunk
                Branch(g, pen, (int)x4, (int)y4, (int)x6, (int)y6, num - 1); // Right branch
                Branch(g, pen, (int)x4, (int)y4, (int)x7, (int)y7, num - 1); // Left branch

            }
        }

    }
}
