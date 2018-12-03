using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp3
{
    abstract class Fractal
    {
        public Color startColor, endColor;
        abstract public float SideF { get; set; }

        protected abstract void DrawTriangle(Graphics gr, int level, PointF top_point, PointF left_point, PointF right_point);
    }
}
