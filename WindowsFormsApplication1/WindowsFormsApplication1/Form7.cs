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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=paper;port=3306;user=root;password=";
            conn.Open();
            //if (conn.State == ConnectionState.Open)
            //    MessageBox.Show("数据库连接成功！");
            //else
            //    MessageBox.Show("数据库连接失败！");
            string sql = "select id,chaptername from chapter where courseid=12 order by number";
            MySqlCommand cmd=conn.CreateCommand();
            cmd.CommandText=sql;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tvCourse.Nodes.Add(dr[0].ToString(),dr[1].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            if (tvCourse.Nodes.Count > 0)
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "server=localhost;database=paper;port=3306;user=root;password=";
                string sql = "select id,sectionname from section where chapterid=";
                MySqlCommand cmd = conn.CreateCommand();
                MySqlDataReader dr;
                conn.Open();
                foreach (TreeNode node in tvCourse.Nodes)
                {
                    cmd.CommandText = sql + node.Name + " order by number";
                    
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        node.Nodes.Add(dr[0].ToString(), dr[1].ToString());
                    }
                    dr.Close();

                }
                conn.Close();
            }
        }
    }
}
