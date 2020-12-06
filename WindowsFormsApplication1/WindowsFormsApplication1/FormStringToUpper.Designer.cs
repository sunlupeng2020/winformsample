namespace WindowsFormsApplication1
{
    partial class FormStringToUpper
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblupper = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbllower = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "字符串的大小写转换";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "str:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(91, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "ZhengZhou Normal University";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "大写：";
            // 
            // lblupper
            // 
            this.lblupper.AutoSize = true;
            this.lblupper.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblupper.Location = new System.Drawing.Point(100, 130);
            this.lblupper.Name = "lblupper";
            this.lblupper.Size = new System.Drawing.Size(69, 19);
            this.lblupper.TabIndex = 4;
            this.lblupper.Text = "label4";
            this.lblupper.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(31, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "小写：";
            // 
            // lbllower
            // 
            this.lbllower.AutoSize = true;
            this.lbllower.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbllower.Location = new System.Drawing.Point(100, 190);
            this.lbllower.Name = "lbllower";
            this.lbllower.Size = new System.Drawing.Size(69, 19);
            this.lbllower.TabIndex = 6;
            this.lbllower.Text = "label6";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(46, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "大小写转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(251, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormStringToUpper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbllower);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblupper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStringToUpper";
            this.Text = "FormStringToUpper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblupper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbllower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}