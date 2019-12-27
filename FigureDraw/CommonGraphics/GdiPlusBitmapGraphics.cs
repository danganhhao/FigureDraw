using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FigureDraw.Shapes;

namespace FigureDraw
{
    class GdiPlusBitmapGraphics : GdiPlusGraphic
    {
        Bitmap bitmap;
        
        public GdiPlusBitmapGraphics(Control control, PaintEventArgs e) : base(control, e)
        {
            bitmap = new Bitmap(control.ClientSize.Width, control.ClientSize.Height);
        }

        public override void Export(List<Shape> shapes, string url)
        {
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            for (int i = 0; i < shapes.Count; i++)
                shapes[i].Draw(this);
            bitmap.Save(url, ImageFormat.Bmp);
        }
    }
}