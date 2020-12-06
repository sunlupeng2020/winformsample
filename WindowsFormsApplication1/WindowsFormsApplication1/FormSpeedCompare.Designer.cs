namespace WindowsFormsApplication1
{
    partial class FormSpeedCompare
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblStringTime = new System.Windows.Forms.Label();
            this.lblStringBuildertime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "两种字符串的性能比较";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "分别追加10000个数的字符串，比较用时";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(38, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "String字符串用时：";
            // 
            // lblStringTime
            // 
            this.lblStringTime.AutoSize = true;
            this.lblStringTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStringTime.Location = new System.Drawing.Point(74, 142);
            this.lblStringTime.Name = "lblStringTime";
            this.lblStringTime.Size = new System.Drawing.Size(0, 19);
            this.lblStringTime.TabIndex = 3;
            // 
            // lblStringBuildertime
            // 
            this.lblStringBuildertime.AutoSize = true;
            this.lblStringBuildertime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStringBuildertime.Location = new System.Drawing.Point(74, 232);
            this.lblStringBuildertime.Name = "lblStringBuildertime";
            this.lblStringBuildertime.Size = new System.Drawing.Size(0, 19);
            this.lblStringBuildertime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(44, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "StringBuilder用时";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(50, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "执行追加、比较";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(262, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormSpeedCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 339);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStringBuildertime);
            this.Controls.Add(this.lblStringTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSpeedCompare";
            this.Text = "FormSpeedCompare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStringTime;
        private System.Windows.Forms.Label lblStringBuildertime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}