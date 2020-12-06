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
    public partial class Form11Login : Form
    {
        public Form11Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtName.Text == "itcast" && txtPassword.Text == "123")
                {
                    MessageBox.Show("登陆成功！");
                }
                else
                {
                    MessageBox.Show("用户名或密码有错！");
                    txtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
        }
    }
}
