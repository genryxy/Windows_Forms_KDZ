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

        /// <summary>
        /// Maximum recursion depth
        /// </summary>
        public override int MaxDepthInt { get; set; } = maxDepthTrDefault;
        /// <summary>
        /// Triangle side length
        /// </summary>
        public override float SideF { get; set; } = 180F;

        /// <summary>
        /// Overload of the method DrawTriangle(5 parameters)
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            DrawTriangle(g, DepthInt, _top_point, _left_point, _right_point);
        }

        /// <summary>
        /// Overload of the method CalculateCoordinates(4 parameters)
        /// </summary>
        internal void CalculateCoordinates()
        {
            CalculateCoordinates(ref _bx, ref _cx, ref _ay, ref _bc_y);
        }

        /// <summary>
        /// Overload of the method CalculatePoints(3 parameters)
        /// </summary>
        internal void CalculatePoints()
        {
            CalculatePoints(ref _top_point, ref _right_point, ref _left_point);
        }

        /// <summary>
        /// Drawing the fractal Triangle-Sierpinski
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="depth">level of recursion</param>
        /// <param name="top_point">coordinates of top point</param>
        /// <param name="left_point">coordinates of left point</param>
        /// <param name="right_point">coordinates of right point</param>
        private void DrawTriangle(Graphics gr, int depth, PointF top_point, PointF left_point, PointF right_point)
        {
            Color colorCol = SCountGradient.FormGradient(StartColor, EndColor, DepthInt + 2, depth);
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
        /// <summary>
        /// Calculate coordinates of the vertices of the triangle
        /// </summary>
        /// <param name="bx">the left vertex (abscissa)</param>
        /// <param name="cx">the right vertex (abscissa)</param>
        /// <param name="ay">the top vertex (ordinate)</param>
        /// <param name="bc_y">the left and right verices (ordinates)</param>
        private void CalculateCoordinates(ref float bx, ref float cx, ref float ay, ref float bc_y)
        {
            bx = 5;
            cx = bx + SideF;
            ay = 1;
            bc_y = ay + (float)Math.Sqrt(SideF * SideF - SideF * SideF / 4);
        }
        /// <summary>
        /// Form the points that are the vertices of the triangle
        /// </summary>
        /// <param name="top_point">the top vertex</param>
        /// <param name="right_point">the right vertex</param>
        /// <param name="left_point">the left vertex</param>
        private void CalculatePoints(ref PointF top_point, ref PointF right_point, ref PointF left_point)
        {
            float coeff = 2 * Form1.scaleIm;
            top_point = new PointF((_cx + _bx) / 2 * coeff, _ay * coeff);
            right_point = new PointF(_bx * coeff, _bc_y * coeff);
            left_point = new PointF(_cx * coeff, _bc_y * coeff);
        }
    }
}