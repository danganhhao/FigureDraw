using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Shapes;

namespace FigureDraw.Effect
{
    class BorderEffect : ShapeEffect
    {
        public BorderEffect(Shape shape) : base(shape)
        {
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawPoint(shape.shapeInfo.point1.x, shape.shapeInfo.point1.y);
            g.DrawPoint(shape.shapeInfo.point2.x, shape.shapeInfo.point1.y);
            g.DrawPoint(shape.shapeInfo.point1.x, shape.shapeInfo.point2.y);
            g.DrawPoint(shape.shapeInfo.point2.x, shape.shapeInfo.point2.y);
        }
    }
}
