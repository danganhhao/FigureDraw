using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class MyDiagram: Shape
    {
        public List<Block> blocks = new List<Block>();
        public DiagramFactory factory;

        public MyDiagram(DiagramFactory f)
        {
            factory = f;
        }

        public void CreateDiagram()
        {
            blocks.Add(factory.CreateStartBlock(new ShapeInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateInputBlock(new ShapeInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateProcessBlock(new ShapeInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateOutputBlock(new ShapeInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateProcessBlock(new ShapeInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateValidateBlock(new ShapeInfo(new MyPoint(10, 10), new MyPoint(200, 150))));
            blocks.Add(factory.CreateEndBlock(new ShapeInfo(new MyPoint(10, 10), new MyPoint(200, 150))));

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
