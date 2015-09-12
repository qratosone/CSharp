using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveBlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int N = 4;//按钮行列数
        Button[,] buttons = new Button[N, N];//按钮数组
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateAllButtons();//产生所有按钮
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            Shuffle();
        }
        void GenerateAllButtons()
        {
            int x0 = 100, y0 = 10, w = 45, d = 50;
            for(int r=0;r< N; r++)
            {
                for(int c=0;c< N; c++)
                {
                    int num = r * N + c;
                    Button btn = new Button();
                    btn.Text = (num + 1).ToString();
                    btn.Top = y0 + r * d;
                    btn.Left = x0 + c * d;
                    btn.Height = w;
                    btn.Width = w;
                    btn.Tag = r * N + c;
                    btn.Click += new EventHandler(btn_Click);//注册事件
                    buttons[r, c] = btn;
                    this.Controls.Add(btn);
                }
            }
            buttons[N - 1, N - 1].Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button BTN = sender as Button;
            Button blank = FindHiddenButton();
            if (IsNeighbor(BTN, blank))
            {
                Swap(BTN, blank);
                BTN.Focus();
            }
            if (ResultIsOK())
                MessageBox.Show("OK");
        }

        void Shuffle()
        {
            Random rnd = new Random();
            for(int i = 0; i < 100; i++)
            {
                int a = rnd.Next(N);
                int b = rnd.Next(N);
                int c = rnd.Next(N);
                int d = rnd.Next(N);
                Swap(buttons[a, b], buttons[c, d]);
            }
        }
        void Swap(Button BTNa,Button BTNb)
        {
            string t = BTNa.Text;
            BTNa.Text = BTNb.Text;
            BTNb.Text = t;
            bool V = BTNa.Visible;
            BTNa.Visible = BTNb.Visible;
            BTNb.Visible = V;
        }
        Button FindHiddenButton()
        {
            for(int r=0;r< N; r++)
            {
                for(int c=0;c< N; c++)
                {
                    if (!buttons[r, c].Visible)
                        return buttons[r, c];
                }
            }
            return null;
        }
        bool IsNeighbor(Button BTNa,Button BTNb)
        {
            int r_a = (int)BTNa.Tag / N;
            int r_b = (int)BTNb.Tag / N;
            int c_a = (int)BTNa.Tag % N;
            int c_b = (int)BTNb.Tag % N;
            if (r_a == r_b && (c_a - c_b == 1 || c_b - c_a == 1) || c_a == c_b && (r_a - r_b == 1 || r_b - r_a == 1))
                return true;
            else
                return false;
        }
        bool ResultIsOK()
        {
            for(int r=0;r< N; r++)
            {
                for(int c=0;c< N; c++)
                {
                    if (buttons[r, c].Text !=( r * N + c).ToString())
                        return false;
                }
            }
            return true;
        }
    }
}
