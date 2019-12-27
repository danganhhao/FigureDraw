using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Shapes;

namespace FigureDraw
{
    class CairoGraphic : CommonGraphics
    {
        //Context c;

        //public CairoGraphic(Context c)
        //{
        //    this.c = c;
        //}
        public override void DrawArc(int x, int y, int width, int height, float startAngle, float sweepAngle)
        {
            base.DrawArc(x, y, width, height, startAngle, sweepAngle);
        }

        public override void DrawEllipse(int x1, int y1, int x2, int y2)
        {
            base.DrawEllipse(x1, y1, x2, y2);
        }

        public override void DrawFillEllipse(int x1, int y1, int x2, int y2)
        {
            base.DrawFillEllipse(x1, y1, x2, y2);
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            base.DrawLine(x1, y1, x2, y2);
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
