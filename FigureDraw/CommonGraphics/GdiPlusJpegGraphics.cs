using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    class GdiPlusJpegGraphics: GdiPlusGraphic
    {
        Bitmap bitmap;

        public GdiPlusJpegGraphics(Control control, PaintEventArgs e) : base(control, e)
        {
            bitmap = new Bitmap(control.ClientSize.Width, control.ClientSize.Height);

        }

        public override void Export(List<Shape> shapes, string url)
        {
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            for (int i = 0; i < shapes.Count; i++)
                shapes[i].Draw(this);
            bitmap.Save(url, ImageFormat.Jpeg);
        }
    }
}
