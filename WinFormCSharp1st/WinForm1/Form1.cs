﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double result = Math.Sqrt(a);
            label1.Text = a+"的平方根是"+result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
