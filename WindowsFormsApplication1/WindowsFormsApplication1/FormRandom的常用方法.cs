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
    public partial class FormRandom的常用方法 : Form
    {
        public FormRandom的常用方法()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd=new Random();
            label2.Text = rd.Next().ToString();
            label4.Text = rd.Next(10).ToString();
            label6.Text = rd.Next(10, 20).ToString();
            label8.Text = rd.NextDouble().ToString();
        }
    }
}
