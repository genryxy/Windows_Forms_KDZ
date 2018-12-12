using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingFractals
{
    class Square : Fractal
    {
        public const int maxDepthSqDefault = 10;
        private const float _side = 150;
        private const float _x = _side, _y = _side;

        private PointF _initialPoint;

        public override int MaxDepthInt { get; set; } = 10;
        public override float SideF { get; set; }

        public override void Draw(Graphics g)
        {
            DrawTSquare(g, _initialPoint, SideF, DepthInt);
        }
        public void DrawFirstTSquare(Graphics g)
        {
            DrawFirstTSquare(g, _initialPoint, SideF, DepthInt);
        }
        internal void ChangeSquareSize(int scaleIm)
        {
            SideF = _side * Form1.scaleIm;
            _initialPoint = new PointF(_x * Form1.scaleIm, _y * Form1.scaleIm);
        }       
        
        private int DrawTSquare(Graphics g, PointF initPoint, float sizeF, int depthInt)
        {
            try
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
            catch (StackOverflowException err)
            {
                MessageBox.Show($"Невозможно построить! {err.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public void DrawFirstTSquare(Graphics g, PointF initPoint, float sizeF, int depthInt)
        {
            g.FillRectangle(new SolidBrush(StartColor), initPoint.X - SideF / 2,
                initPoint.Y - SideF / 2, SideF * 2, SideF * 2);
        }
    }
}