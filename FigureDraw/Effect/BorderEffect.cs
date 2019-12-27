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

        public override void DrawEffect(CommonGraphics g)
        {
            base.DrawEffect(g);
        }
    }
}
