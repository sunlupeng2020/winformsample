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
    public partial class Form7Treeview : Form
    {
        public Form7Treeview()
        {
            InitializeComponent();
        }

        private void tvxxxy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvxxxy.SelectedNode.Level != 0)
            {
                string text = tvxxxy.SelectedNode.Text;
                MessageBox.Show(text);
            }
        }

        private void Form7Treeview_Load(object sender, EventArgs e)
        {
            tvxxxy.ExpandAll();
        }
    }
}
