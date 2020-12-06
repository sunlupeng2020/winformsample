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
    public partial class FormStringTrim : Form
    {
        public FormStringTrim()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 去掉两端空格_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str1 = str.Substring(1, str.Length - 2);
            lbltrim.Text = "["+str1.Trim()+"]";
        }

        private void 重置_Click(object sender, EventArgs e)
        {
            textBox1.Text = "[     ab     bc      ]";
            lbltrim.Text = "";
        }
    }
}
