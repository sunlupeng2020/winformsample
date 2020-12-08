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
    public partial class FormRandom构造方法和生成随机数 : Form
    {
        public FormRandom构造方法和生成随机数()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rd.Next().ToString());
            }
            Random rd2 = new Random(10);
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(rd2.Next());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rd2 = new Random(10);
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(rd2.Next());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
