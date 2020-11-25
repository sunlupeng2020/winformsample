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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string[] musicNames = { "一江春水向东流", "春江花月夜", "晚秋", "开心做一出戏" };
            for (int i = 0; i < musicNames.Length; i++)
            {
                lbShow.Items.Add(musicNames[i]);
            }
        }

        private void lbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("当前播放的歌曲为：" + lbShow.SelectedItem.ToString());
        }
    }
}
