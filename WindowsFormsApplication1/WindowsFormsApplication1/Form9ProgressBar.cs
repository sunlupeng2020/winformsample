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
    public partial class Form9ProgressBar : Form
    {
        public Form9ProgressBar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//加血按钮
        {
            if (proBlood.Value < proBlood.Maximum)
            {
                proBlood.Value = proBlood.Value + 5;
            }
            else
            {
                MessageBox.Show("英雄血已加满！");
            }
            lbBlood.Text = proBlood.Value.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (proBlood.Value > proBlood.Minimum)
            {
                //
                proBlood.Value = proBlood.Value - 5;
            }
            else
            {
                MessageBox.Show("英雄已死！");
            }
            lbBlood.Text = proBlood.Value.ToString();
        }

        private void Form9ProgressBar_Load(object sender, EventArgs e)
        {
            lbBlood.Text = proBlood.Value.ToString();
        }
    }
}
