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
    public partial class FormDateTime常用属性 : Form
    {
        public FormDateTime常用属性()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt=DateTime.Now;
            label16.Text = dt.ToString();
            label9.Text = dt.Date.ToString();
            label10.Text = dt.Day.ToString();
            label11.Text = dt.Hour.ToString();
            label12.Text = dt.Minute.ToString();
            label13.Text = dt.Month.ToString();
            label14.Text=DateTime.Today.ToString();
            label15.Text = dt.Year.ToString();
            label16.Text = DateTime.Now.ToString();
            label17.Text = dt.Second.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label16.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
        }
    }
}
