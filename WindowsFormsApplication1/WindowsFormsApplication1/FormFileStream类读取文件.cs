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
    public partial class FormFileStream类读取文件 : Form
    {
        public FormFileStream类读取文件()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] byteData = new byte[1024];
            char[] charData = new char[1024];
            try
            {
                using (FileStream aFile = new FileStream(textBox1.Text, FileMode.Open))
                {
                    aFile.Seek(0, SeekOrigin.Begin);
                    aFile.Read(byteData, 0, 1024);
                }
                Decoder d = Encoding.Default.GetDecoder();
                d.GetChars(byteData, 0, byteData.Length, charData, 0);
                string s = new string(charData);
                textBox2.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
