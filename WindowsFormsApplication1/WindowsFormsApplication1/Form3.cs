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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rdMale.Checked = true;
        }

        private void btnRegi_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Control item in this.Controls)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                MessageBox.Show("请确定已填写全部信息！");
            }
            else
            {
                MessageBox.Show("注册成功！");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is RadioButton)
                {
                    RadioButton r = (RadioButton)item;
                    r.Checked = false;
                }
            }
            rdMale.Checked = true;
        }
    }
}
