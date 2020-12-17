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
    public partial class FormBufferedStream : Form
    {
        public FormBufferedStream()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxAfter.Text = "";
            tbxBefore.Text = "";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream myStream1, myStream2;
            BufferedStream myBStream1, myBStream2;
            byte[] myByte = new byte[1024];
            Print("data2.txt");
            myStream1 = File.OpenRead("data1.txt");
            myStream2 = File.OpenWrite("data2.txt");
            myBStream1 = new BufferedStream(myStream1);
            myBStream2 = new BufferedStream(myStream2);
            int i=myBStream1.Read(myByte,0,1024);
            while (i > 0)
            {
                myBStream2.Write(myByte, 0, i);
                i = myStream1.Read(myByte, 0, 1024);
            }
            myBStream2.Flush();
            myStream1.Close();
            myStream2.Close();
            Print2("data2.txt");
        }
        private void Print(string path)
        {
            using(StreamReader sr=new StreamReader(path,Encoding.Default))
            {
                string content=sr.ReadToEnd();
                tbxBefore.Text = content;
            }
        }
        private void Print2(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string content = sr.ReadToEnd();
                tbxAfter.Text = content;
            }
        }
    }
}
