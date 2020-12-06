namespace WindowsFormsApplication1
{
    partial class FormStringToCharArray
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnStrRev = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(84, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "将字符串转换为字符数组";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(86, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "abcdefg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "str:";
            // 
            // btnStrRev
            // 
            this.btnStrRev.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStrRev.Location = new System.Drawing.Point(52, 277);
            this.btnStrRev.Name = "btnStrRev";
            this.btnStrRev.Size = new System.Drawing.Size(143, 31);
            this.btnStrRev.TabIndex = 3;
            this.btnStrRev.Text = "字符串翻转";
            this.btnStrRev.UseVisualStyleBackColor = true;
            this.btnStrRev.Click += new System.EventHandler(this.btnStrRev_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(224, 276);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(103, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // FormStringToCharArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStrRev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormStringToCharArray";
            this.Text = "FormStringToCharArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStrRev;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
    }
}