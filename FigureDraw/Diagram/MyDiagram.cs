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
            shapeInfo = new ShapeInfo(new MyPoint(0, 0), new MyPoint(100,100));
        }

        public void CreateDiagram()
        {
            blocks.Add(factory.CreateStartBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, shapeInfo.point1.y), new MyPoint(shapeInfo.point2.x, shapeInfo.point2.y))));
            blocks.Add(factory.CreateInputBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, shapeInfo.point1.y), new MyPoint(shapeInfo.point2.x, shapeInfo.point2.y))));
            blocks.Add(factory.CreateProcessBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, shapeInfo.point1.y), new MyPoint(shapeInfo.point2.x, shapeInfo.point2.y))));
            blocks.Add(factory.CreateOutputBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, shapeInfo.point1.y), new MyPoint(shapeInfo.point2.x, shapeInfo.point2.y))));
            blocks.Add(factory.CreateProcessBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, shapeInfo.point1.y), new MyPoint(shapeInfo.point2.x, shapeInfo.point2.y))));
            blocks.Add(factory.CreateValidateBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, shapeInfo.point1.y), new MyPoint(shapeInfo.point2.x, shapeInfo.point2.y))));
            blocks.Add(factory.CreateEndBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, shapeInfo.point1.y), new MyPoint(shapeInfo.point2.x, shapeInfo.point2.y))));
        }

        public void UpdateDiagram(int x1, int y1, int x2, int y2)
        {
            foreach(Block b in blocks)
            {
                b.shapeInfo.point1.x = x1; b.shapeInfo.point1.y = y1;
                b.shapeInfo.point2.x = x2; b.shapeInfo.point2.y = y2;
            }
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
