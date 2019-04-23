using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_lab
{
    public partial class Form1 : Form
    {
        Graphics gfx;

        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.DarkBlue);
            gfx.FillRectangle(brush, 0, 0, this.Width, this.Height);
            gfx.DrawRectangle(new Pen(Color.Black, 20), 0, 0, this.Width - 20, this.Height - 40);

            DrawCircles(); //circles

            gfx.FillPolygon(new SolidBrush(Color.Red), GetTriangle(new Point(80, 80), new Point(110, 100)));
            gfx.FillPolygon(new SolidBrush(Color.Red), GetInverseTriangle(new Point(80, 80), new Point(110, 100)));

            gfx.FillPolygon(new SolidBrush(Color.Red), GetTriangle(new Point(130, 160), new Point(160, 180)));
            gfx.FillPolygon(new SolidBrush(Color.Red), GetInverseTriangle(new Point(130, 160), new Point(160, 180)));

            gfx.FillPolygon(new SolidBrush(Color.Red), GetTriangle(new Point(430, 70), new Point(460, 90)));
            gfx.FillPolygon(new SolidBrush(Color.Red), GetInverseTriangle(new Point(430, 70), new Point(460, 90)));

            gfx.FillPolygon(new SolidBrush(Color.Red), GetTriangle(new Point(360, 210), new Point(390, 230)));
            gfx.FillPolygon(new SolidBrush(Color.Red), GetInverseTriangle(new Point(360, 210), new Point(390, 230))); //stars


            // gfx.FillPolygon(new SolidBrush(Color.Green), GetBullet(new Point(200, 10), new Point(220, 10)));
            // gfx.FillPolygon(new SolidBrush(Color.Yellow), GetSpaceship(new PointF(100, 150)));

            /*Point[] points =
             {
                 new Point(250, 100),
                 new Point(220, 120),
                 new Point(280, 120),
                 new Point(220, 130),
                 new Point(280, 130),
                 //new Point(250, 150)

             };

            SolidBrush solidbrush = new SolidBrush(Color.Yellow);
            //gfx.FillPolygon(solidbrush, points);*/

            gfx.FillPolygon(new SolidBrush(Color.Yellow), GetTriangle(new Point(260, 100), new Point(340, 115)));
            SolidBrush sbrush = new SolidBrush(Color.Yellow);
            gfx.FillRectangle(sbrush, new Rectangle(260, 115, 80, 30));
            gfx.FillPolygon(new SolidBrush(Color.Yellow), GetInverseTriangleforSpaceship(new Point(260, 100), new Point(340, 115))); //hexagon


            gfx.FillPolygon(new SolidBrush(Color.Green), GetTriangle(new Point(285, 113), new Point(315, 129)));
            SolidBrush s2brush = new SolidBrush(Color.Green);
            gfx.FillRectangle(s2brush, new Rectangle(293, 129, 15, 18)); //strelka

            gfx.FillPolygon(new SolidBrush(Color.Green), GetTriangle(new Point(300, 60), new Point(310, 70)));
            SolidBrush s3brush = new SolidBrush(Color.Green);
            gfx.FillRectangle(s3brush, new Rectangle(300, 70, 10, 7));
            gfx.FillPolygon(new SolidBrush(Color.Green), GetInverseTriangleforBullet(new Point(300, 60), new Point(310, 70)));
            Point[] LeftTriangle =
            { new Point(300, 70), new Point(293, 73), new Point(300, 76) };
            gfx.FillPolygon(new SolidBrush(Color.Green), LeftTriangle);
            Point[] RightTriangle =
            { new Point(310, 70), new Point(317, 73), new Point(310, 76) };
            gfx.FillPolygon(new SolidBrush(Color.Green), RightTriangle); //bullet


            //gfx.FillPolygon(new SolidBrush(Color.Yellow), GetLeftTriangleforBullet(new Point(180, 40), new Point(190, 50)));

            using (Font font = new Font("Times New Roman", 10, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                Point point1 = new Point(380, 12);
                TextRenderer.DrawText(e.Graphics, "Level: 1 Score: 200 Live: ***", font, point1, Color.White);
            }

            string text1 = "Just an exmaple";
            using (Font font1 = new Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(380, 30, 90, 20);
                e.Graphics.DrawString(text1, font1, Brushes.White, rectF1);
                e.Graphics.DrawRectangle(Pens.White, Rectangle.Round(rectF1));
            }


        }

        private void DrawCircles()
        {
            int d = 16; //width and height of circles are same
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(40, 40, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(200, 30, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(330, 60, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(480, 100, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(55, 220, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(220, 200, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(430, 150, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(480, 240, d, d));
        }

        private Point[] GetTriangle(Point p1, Point p2)
        {
            Point[] points = {
                                new Point(p1.X, p2.Y),
                                new Point((p1.X + p2.X)/2, p1.Y),
                                p2
                              };
            return points;
        }

        private Point[] GetInverseTriangle(Point p2, Point p1)
        {
            int sm = 7;
            Point[] points = {
                                new Point(p2.X, p2.Y +sm),                             
                                new Point((p1.X + p2.X)/2, p1.Y + sm),
                                new Point(p1.X, p2.Y + sm), };
            return points;
        }

        private Point[] GetInverseTriangleforSpaceship(Point p2, Point p1)
        {
            int sm = 45;
            Point[] points = {
                                new Point(p2.X, p2.Y +sm),
                                new Point((p1.X + p2.X)/2, p1.Y + sm),
                                new Point(p1.X, p2.Y + sm), };
            return points;
        }

        private Point[] GetInverseTriangleforBullet(Point p2, Point p1)
        {
            int sm = 15;
            Point[] points = {
                                new Point(p2.X, p2.Y +sm),
                                new Point((p1.X + p2.X)/2, p1.Y + sm),
                                new Point(p1.X, p2.Y + sm), };
            return points;
        }


        


        private Point[] GetLeftTriangleforBullet(Point p1, Point p2)
        {
            Point[] points = {
                                new Point(p2.X, p1.Y),
                                new Point(p1.X, (p1.Y+ p2.Y)/2),
                                p2
                              };
            return points; //correct but we do not use it 
        }

        /*private Point[] GetBullet(Point p1, Point p2)
        {
            Point[] points = {                               
                                new Point((p1.X + p2.X)/2, p1.Y),
                                new Point((p1.Y + p2.Y)/2, p1.X),
                               new Point((p1.X + p2.X)/2, p2.Y),
                               new Point((p1.Y + p2.Y)/2, p2.X),
                              };
            return points;
        }*/

        /* private PointF[] GetSpaceship(PointF p) //многоугольник
         {
             int n = 6;
             PointF[] points = new PointF[n];
             float deg = 360 / n;
             for (int i = 0; i < n; i++)
             {
                 points[i] = new PointF(
                     p.X + 60 / 2 * (float)Math.Cos(i * deg * Math.PI / 180f),
                     p.Y + 60 / 2 * (float)Math.Sin(i * deg * Math.PI / 180f));
             }
             return points;
         }*/

    }
}
