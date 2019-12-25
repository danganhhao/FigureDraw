using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    abstract class Sharp
    {
        public SharpInfo sharpInfo;
        public virtual void Draw(CommonGraphics g) { }
    }
}
