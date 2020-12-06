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
    public partial class FormStringSubstring : Form
    {
        public FormStringSubstring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            int index = path.IndexOf(".");
            lblExtendName.Text = path.Substring(index + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = @"d:\itcast\chapter7\program.cs";
        }
    }
}
