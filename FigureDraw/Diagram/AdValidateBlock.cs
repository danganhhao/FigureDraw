﻿using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class AdValidateBlock: ValidateBlock
    {
        public AdValidateBlock(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            MyPoint p1 = new MyPoint((shapeInfo.point1.x + shapeInfo.point2.x) / 2, shapeInfo.point1.y);
            MyPoint p2 = new MyPoint(shapeInfo.point2.x, (shapeInfo.point1.y + shapeInfo.point2.y) / 2);
            MyPoint p3 = new MyPoint((shapeInfo.point1.x + shapeInfo.point2.x) / 2, shapeInfo.point2.y);
            MyPoint p4 = new MyPoint(shapeInfo.point1.x, (shapeInfo.point1.y + shapeInfo.point2.y) / 2);
            g.DrawLine(p1.x, p1.y, p2.x, p2.y);
            g.DrawLine(p2.x, p2.y, p3.x, p3.y);
            g.DrawLine(p3.x, p3.y, p4.x, p4.y);
            g.DrawLine(p4.x, p4.y, p1.x, p1.y);
        }
    }
}
