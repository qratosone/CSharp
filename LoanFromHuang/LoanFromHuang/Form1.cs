using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LoanFromHuang
{
    public partial class FrmMain : Form
    {
        private int BorrowCount = 0;
        private int LoanMoney = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            LoanFromHuang();
        }
        private void LoanFromHuang()
        {
            btnLoan.Enabled = true;
            LoanMoney = 0;
            btnLoan.Click += new EventHandler(btnLoan_Click);
            lblBorrow.Text = string.Format("{0}次", ++BorrowCount);
        }
        private void LoanMoneyCount()
        {
            btnLoan.Enabled = false;
            LoanMoney += 1;
            lblLoan.Text = string.Format("{0}秒", LoanMoney);
            lblLoan.Refresh();
            Thread.Sleep(100);
        }
        private void btnLoan_Click(object sender, EventArgs e)
        {
            LoanMoneyCount();
        }

        private void btnLoan_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naive!续命要按基本法，一次一秒");
        }
    }
}
