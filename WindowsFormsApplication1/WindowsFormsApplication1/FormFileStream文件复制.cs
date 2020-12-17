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
    public partial class FormFileStream文件复制 : Form
    {
        public FormFileStream文件复制()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string source = textBox1.Text.Trim();
                string target = textBox2.Text.Trim();
                using (FileStream fsRead = new FileStream(source, FileMode.Open))
                {
                    using (FileStream fsWrite = new FileStream(target, FileMode.Create))
                    {
                        //创建缓冲区
                        byte[] bytes = new byte[1024];
                        while (true)
                        {
                            int r = fsRead.Read(bytes, 0, bytes.Length);
                            if (r <= 0)
                            {
                                break;
                            }
                            fsWrite.Write(bytes, 0, bytes.Length);
                        }
                    }
                }
                MessageBox.Show("文件a内容已经写入文件b中！");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
