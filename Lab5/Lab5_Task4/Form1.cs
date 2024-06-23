using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Task4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public static float CrossProductLength(PointF A, PointF B, PointF C)
        {
            float BAx = A.X - B.X;
            float BAy = A.Y - B.Y;
            float BCx = C.X - B.X;
            float BCy = C.Y - B.Y;
            return (BAx * BCy - BAy * BCx);
        }

        private void DrawKochFractal(Graphics g, PointF P1, PointF P2, PointF PControl, int K)
        {
            if (K == 0)
            {
                g.DrawLine(Pens.Black, P1, P2);
            }
            else
            {
                float dx = P2.X - P1.X;
                float dy = P2.Y - P1.Y;

                PointF P3 = new PointF(P1.X + dx / 3, P1.Y + dy / 3);
                PointF P4 = new PointF(P1.X + 2 * dx / 3, P1.Y + 2 * dy / 3);

                float angle = (float)(Math.PI / 3) * Math.Sign(CrossProductLength(P1,P2,PControl));

                float cosAngle = (float)Math.Cos(angle);
                float sinAngle = (float)Math.Sin(angle);

                PointF P5 = new PointF(
                    P3.X + (dx / 3) * cosAngle - (dy / 3) * sinAngle,
                    P3.Y + (dx / 3) * sinAngle + (dy / 3) * cosAngle
                );

                DrawKochFractal(g, P1, P3, PControl, K - 1);
                DrawKochFractal(g, P3, P5, PControl, K - 1);
                DrawKochFractal(g, P5, P4, PControl, K - 1);
                DrawKochFractal(g, P4, P2, PControl, K - 1);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Point p1 = new Point(int.Parse(P1x.Text), int.Parse(P1y.Text));
            Point p2 = new Point(int.Parse(P2x.Text), int.Parse(P2y.Text));
            Point p3 = new Point(int.Parse(P3x.Text), int.Parse(P3y.Text));
            var g = CreateGraphics();
            g.Clear(Color.White);
            DrawKochFractal(g, p1, p2, p3, int.Parse(kvalue.Text));
            DrawKochFractal(g, p2, p3, p1, int.Parse(kvalue.Text));
            DrawKochFractal(g, p1, p3, p2, int.Parse(kvalue.Text));
        }
    }
}
