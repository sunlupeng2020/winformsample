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
    public partial class FormStringToUpper : Form
    {
        public FormStringToUpper()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //字符串大小写转换
            lblupper.Text = textBox1.Text.ToUpper();
            lbllower.Text = textBox1.Text.ToLower();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbllower.Text = "";
            lblupper.Text = "";
            textBox1.Text = "ZhengZhou Normal University";
        }
    }
}
