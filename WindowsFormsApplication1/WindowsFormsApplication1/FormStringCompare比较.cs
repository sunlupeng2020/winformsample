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
    public partial class FormStringCompare比较 : Form
    {
        public FormStringCompare比较()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "abcdefg";
            textBox2.Text = "abc";
            textBox3.Text = "bbc";
            textBox4.Text = "abc";

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            label9.Text = string.Compare(textBox2.Text, textBox1.Text).ToString();
            label10.Text = string.Compare(textBox3.Text, textBox2.Text).ToString();
            label11.Text=string.Compare(textBox4.Text, textBox2.Text).ToString();
        }
        string StringCompare(String str1, string str2)
        {
            int cmp=string.Compare(str1, str2);
            if (cmp > 0)
            {
                return "大于";
            }
            else if (cmp == 0)
                return "相等";
            else
                return "小于";
        }
    }
}
