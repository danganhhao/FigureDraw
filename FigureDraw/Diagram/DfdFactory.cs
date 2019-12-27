using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class DfdFactory : DiagramFactory
    {
        public override EndBlock CreateEndBlock(ShapeInfo shapeInfo)
        {
            return new DfdEndBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override InputBlock CreateInputBlock(ShapeInfo shapeInfo)
        {
            return new DfdInputBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override OutputBlock CreateOutputBlock(ShapeInfo shapeInfo)
        {
            return new DfdOutputBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override ProcessBlock CreateProcessBlock(ShapeInfo shapeInfo)
        {
            return new DfdProcessBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override StartBlock CreateStartBlock(ShapeInfo shapeInfo)
        {
            return new DfdStartBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override TransferBlock CreateTransferBlock(ShapeInfo shapeInfo)
        {
            return new DfdTransferBlock(shapeInfo.point1.x, shapeInfo.point1.y, shapeInfo.point2.x, shapeInfo.point2.y);
        }

        public override ValidateBlock CreateValidateBlock(ShapeInfo shapeInfo)
        {
            return base.CreateValidateBlock(shapeInfo);
        }
    }
}
