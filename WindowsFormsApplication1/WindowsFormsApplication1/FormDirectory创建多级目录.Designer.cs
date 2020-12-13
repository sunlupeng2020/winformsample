namespace WindowsFormsApplication1
{
    partial class FormDirectory创建多级目录
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDirectoryInfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btndeletedir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "指定目录：";
            // 
            // tbxDirectoryInfo
            // 
            this.tbxDirectoryInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxDirectoryInfo.Location = new System.Drawing.Point(30, 63);
            this.tbxDirectoryInfo.Name = "tbxDirectoryInfo";
            this.tbxDirectoryInfo.Size = new System.Drawing.Size(349, 29);
            this.tbxDirectoryInfo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(69, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "创建目录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(69, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "检测目录是否存在";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndeletedir
            // 
            this.btndeletedir.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndeletedir.Location = new System.Drawing.Point(69, 243);
            this.btndeletedir.Name = "btndeletedir";
            this.btndeletedir.Size = new System.Drawing.Size(206, 33);
            this.btndeletedir.TabIndex = 4;
            this.btndeletedir.Text = "删除目录";
            this.btndeletedir.UseVisualStyleBackColor = true;
            this.btndeletedir.Click += new System.EventHandler(this.btndeletedir_Click);
            // 
            // FormDirectory创建多级目录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 352);
            this.Controls.Add(this.btndeletedir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxDirectoryInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormDirectory创建多级目录";
            this.Text = "FormDirectory创建多级目录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDirectoryInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btndeletedir;
    }
}