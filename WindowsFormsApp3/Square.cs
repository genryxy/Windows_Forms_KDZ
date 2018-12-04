using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Square : Fractal
    {
        public const int maxDepthSqDefault = 10;
        private const float side = 128;
        private const float x = 64, y = 64;

        private int maxDepthInt = 10;
        private PointF initialPoint, initialPointNew;

        public override int DepthInt { get; set; }
        public override int MaxDepthInt { get { return maxDepthInt; } set { maxDepthInt = value; } }
        public override float SideF { get; set; }
        public float SideFNew { get; set; }

        public override void Draw(Graphics g)
        {
            DrawTSquare(g, initialPointNew, SideFNew, DepthInt);
        }
        public void DrawFirstTSquare(Graphics g)
        {
            DrawFirstTSquare(g, initialPointNew, SideFNew, DepthInt);
        }

        internal void InitializeTSquare()
        {
            SideF = side;
            SideFNew = SideF;
            initialPoint = new PointF(x, y);
            initialPointNew = new PointF(x * Form1.scaleIm, y * Form1.scaleIm);
            StartColor = Color.Yellow;
            EndColor = Color.Blue;
        }
        internal void ChangeSquareSize(int scaleIm)
        {
            SideFNew = SideF * Form1.scaleIm / 2;
            initialPointNew = new PointF(initialPoint.X * Form1.scaleIm, initialPoint.Y * Form1.scaleIm);
        }       
        
        private int DrawTSquare(Graphics g, PointF initPoint, float sizeF, int depthInt)
        {
            Color colorCol = CountGradient.Gradient(StartColor, EndColor, DepthInt + 1, depthInt);
            Brush colorBrush = new SolidBrush(colorCol);
            if (depthInt == 0)
            { return 0; }
            if (depthInt == 1)
            {
                g.FillRectangle(new SolidBrush(EndColor), initPoint.X, initPoint.Y, sizeF, sizeF);
                return 0;     
            }

            float smallSide = sizeF / 4;
            PointF[] points = new PointF[4];  // coordinates of left up angles of new 4 squares
            for (int i = 0; i < 4; i++)
                points[i] = new PointF();
            // left up
            points[0].X = initPoint.X - smallSide;
            points[0].Y = initPoint.Y - smallSide;
            // left down
            points[1].X = initPoint.X - smallSide;
            points[1].Y = initPoint.Y + sizeF - smallSide;
            // right up
            points[2].X = initPoint.X + sizeF - smallSide;
            points[2].Y = initPoint.Y - smallSide;
            // right down
            points[3].X = initPoint.X + sizeF - smallSide;
            points[3].Y = initPoint.Y + sizeF - smallSide;

            for (int i = 0; i < 4; i++)
            {
                DrawTSquare(g, points[i], sizeF / 2, depthInt - 1);
                g.FillRectangle(colorBrush, initPoint.X, initPoint.Y, sizeF, sizeF);
            }      
            return 0;
        }
        public void DrawFirstTSquare(Graphics g, PointF initPoint, float sizeF, int depthInt)
        {
            g.FillRectangle(new SolidBrush(StartColor), initPoint.X - SideFNew / 2,
                initPoint.Y - SideFNew / 2, SideFNew * 2, SideFNew * 2);
        }
    }
}
