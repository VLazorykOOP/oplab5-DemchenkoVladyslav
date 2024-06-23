using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Task8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startX = 300;
        int startY = 300;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(KValue.Text, out int K) || !int.TryParse(AValue.Text, out int A) || !int.TryParse(BValue.Text, out int B))
            {
                MessageBox.Show("Введіть коректні числові значення для K, A та B.");
                return;
            }

            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            DrawArchimedesTree(g, K, A, B, new Point(startX, startY), 90);
        }

        private void DrawArchimedesTree(Graphics g, int K, int A, int B, Point start, int angle)
        {
            if (K == 0) return;

            // Початкові координати та розміри прямокутника

            float width = A;
            float height = B;
            Point[] points = new Point[] { start, new Point(start.X, start.Y - B), new Point(start.X + A, start.Y - B), new Point(start.X + A, start.Y) };
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = RotatePoint(points[i], start, angle - 90);
            }
            g.DrawPolygon(Pens.Black, points);

            DrawArchimedesTree(g, K - 1, (int)(Math.Sqrt(A * A / 2)), (int)(Math.Sqrt(B * B / 2)), points[1], angle - 45);
            DrawArchimedesTree(g, K - 1, (int)(Math.Sqrt(A * A / 2)), (int)(Math.Sqrt(B * B / 2)), RotatePoint(new Point(points[1].X + (int)(Math.Sqrt(A * A / 2)), points[1].Y), points[1], angle - 135), angle + 45);
        }
        public Point RotatePoint(Point a, Point b, int angle)
     => new Point(
         (int)((a.X - b.X) * Math.Cos(Math.PI * angle / 180.0) - (a.Y - b.Y) * Math.Sin(Math.PI * angle / 180.0) + b.X
         ),
         (int)((a.X - b.X) * Math.Sin(Math.PI * angle / 180.0) + (a.Y - b.Y) * Math.Cos(Math.PI * angle / 180.0) + b.Y
         ));
    }
}
