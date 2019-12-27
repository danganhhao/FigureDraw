using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    abstract class DiagramFactory
    {
        public virtual StartBlock CreateStartBlock(ShapeInfo sharpInfo){ return null; }
        public virtual InputBlock CreateInputBlock(ShapeInfo sharpInfo) { return null; }
        public virtual ProcessBlock CreateProcessBlock(ShapeInfo sharpInfo) { return null; }
        public virtual OutputBlock CreateOutputBlock(ShapeInfo sharpInfo) { return null; }
        public virtual TransferBlock CreateTransferBlock(ShapeInfo sharpInfo) { return null; }
        public virtual ValidateBlock CreateValidateBlock(ShapeInfo sharpInfo) { return null; }
        public virtual EndBlock CreateEndBlock(ShapeInfo sharpInfo) { return null; }

    }
}
