using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class MyDiagram: Sharp
    {
        public List<Block> blocks = new List<Block>();
        public DiagramFactory factory;

        public MyDiagram(DiagramFactory f)
        {
            factory = f;
        }

        public void CreateDiagram()
        {
            blocks.Add(factory.CreateStartBlock(new SharpInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateInputBlock(new SharpInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateProcessBlock(new SharpInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateOutputBlock(new SharpInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateProcessBlock(new SharpInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateValidateBlock(new SharpInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateEndBlock(new SharpInfo(new MyPoint(10, 10), new MyPoint(200, 150))));

        }
        public override void Draw(CommonGraphics g)
        {
            foreach(Block block in blocks)
            {
                block.Draw(g);
            }
        }
    }
}
