using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Shapes;

namespace FigureDraw.Effect
{
    abstract class ShapeEffect
    {
        protected Shape shape;

        public ShapeEffect(Shape shape)
        {
            this.shape = shape;
        }

        public virtual void DrawEffect(CommonGraphics g)
        {
        }
    }
}
