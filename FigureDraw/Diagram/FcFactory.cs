using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class FcFactory : DiagramFactory
    {
        public override EndBlock CreateEndBlock(SharpInfo sharpInfo)
        {
            return new FcEndBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override InputBlock CreateInputBlock(SharpInfo sharpInfo)
        {
            return new FcInputBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override OutputBlock CreateOutputBlock(SharpInfo sharpInfo)
        {
            return new FcOutputBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override ProcessBlock CreateProcessBlock(SharpInfo sharpInfo)
        {
            return new FcProcessBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override StartBlock CreateStartBlock(SharpInfo sharpInfo)
        {
            return new FcStartBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override TransferBlock CreateTransferBlock(SharpInfo sharpInfo)
        {
            return new FcTransferBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override ValidateBlock CreateValidateBlock(SharpInfo sharpInfo)
        {
            return new FcValidateBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }
    }
}
