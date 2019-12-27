using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigureDraw.Diagram;
using FigureDraw.Shapes;

namespace FigureDraw
{
    public enum ShapeMode
    {
        Line,
        Rectangle, 
        Ellipse
    }

    public partial class Form1 : Form
    {
        System.Drawing.Graphics g;
        CommonGraphics graphics;
        List<Shape> shapes = new List<Shape>();
        ShapeMode shapeMode;
        bool isDrawing = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            graphics = new GdiPlusBitmapGraphics(panel1);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < shapes.Count; i++)
                shapes[i].Draw(graphics);
            //Sharp a = new FcStartBlock(10,10, 150,75);
            //Sharp a = new FcInputBlock(10, 10, 150, 75);
            //Sharp a = new FcOutputBlock(10, 10, 150, 75);
            //Sharp a = new DfdInputBlock(10, 10, 150, 75);
            //Sharp a = new AdProcessBlock(10, 10, 150, 75);
            //MyDiagram diagram = new MyDiagram(new AdFactory());
            //diagram.CreateDiagram();
            //diagram.Draw(graphics);



            //a.Draw(new GdiPlusBitmapGraphics(g));
            //a.Draw(new CairoGraphic(new Context(new Win32Surface(g.GetHdc()))));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeMode = ShapeMode.Line;
        }
        private void RectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeMode = ShapeMode.Rectangle;
        }

        private void EllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeMode = ShapeMode.Ellipse;
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            switch (shapeMode)
            {
                case ShapeMode.Line:
                    Shape line = new FcStartBlock(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y);
                    shapes.Add(line);
                    break;
                case ShapeMode.Rectangle:
                    Shape rectangle = new FigureDraw.Shapes.Rectangle(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y);
                    shapes.Add(rectangle);
                    break;
                case ShapeMode.Ellipse:
                    Shape ellipse = new FigureDraw.Shapes.Ellipse(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y);
                    shapes.Add(ellipse);
                    break;
            }
            //line.Draw(graphics);
            //panel1.Invalidate();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (i == shapes.Count - 1)
                        shapes[i].shapeInfo.point2 = new FigureDraw.Shapes.MyPoint(e.Location.X, e.Location.Y);
                }
                panel1.Invalidate();
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (i == shapes.Count - 1)
                {
                    shapes[i].shapeInfo.point2 = new FigureDraw.Shapes.MyPoint(e.Location.X, e.Location.Y);
                }
            }
            panel1.Invalidate();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            panel1.Controls.Clear();
            panel1.Invalidate();
        }
    }
}
