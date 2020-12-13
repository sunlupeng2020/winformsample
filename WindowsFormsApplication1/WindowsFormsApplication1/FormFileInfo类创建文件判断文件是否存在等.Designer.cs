namespace WindowsFormsApplication1
{
    partial class FormFileInfo类创建文件判断文件是否存在等
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
            this.tbxFilePathandName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filecurrentPath = new System.Windows.Forms.Label();
            this.lbl31 = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路径和文件名";
            // 
            // tbxFilePathandName
            // 
            this.tbxFilePathandName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxFilePathandName.Location = new System.Drawing.Point(174, 34);
            this.tbxFilePathandName.Name = "tbxFilePathandName";
            this.tbxFilePathandName.Size = new System.Drawing.Size(217, 29);
            this.tbxFilePathandName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(18, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "创建文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(18, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "判断文件是否存在";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件当前目录：";
            // 
            // filecurrentPath
            // 
            this.filecurrentPath.AutoSize = true;
            this.filecurrentPath.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filecurrentPath.Location = new System.Drawing.Point(100, 228);
            this.filecurrentPath.Name = "filecurrentPath";
            this.filecurrentPath.Size = new System.Drawing.Size(159, 19);
            this.filecurrentPath.TabIndex = 5;
            this.filecurrentPath.Text = "filecurrentPath";
            this.filecurrentPath.Click += new System.EventHandler(this.filecurrentPath_Click);
            // 
            // lbl31
            // 
            this.lbl31.AutoSize = true;
            this.lbl31.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl31.Location = new System.Drawing.Point(16, 259);
            this.lbl31.Name = "lbl31";
            this.lbl31.Size = new System.Drawing.Size(104, 19);
            this.lbl31.TabIndex = 6;
            this.lbl31.Text = "文件大小：";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileSize.Location = new System.Drawing.Point(100, 290);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(89, 19);
            this.lblFileSize.TabIndex = 7;
            this.lblFileSize.Text = "FileSize";
            // 
            // FormFileInfo类创建文件判断文件是否存在等
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 361);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lbl31);
            this.Controls.Add(this.filecurrentPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxFilePathandName);
            this.Controls.Add(this.label1);
            this.Name = "FormFileInfo类创建文件判断文件是否存在等";
            this.Text = "FormFileInfo类创建文件判断文件是否存在等";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFilePathandName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label filecurrentPath;
        private System.Windows.Forms.Label lbl31;
        private System.Windows.Forms.Label lblFileSize;
    }
}