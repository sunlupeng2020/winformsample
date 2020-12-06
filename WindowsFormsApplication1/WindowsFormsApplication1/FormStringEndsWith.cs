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
    public partial class FormStringEndsWith : Form
    {
        public FormStringEndsWith()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.EndsWith(".mp3"))
            {
                MessageBox.Show("文件格式正确！");
            }
            else
            {
                MessageBox.Show("输入文件不是mp3格式");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "与中原一同崛起.mp3";
        }
    }
}
