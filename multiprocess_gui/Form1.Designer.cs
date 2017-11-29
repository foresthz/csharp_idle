namespace multiprocess_gui
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_addone = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_addtwo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_addtwo = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.tbox_sum = new System.Windows.Forms.TextBox();
            this.label_sum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addone
            // 
            this.btn_addone.Location = new System.Drawing.Point(267, 52);
            this.btn_addone.Name = "btn_addone";
            this.btn_addone.Size = new System.Drawing.Size(75, 23);
            this.btn_addone.TabIndex = 0;
            this.btn_addone.Text = "开始";
            this.btn_addone.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "每秒加1";
            // 
            // label_addtwo
            // 
            this.label_addtwo.AutoSize = true;
            this.label_addtwo.Location = new System.Drawing.Point(6, 110);
            this.label_addtwo.Name = "label_addtwo";
            this.label_addtwo.Size = new System.Drawing.Size(47, 12);
            this.label_addtwo.TabIndex = 3;
            this.label_addtwo.Text = "每秒加2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // btn_addtwo
            // 
            this.btn_addtwo.Location = new System.Drawing.Point(267, 99);
            this.btn_addtwo.Name = "btn_addtwo";
            this.btn_addtwo.Size = new System.Drawing.Size(75, 23);
            this.btn_addtwo.TabIndex = 5;
            this.btn_addtwo.Text = "开始";
            this.btn_addtwo.UseVisualStyleBackColor = true;
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(267, 148);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(75, 23);
            this.btn_sum.TabIndex = 6;
            this.btn_sum.Text = "相加";
            this.btn_sum.UseVisualStyleBackColor = true;
            // 
            // tbox_sum
            // 
            this.tbox_sum.Location = new System.Drawing.Point(149, 150);
            this.tbox_sum.Name = "tbox_sum";
            this.tbox_sum.Size = new System.Drawing.Size(100, 21);
            this.tbox_sum.TabIndex = 7;
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(6, 159);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(137, 12);
            this.label_sum.TabIndex = 8;
            this.label_sum.Text = "暂停前面两个进程，相加";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_sum);
            this.groupBox1.Controls.Add(this.btn_addone);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_addtwo);
            this.groupBox1.Controls.Add(this.btn_sum);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.tbox_sum);
            this.groupBox1.Controls.Add(this.label_addtwo);
            this.groupBox1.Location = new System.Drawing.Point(301, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 210);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加法同步";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 610);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "多线程更新界面信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_addtwo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_addtwo;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.TextBox tbox_sum;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

