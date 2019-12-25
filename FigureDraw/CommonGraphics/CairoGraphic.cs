using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class CairoGraphic: CommonGraphics
    {
        //Context c;

        //public CairoGraphic(Context c)
        //{
        //    this.c = c;
        //}

        public void DrawEllipse(int x1, int y1, int x2, int y2)
        {
            //c.Scale(double width, double height);
            //c.Arc(double x, double y, double radius, double angle1, double angle2);
            //c.Stroke();
        }

        public void DrawFillEllipse(int x1, int y1, int x2, int y2)
        {
        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            //c.MoveTo(x1, y1);
            //c.LineTo(y2, y2);
            //c.Stroke();
        }

        public void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            //c.Rectangle(x1, y1, (double)Math.Abs(x2 - x1), (double)Math.Abs(y2 - y1));
            //c.Stroke();
        }

        public void DrawRoundedRectangle(int x1, int y1, int x2, int y2, int radius)
        {
            
        }

        public void DrawText(int x, int y, string text, float size)
        {
        }
    }
}
