using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Task10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var g = CreateGraphics();
            g.Clear(Color.White);
            Fractal(g, int.Parse(AValue.Text), int.Parse(BValue.Text), 200, 200, int.Parse(KValue.Text));
        }
        void Fractal(Graphics g, int A, int B, int startX, int startY, int K)
        {
            if (K == 0) return;
            g.DrawLine(Pens.Black, startX, startY, startX + A, startY);
            g.DrawLine(Pens.Black, startX + A, startY, startX + A, startY + B);
            g.DrawLine(Pens.Black, startX + A, startY + B, startX, startY + B);
            g.DrawLine(Pens.Black, startX, startY, startX, startY + B);
            Fractal(g, A / 3, B / 3, startX, startY, K - 1);
            Fractal(g, A / 3, B / 3, startX + 2 * A / 3, startY, K - 1);
            Fractal(g, A / 3, B / 3, startX + A / 3, startY + B / 3, K - 1);
            Fractal(g, A / 3, B / 3, startX, startY + B * 2 / 3, K - 1);
            Fractal(g, A / 3, B / 3, startX + 2 * A / 3, startY + B * 2 / 3, K - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
