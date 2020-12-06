namespace WindowsFormsApplication1
{
    partial class FormStringTrim
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
            this.lbltrim = new System.Windows.Forms.Label();
            this.去掉两端空格 = new System.Windows.Forms.Button();
            this.重置 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "去除字符串两端的空格";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "str:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(79, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "[     ab     bc      ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "去掉两端空格后:";
            // 
            // lbltrim
            // 
            this.lbltrim.AutoSize = true;
            this.lbltrim.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltrim.Location = new System.Drawing.Point(59, 158);
            this.lbltrim.Name = "lbltrim";
            this.lbltrim.Size = new System.Drawing.Size(69, 19);
            this.lbltrim.TabIndex = 4;
            this.lbltrim.Text = "label4";
            // 
            // 去掉两端空格
            // 
            this.去掉两端空格.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.去掉两端空格.Location = new System.Drawing.Point(45, 226);
            this.去掉两端空格.Name = "去掉两端空格";
            this.去掉两端空格.Size = new System.Drawing.Size(140, 34);
            this.去掉两端空格.TabIndex = 5;
            this.去掉两端空格.Text = "去掉两端空格";
            this.去掉两端空格.UseVisualStyleBackColor = true;
            this.去掉两端空格.Click += new System.EventHandler(this.去掉两端空格_Click);
            // 
            // 重置
            // 
            this.重置.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.重置.Location = new System.Drawing.Point(234, 226);
            this.重置.Name = "重置";
            this.重置.Size = new System.Drawing.Size(75, 34);
            this.重置.TabIndex = 6;
            this.重置.Text = "重置";
            this.重置.UseVisualStyleBackColor = true;
            this.重置.Click += new System.EventHandler(this.重置_Click);
            // 
            // FormStringTrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.重置);
            this.Controls.Add(this.去掉两端空格);
            this.Controls.Add(this.lbltrim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStringTrim";
            this.Text = "FormStringTrim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltrim;
        private System.Windows.Forms.Button 去掉两端空格;
        private System.Windows.Forms.Button 重置;
    }
}