using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class FcInputBlock : InputBlock
    {
        public FcInputBlock(int x1, int y1, int x2, int y2)
        {
            sharpInfo = new SharpInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            int temp = (int)(Math.Abs(sharpInfo.point1.x - sharpInfo.point2.x) * 0.1);
            g.DrawLine(sharpInfo.point1.x + temp, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point1.y);
            g.DrawLine(sharpInfo.point2.x, sharpInfo.point1.y, sharpInfo.point2.x - temp, sharpInfo.point2.y);
            g.DrawLine(sharpInfo.point1.x, sharpInfo.point2.y, sharpInfo.point2.x - temp, sharpInfo.point2.y);
            g.DrawLine(sharpInfo.point1.x + temp, sharpInfo.point1.y, sharpInfo.point1.x, sharpInfo.point2.y);


        }
    }
}
