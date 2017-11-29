namespace icon_change
{
    partial class threeColorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(threeColorForm));
            this.memNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label_free_memory = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbox_drawstring = new System.Windows.Forms.TextBox();
            this.cbox_topmost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // memNotifyIcon
            // 
            this.memNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("memNotifyIcon.Icon")));
            this.memNotifyIcon.Text = "memNotifyIcon";
            this.memNotifyIcon.Visible = true;
            this.memNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.memNotifyIcon_MouseDoubleClick);
            // 
            // label_free_memory
            // 
            this.label_free_memory.AutoSize = true;
            this.label_free_memory.Location = new System.Drawing.Point(31, 51);
            this.label_free_memory.Name = "label_free_memory";
            this.label_free_memory.Size = new System.Drawing.Size(53, 12);
            this.label_free_memory.TabIndex = 0;
            this.label_free_memory.Text = "剩余内存";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(90, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "画图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbox_drawstring
            // 
            this.tbox_drawstring.Location = new System.Drawing.Point(33, 180);
            this.tbox_drawstring.Name = "tbox_drawstring";
            this.tbox_drawstring.Size = new System.Drawing.Size(100, 21);
            this.tbox_drawstring.TabIndex = 3;
            // 
            // cbox_topmost
            // 
            this.cbox_topmost.AutoSize = true;
            this.cbox_topmost.Location = new System.Drawing.Point(33, 130);
            this.cbox_topmost.Name = "cbox_topmost";
            this.cbox_topmost.Size = new System.Drawing.Size(66, 16);
            this.cbox_topmost.TabIndex = 4;
            this.cbox_topmost.Text = "topMost";
            this.cbox_topmost.UseVisualStyleBackColor = true;
            this.cbox_topmost.CheckedChanged += new System.EventHandler(this.cbox_topmost_CheckedChanged);
            // 
            // threeColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 333);
            this.Controls.Add(this.cbox_topmost);
            this.Controls.Add(this.tbox_drawstring);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_free_memory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "threeColorForm";
            this.Text = "ThreeColor Icon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon memNotifyIcon;
        private System.Windows.Forms.Label label_free_memory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbox_drawstring;
        private System.Windows.Forms.CheckBox cbox_topmost;
    }
}

