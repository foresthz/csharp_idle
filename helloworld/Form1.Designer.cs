namespace helloworld
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
            this.btn_msg1 = new System.Windows.Forms.Button();
            this.btn_launch_calc = new System.Windows.Forms.Button();
            this.tbox_program_path = new System.Windows.Forms.TextBox();
            this.label_program_path = new System.Windows.Forms.Label();
            this.btn_launch_from_path = new System.Windows.Forms.Button();
            this.btn_navigate_to_program = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_msg1
            // 
            this.btn_msg1.Location = new System.Drawing.Point(12, 227);
            this.btn_msg1.Name = "btn_msg1";
            this.btn_msg1.Size = new System.Drawing.Size(75, 23);
            this.btn_msg1.TabIndex = 0;
            this.btn_msg1.Text = "消息窗口";
            this.btn_msg1.UseVisualStyleBackColor = true;
            this.btn_msg1.Click += new System.EventHandler(this.btn_msg1_Click);
            // 
            // btn_launch_calc
            // 
            this.btn_launch_calc.Location = new System.Drawing.Point(119, 227);
            this.btn_launch_calc.Name = "btn_launch_calc";
            this.btn_launch_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_launch_calc.TabIndex = 1;
            this.btn_launch_calc.Text = "启动计算器";
            this.btn_launch_calc.UseVisualStyleBackColor = true;
            this.btn_launch_calc.Click += new System.EventHandler(this.btn_launch_calc_Click);
            // 
            // tbox_program_path
            // 
            this.tbox_program_path.Location = new System.Drawing.Point(95, 122);
            this.tbox_program_path.Name = "tbox_program_path";
            this.tbox_program_path.Size = new System.Drawing.Size(659, 21);
            this.tbox_program_path.TabIndex = 2;
            this.tbox_program_path.TextChanged += new System.EventHandler(this.tbox_program_path_TextChanged);
            // 
            // label_program_path
            // 
            this.label_program_path.AutoSize = true;
            this.label_program_path.Location = new System.Drawing.Point(22, 125);
            this.label_program_path.Name = "label_program_path";
            this.label_program_path.Size = new System.Drawing.Size(53, 12);
            this.label_program_path.TabIndex = 3;
            this.label_program_path.Text = "程序路径";
            // 
            // btn_launch_from_path
            // 
            this.btn_launch_from_path.Location = new System.Drawing.Point(254, 227);
            this.btn_launch_from_path.Name = "btn_launch_from_path";
            this.btn_launch_from_path.Size = new System.Drawing.Size(75, 23);
            this.btn_launch_from_path.TabIndex = 4;
            this.btn_launch_from_path.Text = "从路径启动程序";
            this.btn_launch_from_path.UseVisualStyleBackColor = true;
            this.btn_launch_from_path.Click += new System.EventHandler(this.btn_launch_from_path_Click);
            // 
            // btn_navigate_to_program
            // 
            this.btn_navigate_to_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_navigate_to_program.Location = new System.Drawing.Point(95, 165);
            this.btn_navigate_to_program.Name = "btn_navigate_to_program";
            this.btn_navigate_to_program.Size = new System.Drawing.Size(99, 23);
            this.btn_navigate_to_program.TabIndex = 5;
            this.btn_navigate_to_program.Text = "选定程序 ...";
            this.btn_navigate_to_program.UseVisualStyleBackColor = false;
            this.btn_navigate_to_program.Click += new System.EventHandler(this.btn_navigate_to_program_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 262);
            this.Controls.Add(this.btn_navigate_to_program);
            this.Controls.Add(this.btn_launch_from_path);
            this.Controls.Add(this.label_program_path);
            this.Controls.Add(this.tbox_program_path);
            this.Controls.Add(this.btn_launch_calc);
            this.Controls.Add(this.btn_msg1);
            this.Name = "Form1";
            this.Text = "窗口HW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_msg1;
        private System.Windows.Forms.Button btn_launch_calc;
        private System.Windows.Forms.TextBox tbox_program_path;
        private System.Windows.Forms.Label label_program_path;
        private System.Windows.Forms.Button btn_launch_from_path;
        private System.Windows.Forms.Button btn_navigate_to_program;
    }
}

