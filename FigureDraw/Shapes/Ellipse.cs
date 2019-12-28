using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Shapes
{
    class Ellipse : Shape
    {
        public Ellipse()
        {
            shapeInfo = new ShapeInfo(new MyPoint(10, 10), new MyPoint(30, 40));
        }
        public Ellipse(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }
        public override void Draw(CommonGraphics g)
        {
            g.DrawEllipse(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override void UpdateShapeInfo(int x1, int y1, int x2, int y2)
        {
            shapeInfo.point1.x = x1; shapeInfo.point1.y = y1;
            shapeInfo.point2.x = x2; shapeInfo.point2.y = y2;
        }
    }
}
