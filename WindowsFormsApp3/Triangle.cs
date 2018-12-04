using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    class Triangle : Fractal
    {
        //private int scaleIm = 1;
        public int DepthInt { get; set; } 
        public override float SideF { get; set; }
        private float bx, cx;
        private float ay;
        private float bc_y;
        private const int correlation = 150;
        private PointF top_point, right_point, left_point;
        
        public void Draw(Graphics g)
        {
            DrawTriangle(g, DepthInt, top_point, left_point, right_point);
        }
        public void CalculateInitialCoordinates()
        {
            CalculateInitialCoordinates(ref bx, ref cx, ref ay, ref bc_y);
        }
        public void CalculatePoints()
        {
            CalculatePoints(ref top_point, ref right_point, ref left_point);
        }
        protected override void DrawTriangle(Graphics gr, int level, PointF top_point, PointF left_point, PointF right_point)
        {
            try
            {
                Color colorCol = CountGradient.Gradient(startColor, endColor, DepthInt + 2, level);
                Brush colorBrush = new SolidBrush(colorCol);
                if (level == 0)
                {
                    PointF[] points = { top_point, right_point, left_point };
                    gr.FillPolygon(new SolidBrush(startColor), points);
                }
                else
                {
                    // Найти граничные точки треугольника
                    PointF left_mid = new PointF((top_point.X + left_point.X) / 2f, (top_point.Y + left_point.Y) / 2f);
                    PointF right_mid = new PointF((top_point.X + right_point.X) / 2f, (top_point.Y + right_point.Y) / 2f);
                    PointF bottom_mid = new PointF((left_point.X + right_point.X) / 2f, (left_point.Y + right_point.Y) / 2f);

                    // Рекурсивно рисуем три меньших треугольника
                    DrawTriangle(gr, level - 1, right_mid, bottom_mid, right_point);
                    DrawTriangle(gr, level - 1, left_mid, left_point, bottom_mid);
                    DrawTriangle(gr, level - 1, top_point, left_mid, right_mid);
                    gr.FillPolygon(colorBrush, new PointF[] { left_mid, right_mid, bottom_mid });
                }
            }
            catch (StackOverflowException err)
            {
                MessageBox.Show($"Невозможно построить! {err.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void CalculateInitialCoordinates(ref float bx, ref float cx, ref float ay, ref float bc_y)
        {
            bx = 5;
            cx = bx + SideF;
            ay = 1;
            bc_y = ay + (float)Math.Sqrt(SideF * SideF - SideF * SideF / 4);
        }
        private void CalculatePoints(ref PointF top_point, ref PointF right_point, ref PointF left_point)
        {
            top_point = new PointF((cx + bx) / 2 * Form1.scaleIm, ay * Form1.scaleIm);
            right_point = new PointF(bx * Form1.scaleIm, bc_y * Form1.scaleIm);
            left_point = new PointF(cx * Form1.scaleIm, bc_y * Form1.scaleIm);
        }
    }
}
