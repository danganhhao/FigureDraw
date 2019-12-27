using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class AdOutputBlock: OutputBlock
    {
        public AdOutputBlock(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            int tempx = (int)(Math.Abs(shapeInfo.point1.x - shapeInfo.point2.x) * 0.2);
            int tempy = (int)(Math.Abs(shapeInfo.point1.y - shapeInfo.point2.y) * 0.2);
            g.DrawLine(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point1.y);
            g.DrawLine(shapeInfo.point2.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y - tempy);
            g.DrawLine(shapeInfo.point2.x, shapeInfo.point2.y - tempy, shapeInfo.point2.x - tempx, shapeInfo.point2.y);
            g.DrawLine(shapeInfo.point1.x, shapeInfo.point2.y, shapeInfo.point2.x - tempx, shapeInfo.point2.y);
            g.DrawLine(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point1.x, shapeInfo.point2.y);
        }
    }
}
