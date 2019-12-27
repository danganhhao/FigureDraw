using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class AdTransferBlock : TransferBlock
    {
        public AdTransferBlock(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            float m = shapeInfo.point2.x - shapeInfo.point1.x == 0 ? 0 : (shapeInfo.point2.y - shapeInfo.point1.y) / (shapeInfo.point2.x - shapeInfo.point1.x);
            double degree = Math.Atan(m);
            double toLeft = shapeInfo.point2.x > shapeInfo.point1.x ? 0 : Math.PI;
            double degree1 = degree + 5 * Math.PI / 6 + toLeft;
            double degree2 = degree + 7 * Math.PI / 6 + toLeft;

            int px1 = (int)(shapeInfo.point2.x + Math.Cos(degree1) * 10);
            int py1 = (int)(shapeInfo.point2.y + Math.Sin(degree1) * 10);

            int px2 = (int)(shapeInfo.point2.x + Math.Cos(degree2) * 10);
            int py2 = (int)(shapeInfo.point2.y + Math.Sin(degree2) * 10);

            g.DrawLine(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
            g.DrawLine(shapeInfo.point2.x, shapeInfo.point2.y, px1, py1);
            g.DrawLine(shapeInfo.point2.x, shapeInfo.point2.y, px2, py2);
        }
    }
}
