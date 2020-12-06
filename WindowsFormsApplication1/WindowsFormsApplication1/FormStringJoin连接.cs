using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormStringJoin连接 : Form
    {
        public FormStringJoin连接()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strs = {textBox1.Text,textBox2.Text,textBox3.Text };
            string res = String.Join("|", strs);
            label6.Text = res;
        }

        private void button2_Click(object sender, EventArgs e)//重置
        {
            textBox1.Text = "字符串";
            textBox2.Text = "使用竖线";
            textBox3.Text = "连接";
            label6.Text = "";

        }
    }
}
