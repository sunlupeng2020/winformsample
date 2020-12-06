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
    public partial class FormStringContains : Form
    {
        public FormStringContains()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            if (str1.Contains(str2))
            {
                label4.Text = "str2包含在str1中";
            }
            else
            {
                label4.Text = "str1不包含str2";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "这是一个测试字符串。";
            textBox2.Text = "测试";
            label4.Text = "";
        }
    }
}
