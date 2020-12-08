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
    public partial class FormDateTime的常用方法 : Form
    {
        public FormDateTime的常用方法()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(1,0,0);
            dt = dt.Add(ts);
            label2.Text = dt.ToString();
            label5.Text = dt.Equals(DateTime.Now).ToString();
            label6.Text = dt.ToShortDateString();
            label8.Text = DateTime.Compare(dt, DateTime.Now).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label5.Text = "";
            label6.Text = "";
            label8.Text = "";
        }
    }
}
