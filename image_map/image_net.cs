using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_map
{
    public partial class image_map : Form
    {
        public image_map()
        {
            InitializeComponent();
        }

        private void image_map_Load(object sender, EventArgs e)
        {
            String path = "C:/Program Files/MATLAB/R2012a/bin/matlab.exe";

            pbox_sample.Image = Icon.ExtractAssociatedIcon(path).ToBitmap();
        }
    }
}
