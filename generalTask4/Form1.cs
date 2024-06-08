using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generalTask4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);

            double a = (-1.0) / 2.0;
            double s = 0;

            for (int i = 1; i <= n; i++)
            {
                s += a;
                a *= (-1.0) / ((i + 1) * (i + 2));
            }

            textBox3.Text = Convert.ToString(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eps = Convert.ToDouble(textBox2.Text);

            double a = (-1.0) / 2.0;
            double s = 0;

            int i = 1;

            do
            {
                s += a;
                a *= (-1.0) / ((i + 1) * (i + 2));
                i++;
            } while (Math.Abs(a) > eps);

            textBox3.Text = Convert.ToString(a);
        }
    }
}
