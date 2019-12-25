using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigureDraw.Diagram;

namespace FigureDraw
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics g;
        CommonGraphics graphics;
        List<Sharp> shapes = new List<Sharp>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            graphics = new GdiPlusGraphic(panel1);
            //Sharp a = new FcStartBlock(10,10, 150,75);
            //Sharp a = new FcInputBlock(10, 10, 150, 75);
            //Sharp a = new FcOutputBlock(10, 10, 150, 75);
            //Sharp a = new DfdInputBlock(10, 10, 150, 75);
            //Sharp a = new AdProcessBlock(10, 10, 150, 75);
            //MyDiagram diagram = new MyDiagram(new DfdFactory());
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
            Sharp line = new Line(10, 10, 200, 100);
            shapes.Add(line);
            line.Draw(graphics);
            Invalidate();
        }
    }
}
