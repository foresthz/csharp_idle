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

namespace multi_forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("c:");
        }

        private void popFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopForm dialog = new PopForm();
            dialog.ShowDialog();
            // cannot use two Application.Run, what's wrong? 
            // Application.Run(new PopForm());
        }
    }
}
