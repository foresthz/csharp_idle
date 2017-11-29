using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;


// multi thread should be used
namespace idle_all
{
    public partial class idleForm : Form
    {

        Thread thread;
        bool istime_customized = false;
        long customize_hour = 0;
        long customize_minute = 3;
        long loop_time = 0;

        bool sleep_enabled = false;
        bool wake_from_sleep = false;
       

        public idleForm()
        {
            InitializeComponent();
            notifyicon.Text = "自动睡眠";
            CheckForIllegalCrossThreadCalls = false;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwTime;
        }

        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;




        static long GetLastInputTime()
        {
            LASTINPUTINFO lii = new LASTINPUTINFO();
            lii.cbSize = Marshal.SizeOf(lii);
            if (!GetLastInputInfo(ref lii)) return 0;
            Console.WriteLine((DateTime.Now.Ticks - 621355968000000000)/10000000);
            

            Console.WriteLine("tickCount: " + Environment.TickCount / 1000 + " dwTime: " + lii.dwTime / 1000 + " unit tick: " + (uint)Environment.TickCount / 1000);
            Console.WriteLine("uint_max: " + uint.MaxValue + " long_max: " + long.MaxValue);
            return (uint)Environment.TickCount - (long)lii.dwTime; 
        }

        private void Idle_detection()
        {
            long idle_time;

            long max_time = 1800;
            long wait_time = 0;
            
            Random rand = new Random();
            if (tbox_script_path.Text == "")
            {
                tbox_script_path.Text = "C:\\Users\\jack\\Desktop\\wintool\\sleep.bat";
            }

            if (tbox_seconds.Text == "")
            {
                tbox_seconds.Text = "1800";
            }

            for (; ; )
            {
                // how to measure the overhead of GetLastInputTime and Sleep function?

                idle_time = GetLastInputTime() / 1000;
                if (idle_time == 0)
                {
                    loop_time = 0;
                    cbox_sleep_now.Checked = false;
                }

                Console.WriteLine("loop_time: " + loop_time);
                // should operate mouse or key at least once after wakeup
                if (idle_time < 20)
                {
                    wake_from_sleep = false;
                }

                max_time = Int32.Parse(tbox_seconds.Text);

                Console.WriteLine("Max Time: " + max_time);
                Console.WriteLine("Idle Time: " + idle_time);

                if (max_time < 30)
                {
                    max_time = 30;
                    tbox_seconds.Text = "30";
                }

                wait_time = max_time - idle_time;

                Console.WriteLine("Wait Time: " + wait_time);

                // Int32.Parse(tbox_seconds.Text)
                if (idle_time >= max_time && loop_time >= ((max_time >= 300) ? 300 + (max_time-300)/10.0 : max_time))
                {
                    if (!sleep_enabled && !wake_from_sleep)
                    {
                        sleep_enabled = true;
                        wake_from_sleep = true;
                        Process.Start(tbox_script_path.Text);
                        loop_time = 0;
                        // Thread.Sleep(240 * 1000);

                    }


                }
                else
                {
                    if (sleep_enabled)
                    {
                        sleep_enabled = false;

                        tbox_seconds.Text = "1800";
                    }
                    String tosleep_time = wait_time.ToString();
                    this.tbox_idle_time.Text = tosleep_time;
                    this.notifyicon.Text = "自动睡眠: " + tosleep_time;
                    this.label_random.Text = rand.Next(10000).ToString();
                    // Console.WriteLine("wait ... {0} {1}", wait_time, "seconds");
                }


                if (wait_time > 300)
                {
                    Thread.Sleep(10000);
                }
                else
                {
                    Thread.Sleep(1000);
                }
                loop_time += 1;


            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tbox_idle_time.Text = "hi";
            thread = new Thread(this.Idle_detection);
            thread.Start();
            
            // Idle_detection();
        }

        private void idleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // MessageBox.Show("form closed");
            // if the thread is not closed, the process will not be terminated
            thread.Abort();
        }

        private void idleForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                // MessageBox.Show("minimized");
                notifyicon.Visible = true;
                Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
              //  Show();
            }
        }

        private void notifyicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // there is still some synchronization problems
            // this.WindowState = FormWindowState.Normal;

            
            Show();
            // the default show is minimized? the following statement not works if used in front of show() function
            // if the state is normal, the window will be shown to the front
            this.WindowState = FormWindowState.Normal;
            //this.BringToFront();
        }

        private void dud_hour_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void trackbar_minute_Scroll(object sender, EventArgs e)
        {
            this.customize_minute = config_minute.Value;
        }

        private void btn_customize_time_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Build From 2016.9.8", "欢迎使用");
        }

        private void btn_set_script_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(dialog.FileName);
                tbox_script_path.Text = dialog.FileName;
            }
        }

        private void cbox_sleep_now_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("CheckBox Value: " + cbox_sleep_now.Checked );

            if (cbox_sleep_now.Checked)
            {
                // MessageBox.Show("check box");

                cbox_sleep_now.Checked = true; 
                sleep_enabled = true;
                wake_from_sleep = true;


                DialogResult dr = MessageBox.Show("进入睡眠状态", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Process.Start(tbox_script_path.Text);
                    loop_time = 0;
                }
                else if (dr == DialogResult.No)
                {
                    Console.WriteLine("cancel sleep");
                    cbox_sleep_now.Checked = false;
                }

                // Thread.Sleep(1 * 2000);
                // Thread.Sleep(240 * 1000);
                
                
            }

            Console.WriteLine("CheckBox Value: " + cbox_sleep_now.Checked);
        }

        private void cbox_hide_console_CheckStateChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbox_hide_console.Checked.ToString());
            var handle = GetConsoleWindow();
            if (cbox_hide_console.Checked)
            {
                
                ShowWindow(handle, SW_HIDE);
            }
            else
            {
                ShowWindow(handle, SW_SHOW);
            }
        }

        private void tbox_seconds_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
