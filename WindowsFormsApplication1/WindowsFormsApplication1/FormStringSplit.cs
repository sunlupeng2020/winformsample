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
    public partial class FormStringSplit : Form
    {
        public FormStringSplit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(textBox1.Text.Split(' '));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "I have a dream";
            listBox1.Items.Clear();
        }
    }
}
