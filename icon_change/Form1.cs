using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icon_change
{
    public partial class threeColorForm : Form
    {
        private double value = 1.2;
        public threeColorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                memNotifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void memNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // can only show two digits, if larger than 10, then don't show the digits after the dot.

            this.value++;
            memNotifyIcon.Icon = IconUtility.getIconWithNumber("Resources/yellow.ico", this.value.ToString());
            
        }

        private void cbox_topmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cbox_topmost.Checked;
        }
    }
}
