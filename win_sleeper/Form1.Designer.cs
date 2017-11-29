namespace idle_all
{
    partial class idleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(idleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_idle_time = new System.Windows.Forms.TextBox();
            this.notifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label_random = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_seconds = new System.Windows.Forms.TextBox();
            this.label_seconds = new System.Windows.Forms.Label();
            this.nud_hour = new System.Windows.Forms.NumericUpDown();
            this.btn_customize_time = new System.Windows.Forms.Button();
            this.config_minute = new System.Windows.Forms.TrackBar();
            this.label_minute = new System.Windows.Forms.Label();
            this.label_hour = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbox_script_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_set_script_path = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbox_sleep_now = new System.Windows.Forms.CheckBox();
            this.cbox_hide_console = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_minute)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Elapsed: ";
            // 
            // tbox_idle_time
            // 
            this.tbox_idle_time.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbox_idle_time.ForeColor = System.Drawing.Color.Red;
            this.tbox_idle_time.Location = new System.Drawing.Point(162, 77);
            this.tbox_idle_time.Name = "tbox_idle_time";
            this.tbox_idle_time.Size = new System.Drawing.Size(109, 29);
            this.tbox_idle_time.TabIndex = 1;
            // 
            // notifyicon
            // 
            this.notifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyicon.Icon")));
            this.notifyicon.Text = "notifyIcon";
            this.notifyicon.Visible = true;
            this.notifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyicon_MouseDoubleClick);
            // 
            // label_random
            // 
            this.label_random.AutoSize = true;
            this.label_random.Location = new System.Drawing.Point(13, 145);
            this.label_random.Name = "label_random";
            this.label_random.Size = new System.Drawing.Size(41, 12);
            this.label_random.TabIndex = 2;
            this.label_random.Text = "random";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_seconds);
            this.groupBox1.Controls.Add(this.label_seconds);
            this.groupBox1.Controls.Add(this.nud_hour);
            this.groupBox1.Controls.Add(this.btn_customize_time);
            this.groupBox1.Controls.Add(this.config_minute);
            this.groupBox1.Controls.Add(this.label_minute);
            this.groupBox1.Controls.Add(this.label_hour);
            this.groupBox1.Location = new System.Drawing.Point(481, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "等候时间";
            // 
            // tbox_seconds
            // 
            this.tbox_seconds.Location = new System.Drawing.Point(81, 75);
            this.tbox_seconds.Name = "tbox_seconds";
            this.tbox_seconds.Size = new System.Drawing.Size(115, 21);
            this.tbox_seconds.TabIndex = 8;
            this.tbox_seconds.TextChanged += new System.EventHandler(this.tbox_seconds_TextChanged);
            // 
            // label_seconds
            // 
            this.label_seconds.AutoSize = true;
            this.label_seconds.ForeColor = System.Drawing.Color.Red;
            this.label_seconds.Location = new System.Drawing.Point(15, 75);
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(59, 12);
            this.label_seconds.TabIndex = 7;
            this.label_seconds.Text = "Seconds: ";
            // 
            // nud_hour
            // 
            this.nud_hour.Location = new System.Drawing.Point(76, 32);
            this.nud_hour.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_hour.Name = "nud_hour";
            this.nud_hour.Size = new System.Drawing.Size(120, 21);
            this.nud_hour.TabIndex = 6;
            // 
            // btn_customize_time
            // 
            this.btn_customize_time.Location = new System.Drawing.Point(548, 31);
            this.btn_customize_time.Name = "btn_customize_time";
            this.btn_customize_time.Size = new System.Drawing.Size(75, 23);
            this.btn_customize_time.TabIndex = 5;
            this.btn_customize_time.Text = "设置";
            this.btn_customize_time.UseVisualStyleBackColor = true;
            this.btn_customize_time.Click += new System.EventHandler(this.btn_customize_time_Click);
            // 
            // config_minute
            // 
            this.config_minute.Location = new System.Drawing.Point(286, 31);
            this.config_minute.Maximum = 59;
            this.config_minute.Name = "config_minute";
            this.config_minute.Size = new System.Drawing.Size(188, 42);
            this.config_minute.TabIndex = 3;
            this.config_minute.Scroll += new System.EventHandler(this.trackbar_minute_Scroll);
            // 
            // label_minute
            // 
            this.label_minute.AutoSize = true;
            this.label_minute.Location = new System.Drawing.Point(218, 36);
            this.label_minute.Name = "label_minute";
            this.label_minute.Size = new System.Drawing.Size(47, 12);
            this.label_minute.TabIndex = 2;
            this.label_minute.Text = "Minute:";
            // 
            // label_hour
            // 
            this.label_hour.AutoSize = true;
            this.label_hour.Location = new System.Drawing.Point(13, 36);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(35, 12);
            this.label_hour.TabIndex = 1;
            this.label_hour.Text = "Hour:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbox_script_path
            // 
            this.tbox_script_path.Location = new System.Drawing.Point(103, 32);
            this.tbox_script_path.Name = "tbox_script_path";
            this.tbox_script_path.Size = new System.Drawing.Size(605, 21);
            this.tbox_script_path.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "ScriptPath";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_set_script_path
            // 
            this.btn_set_script_path.Location = new System.Drawing.Point(767, 32);
            this.btn_set_script_path.Name = "btn_set_script_path";
            this.btn_set_script_path.Size = new System.Drawing.Size(90, 23);
            this.btn_set_script_path.TabIndex = 7;
            this.btn_set_script_path.Text = "设置脚本路径";
            this.btn_set_script_path.UseVisualStyleBackColor = true;
            this.btn_set_script_path.Click += new System.EventHandler(this.btn_set_script_path_Click);
            // 
            // cbox_sleep_now
            // 
            this.cbox_sleep_now.AutoSize = true;
            this.cbox_sleep_now.Location = new System.Drawing.Point(906, 41);
            this.cbox_sleep_now.Name = "cbox_sleep_now";
            this.cbox_sleep_now.Size = new System.Drawing.Size(72, 16);
            this.cbox_sleep_now.TabIndex = 8;
            this.cbox_sleep_now.Text = "SleepNow";
            this.cbox_sleep_now.UseVisualStyleBackColor = true;
            this.cbox_sleep_now.CheckedChanged += new System.EventHandler(this.cbox_sleep_now_CheckedChanged);
            // 
            // cbox_hide_console
            // 
            this.cbox_hide_console.AutoSize = true;
            this.cbox_hide_console.Location = new System.Drawing.Point(906, 77);
            this.cbox_hide_console.Name = "cbox_hide_console";
            this.cbox_hide_console.Size = new System.Drawing.Size(84, 16);
            this.cbox_hide_console.TabIndex = 9;
            this.cbox_hide_console.Text = "隐藏命令行";
            this.cbox_hide_console.UseVisualStyleBackColor = true;
            this.cbox_hide_console.CheckStateChanged += new System.EventHandler(this.cbox_hide_console_CheckStateChanged);
            // 
            // idleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 471);
            this.Controls.Add(this.cbox_hide_console);
            this.Controls.Add(this.cbox_sleep_now);
            this.Controls.Add(this.btn_set_script_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_script_path);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_random);
            this.Controls.Add(this.tbox_idle_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "idleForm";
            this.Text = "自动休眠";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.idleForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.idleForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_minute)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_idle_time;
        private System.Windows.Forms.NotifyIcon notifyicon;
        private System.Windows.Forms.Label label_random;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_customize_time;
        private System.Windows.Forms.TrackBar config_minute;
        private System.Windows.Forms.Label label_minute;
        private System.Windows.Forms.Label label_hour;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nud_hour;
        private System.Windows.Forms.TextBox tbox_script_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_set_script_path;
        private System.Windows.Forms.Label label_seconds;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbox_seconds;
        private System.Windows.Forms.CheckBox cbox_sleep_now;
        private System.Windows.Forms.CheckBox cbox_hide_console;
    }
}

