using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class DfdTransferBlock : TransferBlock
    {
        public DfdTransferBlock(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawArc(shapeInfo.point1.x, shapeInfo.point1.y, (int)(Math.Abs(shapeInfo.point1.x - shapeInfo.point2.x)), (int)(Math.Abs(shapeInfo.point1.y - shapeInfo.point2.y)), 180, 180);

            int tempy2 = shapeInfo.point2.y - (int)(Math.Abs(shapeInfo.point1.y - shapeInfo.point2.y) / 2);
            int tempx1 = shapeInfo.point2.x + 5;
            int tempy1 = shapeInfo.point1.y;
            float m = shapeInfo.point2.x - tempx1 == 0 ? 0 : (tempy2 - tempy1) / (shapeInfo.point2.x - tempx1);

            double degree = Math.Atan(m);
            double toLeft = shapeInfo.point2.x > tempx1 ? 0 : Math.PI;
            double degree1 = degree + 5 * Math.PI / 6 + toLeft;
            double degree2 = degree + 7 * Math.PI / 6 + toLeft;

            int px1 = (int)(shapeInfo.point2.x + Math.Cos(degree1) * 10);
            int py1 = (int)(tempy2 + Math.Sin(degree1) * 10);

            int px2 = (int)(shapeInfo.point2.x + Math.Cos(degree2) * 10);
            int py2 = (int)(tempy2 + Math.Sin(degree2) * 10);

            g.DrawLine(shapeInfo.point2.x, tempy2, px1, py1);
            g.DrawLine(shapeInfo.point2.x, tempy2, px2, py2);
        }
    }
}
