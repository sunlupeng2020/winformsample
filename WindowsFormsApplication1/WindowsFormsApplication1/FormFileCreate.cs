using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApplication1
{
    public partial class FormFileCreate : Form
    {
        public FormFileCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Create(textBox1.Text);
            MessageBox.Show("文件创建成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                MessageBox.Show(textBox1.Text + "文件存在！");
            }
            else
            {
                MessageBox.Show(textBox1.Text + "文件不存在！");
            }

        }
    }
}
