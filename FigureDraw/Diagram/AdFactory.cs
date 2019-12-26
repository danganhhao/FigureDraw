using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class AdFactory: DiagramFactory
    {
        public override EndBlock CreateEndBlock(SharpInfo sharpInfo)
        {
            return new AdEndBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override InputBlock CreateInputBlock(SharpInfo sharpInfo)
        {
            return new AdInputBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override OutputBlock CreateOutputBlock(SharpInfo sharpInfo)
        {
            return new AdOutputBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override ProcessBlock CreateProcessBlock(SharpInfo sharpInfo)
        {
            return new AdProcessBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override StartBlock CreateStartBlock(SharpInfo sharpInfo)
        {
            return new AdStartBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override TransferBlock CreateTransferBlock(SharpInfo sharpInfo)
        {
            return new AdTransferBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }

        public override ValidateBlock CreateValidateBlock(SharpInfo sharpInfo)
        {
            return new AdValidateBlock(sharpInfo.point1.x, sharpInfo.point1.y, sharpInfo.point2.x, sharpInfo.point2.y);
        }
    }
}
