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
    public partial class FormDateTime构造方法 : Form
    {
        public FormDateTime构造方法()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(2020, 12, 9) ;
            label1.Text = dt1.ToString();
            DateTime dt2 = new DateTime(2020, 12, 9, 23, 34, 56);
            label2.Text = dt2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }
    }
}
