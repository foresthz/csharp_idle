using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace taskicon
{



    public partial class TaskIconForm : Form
    {

        private ContextMenu menu;
        private Process p;

        // declare inside class defination
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]

        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        public TaskIconForm()
        {
            InitializeComponent();
            this.p = new Process();

            this.menu = new ContextMenu();
            MenuItem item1 = new MenuItem();
            this.menu.MenuItems.Add(item1);
            item1.Index = 0;
            item1.Text = "还原";
            notifyicon.ContextMenu = this.menu;
            item1.Click += new System.EventHandler(item1_click);
        }

        private void TaskIconWindow_Load(object sender, EventArgs e)
        {

        }

        private void TaskIconWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            // MessageBox.Show("form closed");
        }

        private void TaskIconWindow_ResizeBegin(object sender, EventArgs e)
        {
            // MessageBox.Show("form resize begin");
        }

        private void TaskIconWindow_ResizeEnd(object sender, EventArgs e)
        {
            // MessageBox.Show("form resize end");
        }

        private void TaskIconWindow_SizeChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("form size changed");
            if (FormWindowState.Minimized == this.WindowState)
            {
                // MessageBox.Show("form minimized");
                notifyicon.Visible = true;
                Hide();
                
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                // MessageBox.Show("form normal");
                notifyicon.Visible = false;
            }

        }

        private void showForm() {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void item1_click(object sender, EventArgs e)
        {
            // MessageBox.Show("item1 clicked");
            this.showForm();
            


            //Application.OpenForms["TaskIconWindow"].BringToFront();
        }

        private void notifyicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.showForm();
        }



        private void btn_cmd_Click(object sender, EventArgs e)
        {

            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW);
            //this.p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            //this.p.StartInfo.FileName = "cmd.exe";
            //this.p.Start();
        }

        private void btn_close_cmd_Click(object sender, EventArgs e)
        {
            //this.p.Close();
        }
    }
}
