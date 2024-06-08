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
    public partial class individualTask1 : Form
    {
        public individualTask1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double n = Convert.ToDouble(textBox3.Text);
            double m = Convert.ToDouble(textBox4.Text);
            double h = Convert.ToDouble(textBox5.Text);

            textBox6.Clear();

            textBox6.Text = "x \t y \r\n";

            for (double i = n; i <= -4; i += h)
            {
                textBox6.Text += String.Format("{0, 10:F3} \t {1, 10:f3} \r\n", i, a * Math.Cos(i + Math.PI * i));
            }

            for (double i = -4 + h; i <= 4; i += h)
            {
                textBox6.Text += String.Format("{0, 10:F3} \t {1, 10:f3} \r\n", i, Math.Abs(a - b * Math.Exp(a * i) + 3));
            }

            for (double i = 4 + h; i <= m; i += h)
            {
                textBox6.Text += String.Format("{0, 10:F3} \t {1, 10:f3} \r\n", i, i - 4);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
