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
    public partial class FormTimeSpan构造方法 : Form
    {
        public FormTimeSpan构造方法()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan tsl = new TimeSpan(1, 2, 3);
            label1.Text = tsl.ToString();
            TimeSpan ts2 = new TimeSpan(1, 2, 3, 4,5);
            label2.Text = ts2.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }
    }
}
