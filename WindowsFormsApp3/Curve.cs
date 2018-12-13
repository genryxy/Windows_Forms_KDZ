using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingFractals
{
    class Curve : Fractal
    {
        public const int maxDepthCurveDefault = 13;

        private float _x1 = 200, _y1 = 300, _x2 = 200, _y2 = 200;

        /// <summary>
        /// Maximum recursion depth
        /// </summary>
        public override int MaxDepthInt { get; set; } = maxDepthCurveDefault;
        /// <summary>
        /// Curve side length
        /// </summary>
        public override float SideF { get; set; }
        /// <summary>
        /// The number of the returned color from the gradient
        /// </summary>
        public int NumbColor { get; set; } = 0;
        /// <summary>
        /// Overload of the method DrawCurve(6 parameters)
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {        
            DrawCurve(g, DepthInt, _x1, _y1, _x2, _y2);
        }
        /// <summary>
        /// Overload of the method CalculateInitialCoordinates(5 parameters)
        /// </summary>
        /// <param name="size"></param>
        internal void CalculateInitialCoordinates(int size)
        {
            CalculateInitialCoordinates(size, ref _x1, ref _y1, ref _x2, ref _y2);
        }
        /// <summary>
        /// Drawing the fractal Levy C curve
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="depth">level of recursion</param>
        /// <param name="x1">the upper coordinate of the segment (abscissa)</param>
        /// <param name="y1">the upper coordinate of the segment (ordinate)</param>
        /// <param name="x2">the lower coordinate of the segment(abscissa)</param>
        /// <param name="y2">the lower coordinate of the segment(ordinate)</param>
        private void DrawCurve(Graphics gr, int depth, float x1, float y1, float x2, float y2)
        {
            float x3, y3;
            try
            {
                if (depth == 0)
                {
                    if (Form1.flag)
                        gr.DrawLine(new Pen(new SolidBrush(SCountGradient.FormGradient
                        (StartColor, EndColor, (int)Math.Pow(2, Form1.curDepth), NumbColor)), 2), x1, y1, x2, y2);
                    else
                    {
                        gr.DrawLine(new Pen(new SolidBrush(SCountGradient.FormGradient
                            (StartColor, EndColor, Form1.curDepth + 1, depth)), 2), x1, y1, x2, y2);
                        if (Form1.curDepth == 0)
                            gr.DrawLine(new Pen(StartColor, 2), x1, y1, x2, y2);
                    }
                    NumbColor++;
                }
                else
                {                    
                     x3 = (x1 + x2) / 2 + (y2 - y1) / 2;
                     y3 = (y1 + y2) / 2 - (x2 - x1) / 2;
                    if (!Form1.flag)                                       
                        gr.DrawLine(new Pen(new SolidBrush(SCountGradient.FormGradient
                        (StartColor, EndColor, Form1.curDepth * 10 + 1, depth * 10)), 2), x1, y1, x2, y2);
                    DrawCurve(gr, depth - 1, x1, y1, x3, y3);                   
                    DrawCurve(gr, depth - 1, x3, y3, x2, y2);                    

                }
            }
            catch (StackOverflowException err)
            {
                MessageBox.Show($"Невозможно построить! {err.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Calculate coordinates of the segment of the curve
        /// </summary>
        /// <param name="size">Length of the segment</param>
        /// <param name="x1">the upper coordinate of the segment (abscissa)</param>
        /// <param name="y1">the upper coordinate of the segment (ordinate)</param>
        /// <param name="x2">the lower coordinate of the segment(abscissa)</param>
        /// <param name="y2">the lower coordinate of the segment(ordinate)</param>
        private void CalculateInitialCoordinates(int size, ref float x1, ref float y1, ref float x2, ref float y2)
        {
            x1 = size + 128 * Form1.scaleIm;
            x2 = size + 128 * Form1.scaleIm;
            y2 = size;
            y1 = 2 * size;
        }       
    }
}