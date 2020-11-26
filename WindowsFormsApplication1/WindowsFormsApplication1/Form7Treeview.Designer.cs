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
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("2018级");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("2019级");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("2020级");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("软件工程系", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("计算机科学与技术系");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("数字媒体技术系");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("信息学院", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            this.tvxxxy = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvxxxy
            // 
            this.tvxxxy.Location = new System.Drawing.Point(56, 79);
            this.tvxxxy.Name = "tvxxxy";
            treeNode22.Name = "节点4";
            treeNode22.Text = "2018级";
            treeNode23.Name = "节点5";
            treeNode23.Text = "2019级";
            treeNode24.Name = "节点6";
            treeNode24.Text = "2020级";
            treeNode25.Name = "软件工程系";
            treeNode25.Text = "软件工程系";
            treeNode26.Name = "节点2";
            treeNode26.Text = "计算机科学与技术系";
            treeNode27.Name = "节点3";
            treeNode27.Text = "数字媒体技术系";
            treeNode28.Name = "信息学院";
            treeNode28.Text = "信息学院";
            this.tvxxxy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode28});
            this.tvxxxy.Size = new System.Drawing.Size(288, 291);
            this.tvxxxy.TabIndex = 0;
            this.tvxxxy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvxxxy_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(81, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "信息科学与技术学院结构图";
            // 
            // Form7Treeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvxxxy);
            this.Name = "Form7Treeview";
            this.Text = "Form7Treeview";
            this.Load += new System.EventHandler(this.Form7Treeview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvxxxy;
        private System.Windows.Forms.Label label1;
    }
}