using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Shapes
{
    public class MyPoint
    {
        public int x;
        public int y;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class ShapeInfo
    {
        public MyPoint point1;
        public MyPoint point2;

        public ShapeInfo(MyPoint point1, MyPoint point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
    }
}
