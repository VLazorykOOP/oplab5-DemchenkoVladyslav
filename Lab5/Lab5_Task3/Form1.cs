using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Task3
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

        private PointF P1;
        private PointF P2;
        private int K;

        private void DrawingPanel_Paint()
        {
            this.CreateGraphics().Clear(Color.White);
            DrawDandelionFractal(this.CreateGraphics(), P1, P2, K);
        }

        private void DrawDandelionFractal(Graphics g, PointF P1, PointF P2, int K)
        {
            if (K == 0)
            {
                g.DrawLine(Pens.Black, P1, P2);
                return;
            }
                float dx = P2.X - P1.X;
                float dy = P2.Y - P1.Y;
                PointF P3 = new PointF(P1.X + dx / 3, P1.Y + dy / 3);
                PointF P4 = new PointF(P1.X + 2 * dx / 3, P1.Y + 2 * dy / 3);

                float angle = (float)(Math.PI / 3);
                PointF P5 = RotatePoint(P3, P4, angle);
                PointF P6 = RotatePoint(P3, P4, -angle);

                DrawDandelionFractal(g, P1, P3, K - 1);
                DrawDandelionFractal(g, P3, P5, K - 1);
                DrawDandelionFractal(g, P3, P6, K - 1);
                DrawDandelionFractal(g, P5, P4, K - 1);
                DrawDandelionFractal(g, P6, P4, K - 1);
                DrawDandelionFractal(g, P4, P2, K - 1);
        }

        private PointF RotatePoint(PointF origin, PointF point, float angle)
        {
            float cosAngle = (float)Math.Cos(angle);
            float sinAngle = (float)Math.Sin(angle);

            float dx = point.X - origin.X;
            float dy = point.Y - origin.Y;

            return new PointF(
                origin.X + (dx * cosAngle - dy * sinAngle),
                origin.Y + (dx * sinAngle + dy * cosAngle)
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P1 = new PointF(int.Parse(P1x.Text), int.Parse(P1y.Text));
            P2 = new PointF(int.Parse(P2x.Text), int.Parse(P2y.Text));
            K = int.Parse(kvalue.Text); 
            DrawingPanel_Paint();
        }
    }
}
