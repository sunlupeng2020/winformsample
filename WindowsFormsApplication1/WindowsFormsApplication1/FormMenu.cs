using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormMenu : Form
    {
        public static Teacher teacher;
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
                //form1.Dispose();
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

        private void 案例八走马灯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            form1 = new Form8timer();
            form1.Show();
        }

        private void 案例九英雄血条ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeForm1();
            form1 = new Form9ProgressBar();
            form1.Show();
        }

        private void 访问数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();                
        }

        private void 写入数据库注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10Register form10 = new Form10Register();
            form10.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void 读取数据库C语言章节联动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void 用户登录读取数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11Login form11 = new Form11Login();
            form11.Show();
        }

        private void 看做字符数组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringAsCharArray form = new FormStringAsCharArray();
            form.Show();

        }

        private void 字符串的遍历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringTravels formst = new FormStringTravels();
            formst.Show();
        }

        private void 构造方法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormString类的构造方法 form = new FormString类的构造方法();
            form.Show();
        }

        private void 比较CompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringCompare比较 form = new FormStringCompare比较();
            form.Show();
        }

        private void 格式化FormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringFormat格式化 form = new FormStringFormat格式化();
            form.Show();
        }

        private void 判空IsNullOrEmptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormString空或Empty判断 form = new FormString空或Empty判断();
            form.Show();
        }

        private void 连接JoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringJoin连接 form = new FormStringJoin连接();
            form.Show();
        }

        private void 包含ContainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringContains form = new FormStringContains();
            form.Show();
        }

        private void 结尾EndsWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringEndsWith form = new FormStringEndsWith();
            form.Show();
        }

        private void 模式匹配IndexOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringIndexOf form = new FormStringIndexOf();
            form.Show();
        }

        private void 分隔SplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringSplit form = new FormStringSplit();
            form.Show();
        }

        private void 截取SubstringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringSubstring form = new FormStringSubstring();
            form.Show();
        }

        private void 转换为字符数组ToCharArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringToCharArray form = new FormStringToCharArray();
            form.Show();
        }

        private void 转换为大写ToUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringToUpper form = new FormStringToUpper();
            form.Show();
        }

        private void 去除两头空格TrimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStringTrim form = new FormStringTrim();
            form.Show();
        }

    }
}
