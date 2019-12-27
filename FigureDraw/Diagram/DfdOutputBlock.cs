﻿using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class DfdOutputBlock: OutputBlock
    {
        public DfdOutputBlock(int x1, int y1, int x2, int y2)
        {
            shapeInfo = new ShapeInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            int temp = (int)(Math.Abs(shapeInfo.point1.x - shapeInfo.point2.x) * 0.15f);
            g.DrawRectangle(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
            g.DrawLine(shapeInfo.point1.x + temp, shapeInfo.point1.y, shapeInfo.point1.x + temp, shapeInfo.point2.y);
            g.DrawLine(shapeInfo.point2.x - temp, shapeInfo.point1.y, shapeInfo.point2.x - temp, shapeInfo.point2.y);
        }
    }
}
