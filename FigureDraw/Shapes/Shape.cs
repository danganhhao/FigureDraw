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
        public virtual void DrawWithBrush(CommonGraphics g) { }
        public virtual void UpdateShapeInfo(int x1, int y1, int x2, int y2) { }
    }
}
