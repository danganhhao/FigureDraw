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
            shapeInfo = new ShapeInfo(new MyPoint(50, 50), new MyPoint(350,200));
        }

        public void CreateDiagram()
        {
            double tempx = Math.Abs(shapeInfo.point1.x - shapeInfo.point2.x);
            double tempy = Math.Abs(shapeInfo.point1.y - shapeInfo.point2.y);
            blocks.Add(factory.CreateStartBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, shapeInfo.point1.y), new MyPoint((int)(shapeInfo.point1.x + tempx * 1/4), (int)(shapeInfo.point1.y + tempy*1/2)))));
            blocks.Add(factory.CreateInputBlock(new ShapeInfo(new MyPoint((int)(shapeInfo.point1.x + tempx * 1/4), shapeInfo.point1.y), new MyPoint((int)(shapeInfo.point1.x + tempx * 1 /2), (int)(shapeInfo.point1.y + tempy * 1/2)))));
            blocks.Add(factory.CreateProcessBlock(new ShapeInfo(new MyPoint((int)(shapeInfo.point1.x + tempx * 1/2), shapeInfo.point1.y), new MyPoint((int)(shapeInfo.point1.x + tempx * 3 /4), (int)(shapeInfo.point1.y + tempy * 1/2)))));
            blocks.Add(factory.CreateOutputBlock(new ShapeInfo(new MyPoint((int)(shapeInfo.point1.x + tempx * 3 /4), shapeInfo.point1.y), new MyPoint((int)(shapeInfo.point1.x + tempx), (int)(shapeInfo.point1.y + tempy * 1/2)))));
            blocks.Add(factory.CreateTransferBlock(new ShapeInfo(new MyPoint(shapeInfo.point1.x, (int)(shapeInfo.point1.y + tempy * 1 / 2)), new MyPoint((int)(shapeInfo.point1.x + tempx * 1 / 4), (int)(shapeInfo.point1.y + tempy)))));
            blocks.Add(factory.CreateValidateBlock(new ShapeInfo(new MyPoint((int)(shapeInfo.point1.x + tempx * 1 / 4), (int)(shapeInfo.point1.y + tempy * 1 / 2)), new MyPoint((int)(shapeInfo.point1.x + tempx * 1 / 2), (int)(shapeInfo.point1.y + tempy)))));
            blocks.Add(factory.CreateEndBlock(new ShapeInfo(new MyPoint((int)(shapeInfo.point1.x + tempx * 1 / 2), (int)(shapeInfo.point1.y + tempy * 1 / 2)), new MyPoint((int)(shapeInfo.point1.x + tempx * 3 / 4), (int)(shapeInfo.point1.y + tempy)))));
        }

        public override void Draw(CommonGraphics g)
        {
            foreach(Block block in blocks)
            {
                if (block != null)
                    block.Draw(g);
            }
        }
        public override void UpdateShapeInfo(int x1, int y1, int x2, int y2)
        {
            shapeInfo.point1.x = x1; shapeInfo.point1.y = y1;
            shapeInfo.point2.x = x2; shapeInfo.point2.y = y2;
            //foreach (Block b in blocks)
            //{
            //    b.shapeInfo.point1.x = x1; b.shapeInfo.point1.y = y1;
            //    b.shapeInfo.point2.x = x2; b.shapeInfo.point2.y = y2;
            //}
        }
    }
}
