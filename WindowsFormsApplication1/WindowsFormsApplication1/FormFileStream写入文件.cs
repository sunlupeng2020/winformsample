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
    public partial class FormFileStream写入文件 : Form
    {
        public FormFileStream写入文件()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] byteData;
            char[] charData;
            //FileStream aFile = new FileStream(tbxFileName.Text.Trim(), FileMode.Create);
            try
            {
                //创建FileStream对象，并使用using关键字包含执行代码

                using (FileStream aFile = new FileStream(tbxFileName.Text.Trim(), FileMode.Create))
                {
                    //写一段字符串并使用ToCharArray()方法转换为字符存储到字符数组中
                    charData = textBox2.Text.ToCharArray();
                    //textBox2.Text += charData.Length.ToString();
                    //byteData = new byte[charData.Length];
                    //得到字符数组所占字节数
                    int count = Encoding.Default.GetByteCount(charData);//此处有改动
                    byteData = new byte[count];//得到文字的字节数
                    Encoder enc = Encoding.Default.GetEncoder();
                    //使用Encoder类实现将字符数组转换为字节数组
                    //enc.GetBytes(charData, 0, charData.Length, byteData, 0, true);
                    enc.GetBytes(charData, 0, charData.Length, byteData, 0, true);
                    //文件指针指向文件开始位置
                    //aFile.Seek(0, SeekOrigin.Begin);
                    //开始将字节数组中的数据写入文件
                    aFile.Write(byteData, 0, byteData.Length);
                }
                MessageBox.Show("文件写入成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "文件操作异常！");
            }
        }
    }
}
