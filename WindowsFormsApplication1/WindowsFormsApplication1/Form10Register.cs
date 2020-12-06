using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;//引入命名空间以访问Mysql数据库

namespace WindowsFormsApplication1
{
    public partial class Form10Register : Form
    {
        private void Form9Register_Load(object sender, EventArgs e)
        {
           
        }
        public Form10Register()
        {
            InitializeComponent();
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
                string name = tbxName.Text;
                string username = tbxUsername.Text;
                string pwd1 = tbxPwd1.Text;
                string pwd2 = tbxPwd2.Text;
                string email=tbxEmail.Text;
                if (pwd1 != pwd2)
                {
                    MessageBox.Show("两次输入的密码不一致！");
                    tbxPwd1.Text = tbxPwd2.Text = "";
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection();
                    conn.ConnectionString = "server=localhost;database=paper;user=root;password=;port=3306";
                    //创建命令对象
                    MySqlCommand cmd = conn.CreateCommand();
                    string sql = "insert into teacher(name,username,password,email)values('"+name+"','"+username+"','"+pwd1+"','"+email+"')";
                    cmd.CommandText = sql;
                    try
                    {
                        conn.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("注册成功！");
                        
                        }
                        else
                            MessageBox.Show("注册失败！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                
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
            }
        }

        private void tbxPwd2_MouseLeave(object sender, EventArgs e)
        {
            string pwd1 = tbxPwd1.Text;
            string pwd2 = tbxPwd2.Text;
            if (pwd1 != pwd2)
            {
                MessageBox.Show("两次输入的密码不一致！");
                //tbxPwd1.Text = tbxPwd2.Text = "";
            }
        }

    }
}
