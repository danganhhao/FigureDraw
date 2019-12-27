﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Shapes;

namespace FigureDraw.Effect
{
    abstract class ShapeEffect : Shape
    {
        protected Shape shape;

        public ShapeEffect(Shape shape)
        {
            this.shape = shape;
        }

        public override void Draw(CommonGraphics g)
        {
            shape.Draw(g);
        }
    }
}
