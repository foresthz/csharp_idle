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



namespace helloworld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_msg1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi", "消息标题");
        }

        private void btn_launch_calc_Click(object sender, EventArgs e)
        {
            // Start is static member function, cannot be invoked from instance
            Process process = new Process();
            Process.Start("calc");
        }

        private void btn_launch_from_path_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbox_program_path.Text.ToString(), "程序路径");
            Process.Start(tbox_program_path.Text);
            
        }

        private void tbox_program_path_TextChanged(object sender, EventArgs e)
        {

        }

        // open dialog and navigate to program
        private void btn_navigate_to_program_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String fName = ofd.FileName;
                tbox_program_path.Text = fName;
                MessageBox.Show(fName);
                Process.Start(fName);
            }
        }

    }
}
