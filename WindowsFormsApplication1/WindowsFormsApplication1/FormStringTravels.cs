using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class FormStringTravels : Form
    {
        public FormStringTravels()
        {
            InitializeComponent();
        }
        private void StringTravels()
        {
            String str1 = label1.Text;
            for (int i = 0; i < str1.Length; i++)
            {
                listBox1.Items.Add(i.ToString()+"、"+str1[i].ToString());
                //label2.Text = "";
                //label2.Text = str1[i].ToString();
                //Thread.Sleep(1000);  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringTravels();
        }

    }
}
