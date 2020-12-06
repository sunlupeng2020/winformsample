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
    public partial class FormString空或Empty判断 : Form
    {
        public FormString空或Empty判断()
        {
            InitializeComponent();
        }

        private void FormString空或Empty判断_Load(object sender, EventArgs e)
        {
            string s1 = null;
            string s2 = "";
            string s3 = "abc";
            label2.Text = "string s1 = null;\nstring s2 = \"\";\nstring s3 = \"abc\";";
            label1.Text = "";
            label1.Text += Check(s1, "s1")+"\n";
            label1.Text += Check(s2, "s2") + "\n";
            label1.Text += Check(s3, "s3");

        }
        private string Check(string s, string name)
        {
            if(string.IsNullOrEmpty(s))
            {
                return String.Format("{0}为空或长度为0",name);
            }
            else
                return String.Format("{0}不为空",name);
        }
    }
}
