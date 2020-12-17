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
    public partial class FormStreamReaderWriter文件读写 : Form
    {
        public FormStreamReaderWriter文件读写()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw=null;
            try
            {
                sw = new StreamWriter(textBox1.Text, true, Encoding.Default);//true表示Append，当文件存在时就追加，不存在时就创建。
                sw.WriteLine(textBox2.Text);
                sw.Close();
                MessageBox.Show("文件写入成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string temp;
            StreamReader sr=null;
            try
            {
                sr = new StreamReader(textBox1.Text, Encoding.Default);
                while ((temp = sr.ReadLine()) != null)
                {
                    textBox2.Text += temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
        }
    }
}
