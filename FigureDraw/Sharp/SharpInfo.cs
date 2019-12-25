using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class MyPoint
    {
        public int x;
        public int y;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class SharpInfo
    {
        public MyPoint point1;
        public MyPoint point2;

        public SharpInfo(MyPoint point1, MyPoint point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
    }
}
