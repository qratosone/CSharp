using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoJudge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int a, b;
        string op;
        int result;
        bool flagP = false;
        bool flagT = false;
        Random rnd = new Random();

        private void rBtnPlusMinus_CheckedChanged(object sender, EventArgs e)
        {
            flagP = true;
            flagT = false;
        }

        private void rBtnTimes_CheckedChanged(object sender, EventArgs e)
        {
            flagP = false;
            flagT = true;
        }
        private void next()
        {
            a = rnd.Next(10);
            b = rnd.Next(10);
            if (flagP)
            {
                int c = rnd.Next(1);
                switch (c)
                {
                    case 0:
                        op = "+"; result = a + b; break;
                    case 1:
                        op = "-"; result = a - b; break;
                }
            }
            else if (flagT)
            {
                op = "*";
                result = a * b;
            }
            else
            {
                MessageBox.Show("请选择一种运算！");
            }
            string str = a.ToString() + op + b.ToString();
            lblShow.Text = str;
        }
        private void check_num()
        {
            int input_num = int.Parse(txtResult.Text);
            if (result == input_num)
            {
                MessageBox.Show("回答正确");
            }
            else
            {
                MessageBox.Show("回答错误");
            }
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            tmr.Enabled = this.Enabled;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                next();
            }
            else
            {
                check_num();
                next();
            }
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            tmr.Interval -= 1000;
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            tmr.Interval += 1000;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                next();
            }
            else
            {
                check_num();
                next();
            }
        }
    }
}
