using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Shapes
{
    public abstract class Shape
    {
        public ShapeInfo shapeInfo;
        public virtual void Draw(CommonGraphics g) { }
    }
}
