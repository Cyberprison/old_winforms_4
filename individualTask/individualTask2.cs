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
    public partial class individualTask2 : Form
    {
        public individualTask2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for(int i = 1000; i <= 9999; i++)
            {
                string s = Convert.ToString(i);
                int sumEdgeDigits = Convert.ToInt32(s[0]) + Convert.ToInt32(s[3]);
                int sumMiddleDigits = Convert.ToInt32(s[1]) + Convert.ToInt32(s[2]);

                if (sumEdgeDigits == sumMiddleDigits)
                {
                    if (i%6 == 0)
                    {
                        if (i%27 == 0)
                        {
                            textBox1.Text += i + "\r\n";
                        }
                    }
                }
            }
        }
    }
}
