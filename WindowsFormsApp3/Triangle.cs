using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingFractals
{
    class Triangle : Fractal
    {
        public const int maxDepthTrDefault = 12;

        private float _bx, _cx;
        private float _ay;
        private float _bc_y;
        private PointF _top_point, _right_point, _left_point;

        public override int MaxDepthInt { get; set; } = 12;
        public override float SideF { get; set; } = 180F;

        public override void Draw(Graphics g)
        {
            DrawTriangle(g, DepthInt, _top_point, _left_point, _right_point);
        }

        internal void CalculateCoordinates()
        {
            CalculateCoordinates(ref _bx, ref _cx, ref _ay, ref _bc_y);
        }

        internal void CalculatePoints()
        {
            CalculatePoints(ref _top_point, ref _right_point, ref _left_point);
        }
        
        private void DrawTriangle(Graphics gr, int depth, PointF top_point, PointF left_point, PointF right_point)
        {
            Color colorCol = CountGradient.Gradient(StartColor, EndColor, DepthInt + 2, depth);
            Brush colorBrush = new SolidBrush(colorCol);
            try
            {               
                if (depth == 0)
                {
                    PointF[] points = { top_point, right_point, left_point };
                    gr.FillPolygon(new SolidBrush(StartColor), points);
                }
                else
                {
                    // Find the boundary points of the triangle
                    PointF left_mid = new PointF((top_point.X + left_point.X) / 2f, (top_point.Y + left_point.Y) / 2f);
                    PointF right_mid = new PointF((top_point.X + right_point.X) / 2f, (top_point.Y + right_point.Y) / 2f);
                    PointF bottom_mid = new PointF((left_point.X + right_point.X) / 2f, (left_point.Y + right_point.Y) / 2f);
                    
                    // Recursively draw three smaller triangles
                    DrawTriangle(gr, depth - 1, right_mid, bottom_mid, right_point);
                    DrawTriangle(gr, depth - 1, left_mid, left_point, bottom_mid);
                    DrawTriangle(gr, depth - 1, top_point, left_mid, right_mid);
                    gr.FillPolygon(colorBrush, new PointF[] { left_mid, right_mid, bottom_mid });
                }
            }
            catch (StackOverflowException err)
            {
                MessageBox.Show($"Невозможно построить! {err.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateCoordinates(ref float bx, ref float cx, ref float ay, ref float bc_y)
        {
            bx = 5;
            cx = bx + SideF;
            ay = 1;
            bc_y = ay + (float)Math.Sqrt(SideF * SideF - SideF * SideF / 4);
        }

        private void CalculatePoints(ref PointF top_point, ref PointF right_point, ref PointF left_point)
        {
            float coeff = 2 * Form1.scaleIm;
            top_point = new PointF((_cx + _bx) / 2 * coeff, _ay * coeff);
            right_point = new PointF(_bx * coeff, _bc_y * coeff);
            left_point = new PointF(_cx * coeff, _bc_y * coeff);
        }
    }
}