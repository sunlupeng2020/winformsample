using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormStringAsCharArray : Form
    {
        public FormStringAsCharArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string huanying=textBox1.Text;
            label2.Text = huanying[0].ToString();
            label3.Text = huanying[1].ToString();
            label4.Text = textBox1.Text[2].ToString();
            label5.Text = huanying[3].ToString();
            label6.Text = huanying[4].ToString();
        }
    }
}
