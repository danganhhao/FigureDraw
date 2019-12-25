using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    public class GdiPlusGraphic : CommonGraphics
    {
        Graphics g;

        public GdiPlusGraphic(Control control)
        {
            g = control.CreateGraphics();
        }

        public void DrawEllipse(int x1, int y1, int x2, int y2)
        {
            g.DrawEllipse(new Pen(Color.Black), x1, y1, (int)Math.Abs(x2 - x1), (int)Math.Abs(y2 - y1));
        }

        public void DrawFillEllipse(int x1, int y1, int x2, int y2)
        {
            g.FillEllipse(new SolidBrush(Color.Black), x1, y1, (int)Math.Abs(x2 - x1), (int)Math.Abs(y2 - y1));
        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
        }

        public void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            g.DrawRectangle(new Pen(Color.Black), x1, y1, (int)Math.Abs(x2 - x1), (int)Math.Abs(y2 - y1));
        }

        public void DrawRoundedRectangle(int x1, int y1, int x2, int y2, int radius)
        {
            int diameter = radius ;
            System.Drawing.Rectangle arc = new System.Drawing.Rectangle(x1,y1,x2,y2);
            System.Drawing.Rectangle bounds = new System.Drawing.Rectangle(x1, y1, x2, y2);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
            }
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            g.DrawPath(new Pen(Color.Black), path);
        }

        public void DrawText(int x, int y, string text, float size)
        {
            size = size == 0 ? 0.01f : size;
            Font drawFont = new Font("Arial", size);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            g.DrawString(text, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            g.Dispose();
        }

        /*
         *  Bitmap bmp1 = new Bitmap(typeof(Button), "Button.bmp");

            // Save the image as a GIF.
            bmp1.Save("c:\\button.gif", System.Drawing.Imaging.ImageFormat.Gif);

            // Construct a new image from the GIF file.
            Bitmap bmp2 = new Bitmap("c:\\button.gif");

            // Draw the two images.
            e.Graphics.DrawImage(bmp1, new Point(10, 10));
            e.Graphics.DrawImage(bmp2, new Point(10, 40));

            // Dispose of the image files.
            bmp1.Dispose();
            bmp2.Dispose();


            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = "d:\\";
            saveFile.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            saveFile.FileName = ".txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFile.FileName).Close();
                for (int i = 0; i < shapes.Count; i++)
                {
                    shapes[i].Save(saveFile.FileName);
                }
            }
         
         */
    }
}
