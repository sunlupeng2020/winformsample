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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmbProvince.Items.AddRange(new string[]{"河北省","河南省"});
            cmbProvince.SelectedIndex=0;
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCity.Items.Clear();
            if (cmbProvince.SelectedIndex == 0)
            {
                cmbCity.Tag = "0";
                cmbCity.Items.AddRange(new string[] { "唐山市", "石家庄市", "邯郸市" });
                cmbCity.SelectedIndex = 0;
            }
            else if (cmbProvince.SelectedIndex == 1)
            {
                cmbCity.Tag = "1";
                cmbCity.Items.AddRange(new string[]{"郑州市","开封市","洛阳市"});
                cmbCity.SelectedIndex = 0;
            }
        }
    }
}
