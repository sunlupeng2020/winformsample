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
    public partial class FormStringBuilderMethod : Form
    {
        public FormStringBuilderMethod()
        {
            InitializeComponent();
        }

        private void FormStringBuilderMethod_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(tbxAppend.Text);
            lblAppendResult.Text = sb.ToString();
            int insertp = int.Parse(tbxOffset.Text);
            sb.Insert(insertp, tbxInsertStr.Text);
            lblInsertResult.Text = sb.ToString();
            int rmvp =int.Parse(tbxRmvPostion.Text);
            int rmvnum = int.Parse(tbxRmvNum.Text);
            sb.Remove(rmvp,rmvnum);
            lblRemoveResult.Text = sb.ToString();
            string strold = tbxOldValue.Text;
            string strnew = tbxNewValue.Text.ToString();
            sb.Replace(strold, strnew);
            lblReplaceResult.Text = sb.ToString();
            lblLength.Text = sb.Length.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            tbxAppend.Text = "abcde";
            tbxOffset.Text = "3";
            tbxInsertStr.Text = "aaa";
            tbxNewValue.Text = "b";
            tbxOldValue.Text = "a";
            tbxRmvPostion.Text = "3";
            tbxRmvNum.Text = "3";
            lblAppendResult.Text = "";
            lblInsertResult.Text = "";
            lblRemoveResult.Text = "";
            lblReplaceResult.Text = "";
            lblLength.Text = "";
        }
    }
}
