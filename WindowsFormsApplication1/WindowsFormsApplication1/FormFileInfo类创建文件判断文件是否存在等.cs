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
    public partial class FormFileInfo类创建文件判断文件是否存在等 : Form
    {
        public FormFileInfo类创建文件判断文件是否存在等()
        {
            InitializeComponent();
        }

        private void filecurrentPath_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo aFile = new FileInfo(tbxFilePathandName.Text.Trim());
                aFile.Create();
                MessageBox.Show("文件创建成功！");
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
                FileInfo aFile = new FileInfo(tbxFilePathandName.Text.Trim());
                if (aFile.Exists)
                {
                    MessageBox.Show(tbxFilePathandName.Text + "文件存在！");
                    filecurrentPath.Text = aFile.Directory.ToString();
                    lblFileSize.Text = aFile.Length.ToString() + "字节";
                }
                else
                {
                    MessageBox.Show(tbxFilePathandName.Text + "文件不存在！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
