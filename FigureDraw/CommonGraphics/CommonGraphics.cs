using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    public abstract class CommonGraphics
    {
        public virtual void DrawPoint(int x, int y) { }
        public virtual void DrawLine(int x1, int y1, int x2, int y2) { }
        public virtual void DrawRectangle(int x1, int y1, int x2, int y2) { }
        public virtual void DrawEllipse(int x1, int y1, int x2, int y2) { }
        public virtual void DrawText(int x, int y, string text, float size) { }
        public virtual void DrawFillEllipse(int x1, int y1, int x2, int y2) { }
        public virtual void DrawRoundedRectangle(int x1, int y1, int x2, int y2, int radius) { }
        public virtual void DrawArc(int x, int y, int width, int height, float startAngle, float sweepAngle) { }
        public virtual void DrawLineBrush(int x1, int y1, int x2, int y2, int width) { }
        public virtual void DrawRectangleBrush(int x1, int y1, int x2, int y2, int width) { }
        public virtual void DrawEllipseBrush(int x1, int y1, int x2, int y2, int width) { }
        public virtual void DrawArcBrush(int x, int y, int width, int height, float startAngle, float sweepAngle, int brushWidth) { }
        public virtual void Export(List<Shape> shapes, string url) { }
    }
}
