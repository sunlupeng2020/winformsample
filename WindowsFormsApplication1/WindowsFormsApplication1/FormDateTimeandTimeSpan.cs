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
    public partial class FormDateTimeandTimeSpan : Form
    {
        public FormDateTimeandTimeSpan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dt1 = DateTime.Parse(textBox1.Text);
                DateTime dt2 = DateTime.Parse(textBox2.Text);
                TimeSpan ts = dt1 - dt2;
                label5.Text = ts.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dt1 = DateTime.Parse(textBox1.Text);
                DateTime dt2 = DateTime.Parse(textBox2.Text);
                TimeSpan ts = dt2 - dt1;
                label5.Text = ts.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2020-12-20 10:05:30";
            textBox2.Text = "2020-12-23 20:15:20";
        }
    }
}
