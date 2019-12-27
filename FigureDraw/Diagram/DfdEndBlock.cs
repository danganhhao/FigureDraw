using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class DfdEndBlock: EndBlock
    {
        public DfdEndBlock(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawEllipse(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
            g.DrawText(shapeInfo.point1.x + (int)(Math.Abs(shapeInfo.point1.x - shapeInfo.point2.x) * 0.4),
                shapeInfo.point1.y + (int)(Math.Abs(shapeInfo.point1.y - shapeInfo.point2.y) * 0.4),
                "N", (float)Math.Min((Math.Abs(shapeInfo.point1.x - shapeInfo.point2.x) * 0.2), (Math.Abs(shapeInfo.point1.y - shapeInfo.point2.y) * 0.2)));
        }
    }
}
