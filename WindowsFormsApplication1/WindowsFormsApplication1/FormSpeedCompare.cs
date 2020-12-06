using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;//其中包含了用于计时的Stopwatch类

namespace WindowsFormsApplication1
{
    public partial class FormSpeedCompare : Form
    {
        public FormSpeedCompare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";

            Stopwatch sp = new Stopwatch();
            sp.Start();
            for (int i = 0; i < 10000; i++)
            {
                str += i.ToString();
            }
            sp.Stop();
            lblStringTime.Text = sp.Elapsed.ToString();
            StringBuilder sb = new StringBuilder();
            sp.Restart();
            for(int i=0;i<10000;i++)
            {
                sb.Append(i.ToString());
            }
            sp.Stop();
            lblStringBuildertime.Text = sp.Elapsed.ToString();
        }
    }
}
