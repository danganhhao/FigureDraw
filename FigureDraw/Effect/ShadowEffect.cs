using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Effect
{
    class ShadowEffect : ShapeEffect
    {
        public ShadowEffect(Shape shape) : base(shape)
        {
        }

        public override void Draw(CommonGraphics g)
        {
            shape.DrawShadow(g);
        }
    }
}
