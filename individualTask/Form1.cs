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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            individualTask1 individualTask1 = new individualTask1();
            individualTask1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            individualTask2 individualTask2 = new individualTask2();
            individualTask2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            individualTask3 individualTask3 = new individualTask3();
            individualTask3.Show();
        }
    }
}
