using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    abstract class DiagramFactory
    {
        public virtual StartBlock CreateStartBlock(SharpInfo sharpInfo){ return null; }
        public virtual InputBlock CreateInputBlock(SharpInfo sharpInfo) { return null; }
        public virtual ProcessBlock CreateProcessBlock(SharpInfo sharpInfo) { return null; }
        public virtual OutputBlock CreateOutputBlock(SharpInfo sharpInfo) { return null; }
        public virtual TransferBlock CreateTransferBlock(SharpInfo sharpInfo) { return null; }
        public virtual ValidateBlock CreateValidateBlock(SharpInfo sharpInfo) { return null; }
        public virtual EndBlock CreateEndBlock(SharpInfo sharpInfo) { return null; }

    }
}
