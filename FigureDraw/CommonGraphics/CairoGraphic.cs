using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cairo;
using FigureDraw.Shapes;

namespace FigureDraw
{
    class CairoGraphic : CommonGraphics
    {
        Context c;
        System.Drawing.Graphics g;
        public CairoGraphic(Control control, PaintEventArgs e)
        {
            g = e.Graphics;
            Surface s = new Win32Surface(g.GetHdc());
            c = new Context(s);
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            c.MoveTo(x1, y1);
            c.LineTo(x2, y2);
            c.Stroke();
        }

        public override void DrawArc(int x, int y, int width, int height, float startAngle, float sweepAngle)
        {
            base.DrawArc(x, y, width, height, startAngle, sweepAngle);
        }

        public override void DrawEllipse(int x1, int y1, int x2, int y2)
        {
            base.DrawEllipse(x1, y1, x2, y2);
        }

        public override void DrawPoint(int x, int y)
        {
            base.DrawPoint(x, y);
        }

        public override void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            base.DrawRectangle(x1, y1, x2, y2);
        }

        public override void DrawRoundedRectangle(int x1, int y1, int x2, int y2, int radius)
        {
            base.DrawRoundedRectangle(x1, y1, x2, y2, radius);
        }

        public override void DrawText(int x, int y, string text, float size)
        {
            base.DrawText(x, y, text, size);
        }

        public override void Export(List<Shape> shapes, string url)
        {
            base.Export(shapes, url);
        }
    }
}
