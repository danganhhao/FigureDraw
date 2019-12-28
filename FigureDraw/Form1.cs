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
using FigureDraw.Effect;
using FigureDraw.Shapes;
using Cairo;

namespace FigureDraw
{
    public enum ShapeMode
    {
        Line,
        Rectangle, 
        Ellipse,
        FcDiagram,
        DfdDiagram,
        AdDiagram
    }

    public enum Mode
    {
        Normal,
        Diagram
    }

    public partial class Form1 : Form
    {
        
        CommonGraphics graphics;
        List<Shape> shapes = new List<Shape>();
        Dictionary<Shape, Shape> shapeEffects = new Dictionary<Shape, Shape>();
        ShapeMode shapeMode;
        Mode mode;
        bool isDrawing = false;
        PaintEventArgs paintEventArgs;

        public Form1()
        {
            InitializeComponent();
        }

        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            paintEventArgs = e;
            graphics = new GdiPlusGraphic(panel1, e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw(graphics);
                if (shapeEffects.ContainsKey(shapes[i]))
                {
                    shapeEffects[shapes[i]].Draw(graphics);
                }
            }
            //a.Draw(new GdiPlusBitmapGraphics(g));
            //a.Draw(new CairoGraphic(new Context(new Win32Surface(g.GetHdc()))));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDoubleBuffering(panel1, true);
        }

        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeMode = ShapeMode.Line;
            mode = Mode.Normal;
        }
        private void RectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeMode = ShapeMode.Rectangle;
            mode = Mode.Normal;
        }

        private void EllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeMode = ShapeMode.Ellipse;
            mode = Mode.Normal;
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            if (mode == Mode.Normal)
            {
                switch (shapeMode)
                {
                    case ShapeMode.Line:
                        Shape line = new Line(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y);
                        shapes.Add(line);
                        break;
                    case ShapeMode.Rectangle:
                        Shape rectangle = new Shapes.Rectangle(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y);
                        shapes.Add(rectangle);
                        break;
                    case ShapeMode.Ellipse:
                        Shape ellipse = new Ellipse(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y);
                        shapes.Add(ellipse);
                        break;
                }
            }
            if (mode == Mode.Diagram)
            {
                switch (shapeMode)
                {
                    case ShapeMode.FcDiagram:
                        MyDiagram diagramFc = new MyDiagram(new FcFactory());
                        diagramFc.CreateDiagram();
                        shapes.Add(diagramFc);
                        break;
                    case ShapeMode.DfdDiagram:
                        MyDiagram diagramDfd = new MyDiagram(new DfdFactory());
                        diagramDfd.CreateDiagram();
                        shapes.Add(diagramDfd);
                        break;
                    case ShapeMode.AdDiagram:
                        MyDiagram diagramAd = new MyDiagram(new AdFactory());
                        diagramAd.CreateDiagram();
                        shapes.Add(diagramAd);
                        break;
                }
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (i == shapes.Count - 1)
                    {
                        shapes[i].UpdateShapeInfo(shapes[i].shapeInfo.point1.x, shapes[i].shapeInfo.point1.y,
                                                    e.Location.X, e.Location.Y);
                    }
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
                    shapes[i].shapeInfo.point2 = new MyPoint(e.Location.X, e.Location.Y);
                }
            }
            panel1.Invalidate();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            shapeEffects.Clear();
            panel1.Controls.Clear();
            panel1.Invalidate();
        }

        private SaveFileDialog GetUrl()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = "d:\\";
            // Bitmap Image (.bmp)|*.bmp|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|
            saveFile.Filter = "All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            return saveFile;
        }

        private void BitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = GetUrl();
            saveFile.FileName = ".bmp";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFile.FileName).Close();
                graphics = new GdiPlusBitmapGraphics(panel1, paintEventArgs);
                graphics.Export(shapes, saveFile.FileName);
            }
        }

        private void PngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = GetUrl();
            saveFile.FileName = ".png";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFile.FileName).Close();
                graphics = new GdiPlusPngGraphics(panel1, paintEventArgs);
                graphics.Export(shapes, saveFile.FileName);
            }
        }

        private void GifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = GetUrl();
            saveFile.FileName = ".gif";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFile.FileName).Close();
                graphics = new GdiPlusBitmapGraphics(panel1, paintEventArgs);
                graphics.Export(shapes, saveFile.FileName);
            }
        }

        private void JpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = GetUrl();
            saveFile.FileName = ".jpeg";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFile.FileName).Close();
                graphics = new GdiPlusBitmapGraphics(panel1, paintEventArgs);
                graphics.Export(shapes, saveFile.FileName);
            }
        }

        private void BorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Shape s in shapes)
            {
                Shape borderLine = new BorderEffect(s);
                if (!shapeEffects.ContainsKey(s))
                {
                    shapeEffects.Add(s, borderLine);
                }
            }
            panel1.Invalidate();
        }

        private void HightLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Shape s in shapes)
            {
                Shape borderLine = new BorderEffect(s);
                if (!shapeEffects.ContainsKey(s))
                {
                    shapeEffects.Add(s, borderLine);
                }
            }
            panel1.Invalidate();
        }

        private void FlowchartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Diagram;
            shapeMode = ShapeMode.FcDiagram;
            Clear_Click(sender, e);
        }

        private void DataFlowDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Diagram;
            shapeMode = ShapeMode.DfdDiagram;
            Clear_Click(sender, e);
        }

        private void ActivityDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Diagram;
            shapeMode = ShapeMode.AdDiagram;
            Clear_Click(sender, e);
        }
    }
}
