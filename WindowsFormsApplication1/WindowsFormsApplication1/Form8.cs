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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //创建连接
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=paper;user=root;password=;port=3306";
            //创建命令对象
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "select id,chaptername from chapter where courseid=12 order by number";
            cmd.CommandText = sql;
            #region
            //打开连接
            //conn.Open();
            ////创建DataReader对象
            //MySqlDataReader dr = cmd.ExecuteReader();
            //读取数据

            //cmbCourse.DataSource = dr;

            //while (dr.Read())//读取一行数据
            //{
         
            //    cmbCourse.Items.Add(dr[1]);//添加到ComboBox
            //}
            //dr.Close();//关闭DataReader
            //conn.Close();//关闭连接
#endregion
            //数据适配器对象
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);//参数是命令对象
            DataSet ds = new DataSet();//创建数据集对象
            sda.Fill(ds);//把适配器得到的数据填充到数据集中
            cmbCourse.DataSource = ds.Tables[0].DefaultView;//设置combobox的数据源
            cmbCourse.ValueMember = "id";//设置值字段
            cmbCourse.DisplayMember = "chaptername";//设置显示的文本对应的字段

            //cmbCourse.SelectedIndex = 0;//默认选择第一项
        }
        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chapterid = cmbCourse.SelectedValue.ToString();//得到选择的章的id号
            label2.Text = chapterid;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=paper;user=root;password=;port=3306";
            //创建命令对象
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "select id,sectionname from section  where chapterid='" + chapterid + "' order by number";
            cmd.CommandText = sql;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbSection.DataSource = ds.Tables[0].DefaultView;
            cmbSection.ValueMember = "id";
            cmbSection.DisplayMember = "sectionname";
            //cmbSection.SelectedIndex = 0;//默认选择第一项
        }
    }
}
