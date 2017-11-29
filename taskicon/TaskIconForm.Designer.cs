namespace taskicon
{
    partial class TaskIconForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskIconForm));
            this.notifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_cmd = new System.Windows.Forms.Button();
            this.btn_close_cmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyicon
            // 
            this.notifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyicon.Icon")));
            this.notifyicon.Text = "任务栏托盘";
            this.notifyicon.Visible = true;
            this.notifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyicon_MouseDoubleClick);
            // 
            // btn_cmd
            // 
            this.btn_cmd.Location = new System.Drawing.Point(12, 227);
            this.btn_cmd.Name = "btn_cmd";
            this.btn_cmd.Size = new System.Drawing.Size(75, 23);
            this.btn_cmd.TabIndex = 0;
            this.btn_cmd.Text = "btn_cmd";
            this.btn_cmd.UseVisualStyleBackColor = true;
            this.btn_cmd.Click += new System.EventHandler(this.btn_cmd_Click);
            // 
            // btn_close_cmd
            // 
            this.btn_close_cmd.Location = new System.Drawing.Point(122, 227);
            this.btn_close_cmd.Name = "btn_close_cmd";
            this.btn_close_cmd.Size = new System.Drawing.Size(75, 23);
            this.btn_close_cmd.TabIndex = 1;
            this.btn_close_cmd.Text = "关闭命令行";
            this.btn_close_cmd.UseVisualStyleBackColor = true;
            this.btn_close_cmd.Click += new System.EventHandler(this.btn_close_cmd_Click);
            // 
            // TaskIconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_close_cmd);
            this.Controls.Add(this.btn_cmd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskIconForm";
            this.Text = "系统托盘窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskIconWindow_FormClosed);
            this.Load += new System.EventHandler(this.TaskIconWindow_Load);
            this.ResizeBegin += new System.EventHandler(this.TaskIconWindow_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.TaskIconWindow_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.TaskIconWindow_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyicon;
        private System.Windows.Forms.Button btn_cmd;
        private System.Windows.Forms.Button btn_close_cmd;
    }
}

