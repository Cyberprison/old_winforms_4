﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generalTask5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;

            progressBar1.Visible = true;
            progressBar1.Maximum = b;

            bool flagNumberHasTips;
            double tipsDivNumber;
            int countSimpleNumber = 0;
            textBox1.Clear();
            textBox2.Clear();

            for (int i = a; i <= b; i++)
            {
                flagNumberHasTips = true;

                for (int j = 2; j <= i - 1; j++)
                {
                    tipsDivNumber = i % j;
                    if (tipsDivNumber == 0)
                    {
                        flagNumberHasTips = false;
                        break;
                    }
                }

                if (flagNumberHasTips == true)
                {
                    countSimpleNumber++;
                    textBox2.Text += Convert.ToString(i) + "\t\r\n";
                }

                progressBar1.Value = i;
            }

            textBox1.Text = Convert.ToString(countSimpleNumber);

            progressBar1.Visible = false;

        }
    }
}
