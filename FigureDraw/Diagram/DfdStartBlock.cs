using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class DfdStartBlock : StartBlock
    {
        public DfdStartBlock(int x1, int y1, int x2, int y2)
        {
            sharpInfo = new SharpInfo(new MyPoint(x1, y1), new MyPoint(x2, y2));
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawEllipse(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
            g.DrawText(sharpInfo.point1.x + (int)(Math.Abs(sharpInfo.point1.x - sharpInfo.point2.x) * 0.4),
                sharpInfo.point1.y + (int)(Math.Abs(sharpInfo.point1.y - sharpInfo.point2.y) * 0.4),
                "1", (float)Math.Min((Math.Abs(sharpInfo.point1.x - sharpInfo.point2.x) * 0.2), (Math.Abs(sharpInfo.point1.y - sharpInfo.point2.y) * 0.2)));
        }
    }
}
