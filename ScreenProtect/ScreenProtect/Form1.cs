﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenProtect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int deltX = 10;
        int deltY = 8;



        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.label1.Left += deltX;
            this.label1.Top += deltY;
            if (this.label1.Top < 0 ||
                this.label1.Top + this.label1.Height > this.Height)
                deltY = -deltY;
            if (this.label1.Left < 0 ||
                this.label1.Left + this.label1.Width > this.Width)
                deltX = -deltX;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
