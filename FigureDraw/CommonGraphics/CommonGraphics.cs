using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    public interface CommonGraphics
    {
        void DrawLine(int x1, int y1, int x2, int y2);
        void DrawRectangle(int x1, int y1, int x2, int y2);
        void DrawEllipse(int x1, int y1, int x2, int y2);
        void DrawText(int x, int y, string text, float size);
        void DrawFillEllipse(int x1, int y1, int x2, int y2);
        void DrawRoundedRectangle(int x1, int y1, int x2, int y2, int radius);
        void DrawArc(int x, int y, int width, int height, float startAngle, float sweepAngle);
    }
}
