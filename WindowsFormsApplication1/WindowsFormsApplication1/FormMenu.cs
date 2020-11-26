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
    public partial class FormMenu : Form
    {
        private Form form1=new Form();
        public FormMenu()
        {
            InitializeComponent();
        }
        private void DisposeForm1()
        {
            try
            {
                form1.Close();
                form1.Dispose();
            }
            catch
            {
            }
            finally
            {

            }
        }
        private void 案例一按钮游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            this.form1 = new Form1();
            form1.Show();
        }

        private void 案例二用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            form1 = new Form2();
            form1.Show();
        }

        private void 案例三用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            form1 = new Form3();
            form1.Show();
        }

        private void 案例四歌曲列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            form1 = new Form4();
            form1.Show();
        }

        private void 案例五省市联动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            form1 = new Form5();
            form1.Show();
        }

        private void 案例六单选试题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            form1 = new Form6();
            form1.Show();
        }

        private void 案例七学院结构ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            form1 = new Form7Treeview();
            form1.Show();
        }
    }
}
