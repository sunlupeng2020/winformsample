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
    public partial class FormStringIndexOf : Form
    {
        public FormStringIndexOf()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str1 = textBox2.Text;
            int index = str.IndexOf(str1);
            label4.Text = string.Format("找到{0},索引为{1}", str1, index);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "abcdefefghefg";
            textBox2.Text = "e";
        }
    }
}
