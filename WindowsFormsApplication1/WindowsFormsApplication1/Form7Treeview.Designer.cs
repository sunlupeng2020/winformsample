namespace WindowsFormsApplication1
{
    partial class Form7Treeview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("2018级");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2019级");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("2020级");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("软件工程系", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("计算机科学与技术系");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("数字媒体技术系");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("信息学院", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.tvxxxy = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvxxxy
            // 
            this.tvxxxy.Location = new System.Drawing.Point(56, 79);
            this.tvxxxy.Name = "tvxxxy";
            treeNode1.Name = "节点4";
            treeNode1.Text = "2018级";
            treeNode2.Name = "节点5";
            treeNode2.Text = "2019级";
            treeNode3.Name = "节点6";
            treeNode3.Text = "2020级";
            treeNode4.Name = "软件工程系";
            treeNode4.Text = "软件工程系";
            treeNode5.Name = "节点2";
            treeNode5.Text = "计算机科学与技术系";
            treeNode6.Name = "节点3";
            treeNode6.Text = "数字媒体技术系";
            treeNode7.Name = "信息学院";
            treeNode7.Text = "信息学院";
            this.tvxxxy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.tvxxxy.Size = new System.Drawing.Size(288, 291);
            this.tvxxxy.TabIndex = 0;
            this.tvxxxy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvxxxy_AfterSelect);
            // 
            // Form7Treeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 424);
            this.Controls.Add(this.tvxxxy);
            this.Name = "Form7Treeview";
            this.Text = "Form7Treeview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvxxxy;
    }
}