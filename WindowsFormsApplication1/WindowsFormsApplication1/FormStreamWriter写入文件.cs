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
    public partial class FormStreamWriter写入文件 : Form
    {
        public FormStreamWriter写入文件()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //创建文件流对象，如果文件不存在则创建文件
                StreamWriter sw = new StreamWriter(textBox1.Text.Trim());
                sw.Write(textBox2.Text.Trim());
                sw.Close();
                MessageBox.Show("写入成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //创建文件流对象，如果文件不存在则创建文件
                StreamWriter sw = new StreamWriter(textBox1.Text.Trim(),true);
                sw.Write(textBox2.Text.Trim());
                sw.Close();
                MessageBox.Show("写入成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "d:\data02.txt";
            textBox2.Text="StreamWriter写入文件。";
        }
    }
}
