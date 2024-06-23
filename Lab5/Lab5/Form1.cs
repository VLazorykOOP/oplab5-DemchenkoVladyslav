using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void DrawHermiteCurve()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, new Point(pictureBox1.Width / 2, 0), new Point(pictureBox1.Width / 2, pictureBox1.Height));
            g.DrawLine(p, new Point(0, pictureBox1.Height / 2), new Point(pictureBox1.Width, pictureBox1.Height / 2));

            for (int i = (int)-Math.Max((pictureBox1.Width - pictureBox1.Width / 2), pictureBox1.Width / 2); i <= Math.Max((pictureBox1.Width - pictureBox1.Width / 2), pictureBox1.Width / 2); i++)
            {
                g.DrawLine(p, new Point(pictureBox1.Width / 2 + 10 * i, pictureBox1.Height / 2 - 5), new Point(pictureBox1.Width / 2 + 10 * i, pictureBox1.Height / 2 + 5));
            }
            for (int i = (int)-Math.Max((pictureBox1.Height - pictureBox1.Height / 2), pictureBox1.Height / 2); i <= Math.Max((pictureBox1.Height - pictureBox1.Height / 2), pictureBox1.Height / 2); i++)


            {
                g.DrawLine(p, new Point(pictureBox1.Width / 2 - 5, pictureBox1.Height / 2 + 10 * i), new Point(pictureBox1.Width / 2 + 5, pictureBox1.Height / 2 + 10 * i));
            }

            try
            {
                PointF P1 = new PointF(int.Parse(P1x.Text), int.Parse(P1y.Text));
                PointF P2 = new PointF(int.Parse(P2x.Text), int.Parse(P2y.Text));
                PointF V1 = new PointF(int.Parse(Q2x.Text), int.Parse(Q2y.Text));
                PointF V2 = new PointF(int.Parse(Q2x.Text), int.Parse(Q2y.Text));

                DrawHermite(g, P1, P2, V1, V2);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void DrawHermite(Graphics g, PointF P1, PointF P2, PointF V1, PointF V2)
        {
            int steps = 100;
            PointF[] points = new PointF[steps + 1];

            for (int i = 0; i <= steps; i++)
            {
                float t = (float)i / steps;
                points[i] = CalculateHermitePoint(t, P1, P2, V1, V2);
            }

            g.DrawLines(Pens.Black, points);
        }

        private PointF CalculateHermitePoint(float t, PointF P1, PointF P2, PointF V1, PointF V2)
        {
            float h1 = 2 * t * t * t - 3 * t * t + 1;
            float h2 = -2 * t * t * t + 3 * t * t;
            float h3 = t * t * t - 2 * t * t + t;
            float h4 = t * t * t - t * t;

            float x = h1 * P1.X + h2 * P2.X + h3 * V1.X + h4 * V2.X;
            float y = h1 * P1.Y + h2 * P2.Y + h3 * V1.Y + h4 * V2.Y;

            return new PointF(pictureBox1.Width / 2 + x, pictureBox1.Height / 2 - y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawHermiteCurve();
        }
    }
}
