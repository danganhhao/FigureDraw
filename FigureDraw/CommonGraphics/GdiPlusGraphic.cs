using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    public class GdiPlusGraphic : CommonGraphics
    {
        public Graphics g;

        public GdiPlusGraphic(Control control)
        {
            g = control.CreateGraphics();
        }

        public override void DrawArc(int x, int y, int width, int height, float startAngle, float sweepAngle)
        {
            width = width == 0 ? 1 : width;
            height = height == 0 ? 1 : height;
            g.DrawArc(new Pen(Color.Black), x, y, width, height, startAngle, sweepAngle);
        }

        public override void DrawEllipse(int x1, int y1, int x2, int y2)
        {
            g.DrawEllipse(new Pen(Color.Black), x1, y1, (int)Math.Abs(x2 - x1), (int)Math.Abs(y2 - y1));
        }

        public override void DrawFillEllipse(int x1, int y1, int x2, int y2)
        {
            g.FillEllipse(new SolidBrush(Color.Black), x1, y1, (int)Math.Abs(x2 - x1), (int)Math.Abs(y2 - y1));
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
        }

        public override void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            g.DrawRectangle(new Pen(Color.Black), x1, y1, (int)Math.Abs(x2 - x1), (int)Math.Abs(y2 - y1));
        }

        public override void DrawRoundedRectangle(int x1, int y1, int x2, int y2, int radius)
        {
            int diameter = radius;
            System.Drawing.Rectangle arc = new System.Drawing.Rectangle(x1, y1, x2, y2);
            System.Drawing.Rectangle bounds = new System.Drawing.Rectangle(x1, y1, x2, y2);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
            }
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            g.DrawPath(new Pen(Color.Black), path);
        }

        public override void DrawText(int x, int y, string text, float size)
        {
            size = size == 0 ? 0.01f : size;
            Font drawFont = new Font("Arial", size);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            g.DrawString(text, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
        }
    }
}
