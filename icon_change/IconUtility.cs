using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Text;

namespace icon_change
{
    class IconUtility
    {
        // implement the effect as everest do.
        public static Icon getIconWithNumber(String iconPath, String str)
        {
           
            Icon icon = new Icon(iconPath);
            Font font = new Font("Calibri", 8, FontStyle.Regular);
            SolidBrush brush = new SolidBrush(Color.Red);

            Bitmap bitmap = new Bitmap(16, 16);

            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.TextRenderingHint = TextRenderingHint.SystemDefault;

            graphic.DrawIcon(icon, 0, 0);
            graphic.DrawString(str, font, brush, 1, 2);

            // bitmap.Save("new.ico", System.Drawing.Imaging.ImageFormat.Icon);

            Icon createdIcon = Icon.FromHandle(bitmap.GetHicon());

            font.Dispose();
            brush.Dispose();
            graphic.Dispose();
            bitmap.Dispose();
            
            return createdIcon;
        }
    }
}
