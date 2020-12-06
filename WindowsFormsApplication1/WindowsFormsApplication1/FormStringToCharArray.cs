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
    public partial class FormStringToCharArray : Form
    {
        public FormStringToCharArray()
        {
            InitializeComponent();
        }

        private void btnStrRev_Click(object sender, EventArgs e)
        {
            label3.Text = ReverseString(textBox1.Text);
        }
        public static string ReverseString(string str)
        {
            char[] chs = str.ToCharArray();
            int len=chs.Length;
            for (int i = 0; i < len/2; i++)
            {
                char temp = chs[i];
                chs[i] = chs[len - i - 1];
                chs[len - i - 1] = temp;
            }
            return new string(chs);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "abcdefg";
            label3.Text = "";
        }
    }
}
