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
    public partial class FormStreamReader读取文件 : Form
    {
        public FormStreamReader读取文件()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string line;
            string path = textBox1.Text.Trim();
            try
            {
                FileStream aFile = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                line = sr.ReadLine();
                while (line != null)
                {
                    textBox2.Text += line;
                    line = sr.ReadLine();
                }
                sr.Close();//关闭流对象
            }
            catch (IOException ex)//
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
