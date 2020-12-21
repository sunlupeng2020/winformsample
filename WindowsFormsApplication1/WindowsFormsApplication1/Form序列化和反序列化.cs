using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public partial class Form序列化和反序列化 : Form
    {
        public Form序列化和反序列化()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = textBox1.Text;
            p.Age = int.Parse(textBox2.Text);
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("persondata.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                bf.Serialize(fs,p);
                MessageBox.Show("序列化成功！对象已写入文件persondata.txt！");
            }

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    FileStream sFile = new FileStream("persondata.txt", FileMode.Open);
        //    StreamReader sr = new StreamReader(sFile);
        //    string line = sr.ReadLine();
        //    while (line != null)
        //    {
        //        textBox3.Text += line;
        //        line = sr.ReadLine();
        //    }
        //    sr.Close();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            using (FileStream fs1 = new FileStream("persondata.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                BinaryFormatter bf=new BinaryFormatter();
                object obj = bf.Deserialize(fs1);
                label3.Text = obj.ToString();
            }
        }
    }
}
