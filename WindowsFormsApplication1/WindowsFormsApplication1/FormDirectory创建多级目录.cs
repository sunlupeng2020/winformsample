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
    public partial class FormDirectory创建多级目录 : Form
    {
        public FormDirectory创建多级目录()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(tbxDirectoryInfo.Text.Trim());
                MessageBox.Show("目录创建成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbxDirectoryInfo.Text.Trim()))
            {
                MessageBox.Show("目录存在！");
            }
            else
            {
                MessageBox.Show("目录不存在！");
            }
        }

        private void btndeletedir_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(tbxDirectoryInfo.Text.Trim());
                MessageBox.Show("目录删除成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
