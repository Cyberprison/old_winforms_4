using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individualTask
{
    public partial class individualTask3 : Form
    {
        public individualTask3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double start = 0.1;
            double end = 1.0;

            double epsilon = 10e-4;
            
            textBox1.Clear();
            textBox1.Text = "x \t y \t s \t абсолют \t относит \r\n";
            
            double h = Convert.ToDouble(textBox2.Text);

            for (double x = start; x <= end; x += h)
            {
                double y = Math.Pow(3.0, x);
                textBox1.Text += String.Format("{0, 10:F3} \t {1, 10:F3} \t", x, y);

                double s = 1.0;
                double a = Math.Log(3.0) * x;
                double n = 1.0;

                do
                {
                    s += a;
                    a *= Math.Log(3.0) * x / (n + 1.0);
                    n++;

                } while (Math.Abs(a) > epsilon && x <= end);

                textBox1.Text += String.Format("{0, 10:F3} \t {1, 10:F3} \t {2, 10:F3} \r\n", s, Math.Abs(s - y), Math.Abs(s - y)/s);
            }
        }
    }
}
