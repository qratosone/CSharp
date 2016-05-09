using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CETWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Filename = "";
        List<string> English = new List<string>();
        List<string> Chinese = new List<string>();
        int counter = 0;
        int maxline = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openWords.ShowDialog()==DialogResult.OK)
                {
                    Filename = this.openWords.FileName;
                }
 //               MessageBox.Show(Filename);
                StreamReader sr = new StreamReader(Filename, Encoding.Default);
                English.Clear();
                Chinese.Clear();
                counter = 0;
                string content = sr.ReadToEnd();
                string[] lines = content.Split('\n');
                maxline = lines.Length;
                for (int i = 0; i < maxline; i++)
                {
                    if (lines[i]=="")
                    {
                        continue;
                    }
                    string[] words = lines[i].Trim().Split('\t');
                    English.Add(words[0]);
                    Chinese.Add(words[1]);
                }
                timer1.Enabled = true;
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("文件不合法！");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblChinese.Text = Chinese[counter];
            lblWords.Text = English[counter];
            if (counter<maxline-1)
            {
                counter++;
            }
            else
            {
                counter = 0;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int new_interval = Convert.ToInt32(txtSpeed.Text);
            if (new_interval>0&&new_interval<60)
            {
                timer1.Interval = new_interval*1000;
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("取值不合法！");
            }
        }
    }
}
