using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePendulumAllCases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dampedDriverPendulumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eulerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 300;
            double[] w = new double[size];
            double[] th = new double[size];
            double[] t = new double[size];

            w[0] = 0.1;
            th[0] = 0.2;

            double g = 9.8, l = 1, dt = 0.05;

            for (int i = 0; i < size - 1; i++)
            {
                w[i+1] = w[i] - ( g / l ) * th[i] * dt;
                th[i + 1] = th[i] + w[i] * dt;
                t[i + 1] = t[i] + dt;
            }

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);

            for (int i = 0; i < size-1; i++)
            {
                gg.FillEllipse(sb, 50 + (float)t[i]*25, 250 - (float)th[i]*20, 5, 5);
            }
        }

        private void eulerCromerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 300;
            double[] w = new double[size];
            double[] th = new double[size];
            double[] t = new double[size];

            w[0] = 0.1;
            th[0] = 0.2;

            double g = 9.8, l = 1, dt = 0.05;

            for (int i = 0; i < size - 1; i++)
            {
                w[i + 1] = w[i] - (g / l) * th[i] * dt;
                th[i + 1] = th[i] + w[i+1] * dt;
                t[i + 1] = t[i] + dt;
            }

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Blue);

            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 50 + (float)t[i] * 25, 250 - (float)th[i] * 30, 5, 5);
            }
        }

        private void eulerFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int size = 300;
            double[] w = new double[size];
            double[] th = new double[size];
            double[] t = new double[size];

            w[0] = 0.1;
            th[0] = 0.2;

            //double g = 9.8, l = 1, dt = 0.05, q = 1.5;
            double g = 9.8, l = 1, dt = 0.05;
            double q = double.Parse(textBox1.Text);

            for (int i = 0; i < size - 1; i++)
            {
                w[i + 1] = w[i] - (g / l) * th[i] * dt - q * w[i] * dt;
                th[i + 1] = th[i] + w[i] * dt;
                t[i + 1] = t[i] + dt;
            }

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);

            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 50 + (float)t[i] * 25, 250 - (float)th[i] * 150, 5, 5);
            }
        }

        private void eulerCromerFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int size = 300;
            double[] w = new double[size];
            double[] th = new double[size];
            double[] t = new double[size];

            w[0] = 0.1;
            th[0] = 0.2;

            //double g = 9.8, l = 1, dt = 0.05, q =10;
            //double g = 9.8, l = 1, dt = 0.05, q = 1.5;
            double g = 9.8, l = 1, dt = 0.05;
            double q = double.Parse(textBox1.Text);

            for (int i = 0; i < size - 1; i++)
            {
                w[i + 1] = w[i] - (g / l) * th[i] * dt - q * w[i] * dt;
                th[i + 1] = th[i] + w[i+1] * dt;
                t[i + 1] = t[i] + dt;
            }

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Blue);

            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 50 + (float)t[i] * 25, 250 - (float)th[i] * 150, 5, 5);
            }
        }

        private void eulerFormToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int size = 300;
            double[] w = new double[size];
            double[] th = new double[size];
            double[] t = new double[size];

            w[0] = 0.1;
            th[0] = 0.2;

            //double g = 9.8, l = 1, dt = 0.05, q = 1.5, fd = 0, od = 2 ;
            //double g = 9.8, l = 1, dt = 0.05, q = 1.5, fd = 0.5, od = 2;
            //double g = 9.8, l = 1, dt = 0.05, q = 1.5, fd = 1.2, od = 2;
            double g = 9.8, l = 1, dt = 0.05, fd = 1.2, od = 2;
            double q = double.Parse(textBox1.Text);


            for (int i = 0; i < size - 1; i++)
            {
                w[i + 1] = w[i] - (g / l) * th[i] * dt - q * w[i] * dt + fd * Math.Sin(od * t[i]) * dt;
                th[i + 1] = th[i] + w[i] * dt;
                t[i + 1] = t[i] + dt;
            }

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);

            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 50 + (float)t[i] * 25, 250 - (float)th[i] * 150, 5, 5);
            }
        }

        private void eulerCromerFormToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int size = 300;
            double[] w = new double[size];
            double[] th = new double[size];
            double[] t = new double[size];

            w[0] = 0.1;
            th[0] = 0.2;

            //double g = 9.8, l = 1, dt = 0.05, q = 1.5, fd = 0, od = 2 ;
            //double g = 9.8, l = 1, dt = 0.05, q = 1.5, fd = 0.5, od = 2;
            //double g = 9.8, l = 1, dt = 0.05, q = 1.5, fd = 1.2, od = 2;
            double g = 9.8, l = 1, dt = 0.05, fd = 1.2, od = 2;
            double q = double.Parse(textBox1.Text);

            for (int i = 0; i < size - 1; i++)
            {
                w[i + 1] = w[i] - (g / l) * th[i] * dt - q * w[i] * dt + fd * Math.Sin(od * t[i]) * dt;
                th[i + 1] = th[i] + w[i+1] * dt;
                t[i + 1] = t[i] + dt;
            }

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Blue);

            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 50 + (float)t[i] * 25, 250 - (float)th[i] * 150, 5, 5);
            }
        }

        private void dampedPendulumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
