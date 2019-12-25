
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class AdEndBlock: EndBlock
    {
        public AdEndBlock(int x1, int y1, int x2, int y2)
        {
            sharpInfo = new SharpInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawEllipse(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
            MyPoint p1 = new MyPoint((int)(sharpInfo.point1.x + (sharpInfo.point1.x + sharpInfo.point2.x) * 0.25), (int)(sharpInfo.point1.y + (sharpInfo.point1.y + sharpInfo.point2.y) * 0.25));
            MyPoint p2 = new MyPoint((int)(sharpInfo.point2.x - (sharpInfo.point1.x + sharpInfo.point2.x) * 0.25), (int)(sharpInfo.point2.y - (sharpInfo.point1.y + sharpInfo.point2.y) * 0.25));
            g.DrawFillEllipse(p1.x, p1.y, p2.x, p2.y);
        }
    }
}
