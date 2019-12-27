using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class FcFactory : DiagramFactory
    {
        public override EndBlock CreateEndBlock(ShapeInfo shapeInfo)
        {
            return new FcEndBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override InputBlock CreateInputBlock(ShapeInfo shapeInfo)
        {
            return new FcInputBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override OutputBlock CreateOutputBlock(ShapeInfo shapeInfo)
        {
            return new FcOutputBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override ProcessBlock CreateProcessBlock(ShapeInfo shapeInfo)
        {
            return new FcProcessBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override StartBlock CreateStartBlock(ShapeInfo shapeInfo)
        {
            return new FcStartBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override TransferBlock CreateTransferBlock(ShapeInfo shapeInfo)
        {
            return new FcTransferBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override ValidateBlock CreateValidateBlock(ShapeInfo shapeInfo)
        {
            return new FcValidateBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }
    }
}
