using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class Rectangle : Sharp
    {
        public Rectangle()
        {
            sharpInfo = new SharpInfo(new MyPoint(10, 10), new MyPoint(30, 40));
        }
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            sharpInfo = new SharpInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawRectangle(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }
    }
}
