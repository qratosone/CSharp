using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int a, b,result;
        string op;

        private void BTN_Judge_Click(object sender, EventArgs e)
        {
            string str = InputResult.Text;
            double d = double.Parse(str);
            string disp = "" + a + op + b + "=" + str;
            if (d == result)
                disp += "  true";
            else
                disp += "  false";
            Result.Items.Add(disp);
        }

        Random rnd = new Random();
        private void BTN_New_Click(object sender, EventArgs e)
        {
            a = rnd.Next(9) + 1;
            b = rnd.Next(9) + 1;
            int c = rnd.Next(4);
            switch (c)
            {
                case 0:op = "+";result = a + b;break;
                case 1:op = "-";result = a - b;break;
                case 2:op = "*";result = a * b;break;
                case 3:op = "/";result = a / b;break;
            }
            label_a.Text = a.ToString();
            label_b.Text = b.ToString();
            label_op.Text = op;
            InputResult.Text = "";
        }

        
    }
}
