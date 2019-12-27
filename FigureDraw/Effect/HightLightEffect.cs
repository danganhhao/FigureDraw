using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Shapes;

namespace FigureDraw.Effect
{
    class HightLightEffect : ShapeEffect
    {
        public HightLightEffect(Shape shape) : base(shape)
        {
        }

        public override void Draw(CommonGraphics g)
        {
            base.Draw(g);
        }
    }
}
