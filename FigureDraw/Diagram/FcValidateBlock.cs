using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class FcValidateBlock: ValidateBlock
    {
        public FcValidateBlock(int x1, int y1, int x2, int y2)
        {
            sharpInfo = new SharpInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            MyPoint p1 = new MyPoint((sharpInfo.point1.x + sharpInfo.point2.x) / 2, sharpInfo.point1.y);
            MyPoint p2   = new MyPoint(sharpInfo.point2.x, (sharpInfo.point1.y + sharpInfo.point2.y) / 2);
            MyPoint p3 = new MyPoint((sharpInfo.point1.x + sharpInfo.point2.x) / 2, sharpInfo.point2.y);
            MyPoint p4 = new MyPoint(sharpInfo.point1.x, (sharpInfo.point1.y + sharpInfo.point2.y) / 2);
            g.DrawLine(p1.x, p1.y, p2.x, p2.y);
            g.DrawLine(p2.x, p2.y, p3.x, p3.y);
            g.DrawLine(p3.x, p3.y, p4.x, p4.y);
            g.DrawLine(p4.x, p4.y, p1.x, p1.y);
        }
    }
}
