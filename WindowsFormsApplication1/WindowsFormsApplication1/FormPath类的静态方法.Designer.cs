namespace WindowsFormsApplication1
{
    partial class FormPath类的静态方法
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnModifyExtend = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAftermodifyextend = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCombinePath = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.btnGetPathInfo = new System.Windows.Forms.Button();
            this.lblFilePathinfo = new System.Windows.Forms.Label();
            this.gtnGetExtention = new System.Windows.Forms.Button();
            this.lblFileExtention = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblFilenameNoextend = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAbsolutePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始路径：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "D:\\a\\b\\c\\data.txt";
            // 
            // btnModifyExtend
            // 
            this.btnModifyExtend.Location = new System.Drawing.Point(113, 87);
            this.btnModifyExtend.Name = "btnModifyExtend";
            this.btnModifyExtend.Size = new System.Drawing.Size(138, 23);
            this.btnModifyExtend.TabIndex = 2;
            this.btnModifyExtend.Text = "修改扩展名为：";
            this.btnModifyExtend.UseVisualStyleBackColor = true;
            this.btnModifyExtend.Click += new System.EventHandler(this.btnModifyExtend_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "修改扩展名后:";
            // 
            // lblAftermodifyextend
            // 
            this.lblAftermodifyextend.AutoSize = true;
            this.lblAftermodifyextend.Location = new System.Drawing.Point(171, 132);
            this.lblAftermodifyextend.Name = "lblAftermodifyextend";
            this.lblAftermodifyextend.Size = new System.Drawing.Size(41, 12);
            this.lblAftermodifyextend.TabIndex = 5;
            this.lblAftermodifyextend.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 21);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "d:\\a\\b\\c\\";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(313, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 21);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "data.txt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "拼接路径:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "拼接结果:";
            // 
            // lblCombinePath
            // 
            this.lblCombinePath.AutoSize = true;
            this.lblCombinePath.Location = new System.Drawing.Point(117, 257);
            this.lblCombinePath.Name = "lblCombinePath";
            this.lblCombinePath.Size = new System.Drawing.Size(0, 12);
            this.lblCombinePath.TabIndex = 10;
            // 
            // btnCombine
            // 
            this.btnCombine.Location = new System.Drawing.Point(50, 222);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 11;
            this.btnCombine.Text = "拼接路径";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // btnGetPathInfo
            // 
            this.btnGetPathInfo.Location = new System.Drawing.Point(50, 287);
            this.btnGetPathInfo.Name = "btnGetPathInfo";
            this.btnGetPathInfo.Size = new System.Drawing.Size(140, 23);
            this.btnGetPathInfo.TabIndex = 12;
            this.btnGetPathInfo.Text = "获取文件的路径信息:";
            this.btnGetPathInfo.UseVisualStyleBackColor = true;
            this.btnGetPathInfo.Click += new System.EventHandler(this.btnGetPathInfo_Click);
            // 
            // lblFilePathinfo
            // 
            this.lblFilePathinfo.AutoSize = true;
            this.lblFilePathinfo.Location = new System.Drawing.Point(196, 292);
            this.lblFilePathinfo.Name = "lblFilePathinfo";
            this.lblFilePathinfo.Size = new System.Drawing.Size(41, 12);
            this.lblFilePathinfo.TabIndex = 13;
            this.lblFilePathinfo.Text = "label7";
            // 
            // gtnGetExtention
            // 
            this.gtnGetExtention.Location = new System.Drawing.Point(50, 325);
            this.gtnGetExtention.Name = "gtnGetExtention";
            this.gtnGetExtention.Size = new System.Drawing.Size(140, 23);
            this.gtnGetExtention.TabIndex = 14;
            this.gtnGetExtention.Text = "获取扩展名:";
            this.gtnGetExtention.UseVisualStyleBackColor = true;
            this.gtnGetExtention.Click += new System.EventHandler(this.gtnGetExtention_Click);
            // 
            // lblFileExtention
            // 
            this.lblFileExtention.AutoSize = true;
            this.lblFileExtention.Location = new System.Drawing.Point(196, 336);
            this.lblFileExtention.Name = "lblFileExtention";
            this.lblFileExtention.Size = new System.Drawing.Size(41, 12);
            this.lblFileExtention.TabIndex = 15;
            this.lblFileExtention.Text = "label8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "包含扩展名:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "获取文件名:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "不包含扩展名:";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(149, 396);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(41, 12);
            this.lblFilename.TabIndex = 19;
            this.lblFilename.Text = "label7";
            // 
            // lblFilenameNoextend
            // 
            this.lblFilenameNoextend.AutoSize = true;
            this.lblFilenameNoextend.Location = new System.Drawing.Point(160, 419);
            this.lblFilenameNoextend.Name = "lblFilenameNoextend";
            this.lblFilenameNoextend.Size = new System.Drawing.Size(41, 12);
            this.lblFilenameNoextend.TabIndex = 20;
            this.lblFilenameNoextend.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "绝对路径:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "由相对路径获取绝对路径:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAbsolutePath
            // 
            this.lblAbsolutePath.AutoSize = true;
            this.lblAbsolutePath.Location = new System.Drawing.Point(117, 481);
            this.lblAbsolutePath.Name = "lblAbsolutePath";
            this.lblAbsolutePath.Size = new System.Drawing.Size(47, 12);
            this.lblAbsolutePath.TabIndex = 23;
            this.lblAbsolutePath.Text = "label10";
            // 
            // FormPath类的静态方法
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 535);
            this.Controls.Add(this.lblAbsolutePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFilenameNoextend);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFileExtention);
            this.Controls.Add(this.gtnGetExtention);
            this.Controls.Add(this.lblFilePathinfo);
            this.Controls.Add(this.btnGetPathInfo);
            this.Controls.Add(this.btnCombine);
            this.Controls.Add(this.lblCombinePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblAftermodifyextend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnModifyExtend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormPath类的静态方法";
            this.Text = "FormPath类的静态方法";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnModifyExtend;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAftermodifyextend;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCombinePath;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.Button btnGetPathInfo;
        private System.Windows.Forms.Label lblFilePathinfo;
        private System.Windows.Forms.Button gtnGetExtention;
        private System.Windows.Forms.Label lblFileExtention;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lblFilenameNoextend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAbsolutePath;
    }
}