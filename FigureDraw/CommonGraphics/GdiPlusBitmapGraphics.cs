using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    class GdiPlusBitmapGraphics : GdiPlusGraphic
    {
        public GdiPlusBitmapGraphics(Control control) : base(control)
        {
        }

        public void Save(string url)
        {
            //Bitmap bmp1 = new Bitmap(typeof(Button), "Button.bmp");

            //// Save the image as a GIF.
            //bmp1.Save("c:\\button.gif", System.Drawing.Imaging.ImageFormat.Gif);

            //// Construct a new image from the GIF file.
            //Bitmap bmp2 = new Bitmap("c:\\button.gif");

            //// Draw the two images.
            //e.Graphics.DrawImage(bmp1, new Point(10, 10));
            //e.Graphics.DrawImage(bmp2, new Point(10, 40));

            //// Dispose of the image files.
            //bmp1.Dispose();
            //bmp2.Dispose();
            Bitmap bmp = new Bitmap("AA");
            //g.DrawImage(bmp, new Point(10, 10));
            bmp.Save(url, System.Drawing.Imaging.ImageFormat.Bmp);
            bmp.Dispose();
        }
    }
}
