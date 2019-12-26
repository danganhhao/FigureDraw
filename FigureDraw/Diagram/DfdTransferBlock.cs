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
            sharpInfo = new SharpInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            MyPoint midpoint = new MyPoint(0, 0);
            MyPoint p2 = new MyPoint(0, 0);
            MyPoint p4 = new MyPoint(0, 0);
            MyPoint p5 = new MyPoint(0, 0);

            int x2 = (int)(sharpInfo.point2.x + Math.Abs(Math.Cos(45) * 10));
            int y2 = (int)(sharpInfo.point2.y + Math.Abs(Math.Sin(45) * 10));
            p2.x = x2; p2.y = y2;

            g.DrawLine(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
            g.DrawLine(sharpInfo.point2.x, sharpInfo.point2.y, p2.x, p2.y);
            //g.DrawLine(sharpInfo.point2.x, sharpInfo.point2.y, p5.x, p5.y);
            //g.DrawLine(p3.x, p3.y, p4.x, p4.y);
        }
    }
}
