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
    public partial class FormPath类的静态方法 : Form
    {
        public FormPath类的静态方法()
        {
            InitializeComponent();
        }

        private void btnModifyExtend_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text.Trim();
            //修改文件扩展名
            lblAftermodifyextend.Text = Path.ChangeExtension(path, textBox2.Text.Trim());

        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            //合并目录与文件名信息
            lblCombinePath.Text = Path.Combine(textBox3.Text, textBox4.Text);
        }

        private void btnGetPathInfo_Click(object sender, EventArgs e)
        {

            string path = textBox1.Text.Trim();
            //获取文件路径的目录信息，不包括文件名
            lblFilePathinfo.Text = Path.GetDirectoryName(path);
            //获取文件扩展名
            lblFileExtention.Text = Path.GetExtension(path);
        }

        private void button1_Click(object sender, EventArgs e)//获取文件名
        {
            string path = textBox1.Text.Trim();
            //lblFilenameNoextend.Text = Path.GetDirectoryName(path);
            lblFilename.Text = Path.GetFileName(path);
            lblFilenameNoextend.Text = Path.GetFileNameWithoutExtension(path);

        }

        private void gtnGetExtention_Click(object sender, EventArgs e)//获取文件扩展名
        {
            string path = textBox1.Text.Trim();
            lblFileExtention.Text = Path.GetExtension(path);
            //lblFilename.Text = Path.GetFileName(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblAbsolutePath.Text = Path.GetFullPath(textBox4.Text);
        }
    }
}
