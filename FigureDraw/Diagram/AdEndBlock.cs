
using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class AdEndBlock: EndBlock
    {
        public AdEndBlock(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawEllipse(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
            MyPoint p1 = new MyPoint((int)(shapeInfo.point1.x + Math.Abs(shapeInfo.point1.x - shapeInfo.point2.x) * 0.25), (int)(shapeInfo.point1.y + Math.Abs(shapeInfo.point1.y - shapeInfo.point2.y) * 0.25));
            MyPoint p2 = new MyPoint((int)(shapeInfo.point2.x - Math.Abs(shapeInfo.point1.x - shapeInfo.point2.x) * 0.25), (int)(shapeInfo.point2.y - Math.Abs(shapeInfo.point1.y - shapeInfo.point2.y) * 0.25));
            g.DrawFillEllipse(Color.Black, p1.x, p1.y, p2.x, p2.y);
        }
    }
}
