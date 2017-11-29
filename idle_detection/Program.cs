using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

// though the implementation is done, some mechanism should still be studied
namespace idle_detection
{
    class Program
    {
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

        static long GetLastInputTime()
        {
            LASTINPUTINFO lii = new LASTINPUTINFO();
            lii.cbSize = Marshal.SizeOf(lii);
            if (!GetLastInputInfo(ref lii)) return 0;
            return Environment.TickCount - (long)lii.dwTime;
        }
        static void Main(string[] args)
        {
            long idle_time;
            
            long max_time = 1800;
            long wait_time=0;
            bool sleep_enabled=false;
            for (; ; )
            {
                // how to measure the overhead of GetLastInputTime and Sleep function?
                
                idle_time = GetLastInputTime()/1000;
                wait_time = max_time - idle_time;

               
                if (idle_time >= max_time)
                {
                    if (!sleep_enabled)
                    {
                        Process.Start("C:\\Users\\jack\\Desktop\\wintool\\sleep.bat");
                        sleep_enabled = true;
                    }
                    
                    Thread.Sleep(30*1000);
                    
                }
                else
                {
                    if (sleep_enabled)
                    {
                        sleep_enabled = false;
                    }
                    
                    Console.WriteLine("wait ... {0} {1}", wait_time, "seconds");
                }


                if (wait_time > 60)
                {
                    Thread.Sleep(10000);
                }
                else
                {
                    Thread.Sleep(1000);
                }
                
            }

            
        }
    }
}
