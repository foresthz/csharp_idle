﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_map
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            FileSystemWatcher watcher;
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new image_map());
        }
    }
}
