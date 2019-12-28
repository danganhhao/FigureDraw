using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle()
        {
            shapeInfo = new ShapeInfo(new MyPoint(10, 10), new MyPoint(30, 40));
        }
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawRectangle(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override void DrawWithBrush(CommonGraphics g)
        {
            g.DrawRectangleBrush(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y, 3);
        }

        public override void DrawShadow(CommonGraphics g)
        {
            g.DrawFillRectangle(Color.Gray, shapeInfo.point1.x + 5, shapeInfo.point1.y + 5, shapeInfo.point2.x + 5, shapeInfo.point2.y + 5);
            g.DrawFillRectangle(Color.White, shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x , shapeInfo.point2.y);
            g.DrawRectangleBrush(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y, 1);
        }

        public override void UpdateShapeInfo(int x1, int y1, int x2, int y2)
        {
            shapeInfo.point1.x = x1; shapeInfo.point1.y = y1;
            shapeInfo.point2.x = x2; shapeInfo.point2.y = y2;
        }
    }
}
