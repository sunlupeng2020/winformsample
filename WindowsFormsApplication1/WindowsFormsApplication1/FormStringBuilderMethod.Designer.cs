namespace WindowsFormsApplication1
{
    partial class FormStringBuilderMethod
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAppend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxOffset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxInsertStr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInsertResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRemoveResult = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblReplaceResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxOldValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxNewValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxRmvPostion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxRmvNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAppendResult = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "StringBuilder常用方法";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "追加字符串Append(string str)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxAppend
            // 
            this.tbxAppend.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxAppend.Location = new System.Drawing.Point(107, 61);
            this.tbxAppend.Name = "tbxAppend";
            this.tbxAppend.Size = new System.Drawing.Size(290, 29);
            this.tbxAppend.TabIndex = 2;
            this.tbxAppend.Text = "abcde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "插入字符串：Insert(int offset,string str)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(66, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "位置:";
            // 
            // tbxOffset
            // 
            this.tbxOffset.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxOffset.Location = new System.Drawing.Point(119, 158);
            this.tbxOffset.Name = "tbxOffset";
            this.tbxOffset.Size = new System.Drawing.Size(46, 29);
            this.tbxOffset.TabIndex = 5;
            this.tbxOffset.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(194, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "值：";
            // 
            // tbxInsertStr
            // 
            this.tbxInsertStr.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxInsertStr.Location = new System.Drawing.Point(230, 160);
            this.tbxInsertStr.Name = "tbxInsertStr";
            this.tbxInsertStr.Size = new System.Drawing.Size(130, 29);
            this.tbxInsertStr.TabIndex = 7;
            this.tbxInsertStr.Text = "aaa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(39, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "插入结果：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblInsertResult
            // 
            this.lblInsertResult.AutoSize = true;
            this.lblInsertResult.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInsertResult.Location = new System.Drawing.Point(146, 203);
            this.lblInsertResult.Name = "lblInsertResult";
            this.lblInsertResult.Size = new System.Drawing.Size(0, 19);
            this.lblInsertResult.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "替换字符串：Replace（）";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(29, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(403, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "移除字符串：Remove(int index,int length)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(33, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "移除结果：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblRemoveResult
            // 
            this.lblRemoveResult.AutoSize = true;
            this.lblRemoveResult.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemoveResult.Location = new System.Drawing.Point(143, 292);
            this.lblRemoveResult.Name = "lblRemoveResult";
            this.lblRemoveResult.Size = new System.Drawing.Size(0, 19);
            this.lblRemoveResult.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(42, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "替换结果：";
            // 
            // lblReplaceResult
            // 
            this.lblReplaceResult.AutoSize = true;
            this.lblReplaceResult.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReplaceResult.Location = new System.Drawing.Point(135, 389);
            this.lblReplaceResult.Name = "lblReplaceResult";
            this.lblReplaceResult.Size = new System.Drawing.Size(0, 19);
            this.lblReplaceResult.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(150, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "执行操作";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(297, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(44, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "原值：";
            // 
            // tbxOldValue
            // 
            this.tbxOldValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxOldValue.Location = new System.Drawing.Point(104, 347);
            this.tbxOldValue.Name = "tbxOldValue";
            this.tbxOldValue.Size = new System.Drawing.Size(100, 29);
            this.tbxOldValue.TabIndex = 19;
            this.tbxOldValue.Text = "a";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(232, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "新值：";
            // 
            // tbxNewValue
            // 
            this.tbxNewValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxNewValue.Location = new System.Drawing.Point(283, 354);
            this.tbxNewValue.Name = "tbxNewValue";
            this.tbxNewValue.Size = new System.Drawing.Size(100, 29);
            this.tbxNewValue.TabIndex = 21;
            this.tbxNewValue.Text = "b";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(46, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "移除位置：";
            // 
            // tbxRmvPostion
            // 
            this.tbxRmvPostion.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxRmvPostion.Location = new System.Drawing.Point(141, 260);
            this.tbxRmvPostion.Name = "tbxRmvPostion";
            this.tbxRmvPostion.Size = new System.Drawing.Size(100, 29);
            this.tbxRmvPostion.TabIndex = 23;
            this.tbxRmvPostion.Text = "3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(241, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "移除字符个数：";
            // 
            // tbxRmvNum
            // 
            this.tbxRmvNum.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxRmvNum.Location = new System.Drawing.Point(381, 260);
            this.tbxRmvNum.Name = "tbxRmvNum";
            this.tbxRmvNum.Size = new System.Drawing.Size(100, 29);
            this.tbxRmvNum.TabIndex = 25;
            this.tbxRmvNum.Text = "3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(33, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "追加结果：";
            // 
            // lblAppendResult
            // 
            this.lblAppendResult.AutoSize = true;
            this.lblAppendResult.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAppendResult.Location = new System.Drawing.Point(135, 104);
            this.lblAppendResult.Name = "lblAppendResult";
            this.lblAppendResult.Size = new System.Drawing.Size(0, 19);
            this.lblAppendResult.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(31, 434);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 19);
            this.label16.TabIndex = 28;
            this.label16.Text = "字符串长度:Length";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLength.Location = new System.Drawing.Point(251, 434);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(0, 19);
            this.lblLength.TabIndex = 29;
            // 
            // FormStringBuilderMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 540);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblAppendResult);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbxRmvNum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbxRmvPostion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxNewValue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxOldValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblReplaceResult);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRemoveResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblInsertResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxInsertStr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxOffset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAppend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStringBuilderMethod";
            this.Text = "FormStringBuilderMethod";
            this.Load += new System.EventHandler(this.FormStringBuilderMethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAppend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxInsertStr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInsertResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRemoveResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblReplaceResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxOldValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxNewValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxRmvPostion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxRmvNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAppendResult;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLength;
    }
}