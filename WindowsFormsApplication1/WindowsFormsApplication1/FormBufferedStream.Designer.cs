namespace WindowsFormsApplication1
{
    partial class FormBufferedStream
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
            this.tbxBefore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAfter = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "BufferedStream结合FileStream进行文件的读写";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "读写前的Data2.txt文件内容：";
            // 
            // tbxBefore
            // 
            this.tbxBefore.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxBefore.Location = new System.Drawing.Point(48, 96);
            this.tbxBefore.Multiline = true;
            this.tbxBefore.Name = "tbxBefore";
            this.tbxBefore.Size = new System.Drawing.Size(400, 84);
            this.tbxBefore.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(46, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "读写后的Data2.txt文件内容：";
            // 
            // tbxAfter
            // 
            this.tbxAfter.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxAfter.Location = new System.Drawing.Point(48, 234);
            this.tbxAfter.Multiline = true;
            this.tbxAfter.Name = "tbxAfter";
            this.tbxAfter.Size = new System.Drawing.Size(400, 106);
            this.tbxAfter.TabIndex = 2;
            this.tbxAfter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.Location = new System.Drawing.Point(12, 384);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(335, 35);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "读取data1.txt写入data2.txt";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(382, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBufferedStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.tbxAfter);
            this.Controls.Add(this.tbxBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBufferedStream";
            this.Text = "FormBufferedStream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAfter;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button button2;
    }
}