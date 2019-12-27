using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class AdFactory: DiagramFactory
    {
        public override EndBlock CreateEndBlock(ShapeInfo shapeInfo)
        {
            return new AdEndBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override InputBlock CreateInputBlock(ShapeInfo shapeInfo)
        {
            return new AdInputBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override OutputBlock CreateOutputBlock(ShapeInfo shapeInfo)
        {
            return new AdOutputBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override ProcessBlock CreateProcessBlock(ShapeInfo shapeInfo)
        {
            return new AdProcessBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override StartBlock CreateStartBlock(ShapeInfo shapeInfo)
        {
            return new AdStartBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override TransferBlock CreateTransferBlock(ShapeInfo shapeInfo)
        {
            return new AdTransferBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override ValidateBlock CreateValidateBlock(ShapeInfo shapeInfo)
        {
            return new AdValidateBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }
    }
}
