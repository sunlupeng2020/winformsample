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
    public partial class Form8timer : Form
    {
        public Form8timer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string text = lbShow.Text;
            int length = text.Length - 1;
            string first = text.Substring(0, 1);
            string last = text.Substring(1, length);
            lbShow.Text = last + first;
        }
    }
}
