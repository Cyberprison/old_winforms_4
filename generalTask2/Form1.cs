using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generalTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "x \t y \r\n";

            for(double x = (-1.0)*Math.PI; x <= Math.PI; x += Math.PI/6.0)
            {
                textBox1.Text += String.Format("{0, 10:F3} \t {1, 10:F3}\r\n", x, 2 * Math.Cos(x));
            }
        }
    }
}
