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
    public partial class FormDirectoryInfo属性 : Form
    {
        public FormDirectoryInfo属性()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = textBox1.Text;
                DirectoryInfo di = new DirectoryInfo(path);
                di.Create();
                MessageBox.Show("目录创建成功！");
                lblParentName.Text = di.Parent.ToString();
                lblDirectoryName.Text = di.Name;
                label5.Text = di.Root.ToString();
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
                string path = textBox1.Text.Trim();
                DirectoryInfo di1 = new DirectoryInfo(path);
                FileInfo[] files = di1.GetFiles("*a*");
                foreach (var item in files)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
