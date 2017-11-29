using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace idle_all
{
    
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{11111-all-idel-2332asadf-build}");
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]

        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new idleForm());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("只能运行一个实例");
            }

        }
    }
}
