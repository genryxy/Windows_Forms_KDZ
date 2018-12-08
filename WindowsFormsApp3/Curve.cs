using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Curve : Fractal
    {
        public const int maxDepthCurveDefault = 15;

        public int iter = 0;
        private int _maxDepthInt = 15;
        private float _x1 = 200, _y1 = 300, _x2 = 200, _y2 = 200;

        public override int MaxDepthInt { get { return _maxDepthInt; } set { _maxDepthInt = value; } }
        public override float SideF { get; set; }

        public override void Draw(Graphics g)
        {        
            DrawCurve(g, DepthInt, _x1, _y1, _x2, _y2);
        }
        internal void CalculateInitialCoordinates(int size)
        {
            CalculateInitialCoordinates(size, ref _x1, ref _y1, ref _x2, ref _y2);
        }
        internal void InitializeCurve()
        {
            iter = 0;
        }
        int depth2;
        private void DrawCurve(Graphics gr, int depth, float x1, float y1, float x2, float y2)
        {
            try
            {
                if (depth == 0)
                {
                    gr.DrawLine(new Pen(new SolidBrush(CountGradient.Gradient
                        (StartColor, EndColor, Form1.curDepth + 2/*DepthInt + 2*/, depth2))), x1, y1, x2, y2);
                }
                else
                {                    
                    float x3 = (x1 + x2) / 2 + (y2 - y1) / 2;
                    float y3 = (y1 + y2) / 2 - (x2 - x1) / 2;

                    DrawCurve(gr, depth - 1, x1, y1, x3, y3);
                    depth2 = depth - 1;
                    DrawCurve(gr, depth - 1, x3, y3, x2, y2);
                    depth2 = depth - 1;
                }
            }
            catch (StackOverflowException err)
            {
                MessageBox.Show($"Невозможно построить! {err.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateInitialCoordinates(int size, ref float x1, ref float y1, ref float x2, ref float y2)
        {
            iter = 0;
            x1 = 7 * size / 5 + 20 * Form1.scaleIm /* * Form1.scaleIm / 2*/;
            x2 = 7 * size / 5 + 20 * Form1.scaleIm;
            y2 = size;
            y1 = 2 * size/*(y1 - y2) * Form1.scaleIm*/;
        }       
    }
}