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
    public partial class FormString类的构造方法 : Form
    {
        public FormString类的构造方法()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] chs = { '1', '2', '3' };
            String str1 = new string(chs);
            string str2 = new string('a', 5);
            label1.Text = str1;
            label2.Text = str2;
        }
    }
}
