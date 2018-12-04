using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp3
{
    static class CountGradient
    {
        static public Color Gradient(Color startColor, Color endColor, int size, int numberColor)
        {
            int rMax = startColor.R;
            int rMin = endColor.R;
            int gMax = startColor.G;
            int gMin = endColor.G;
            int bMax = startColor.B;
            int bMin = endColor.B;

            var colorList = new List<Color>();
            for (int i = 0; i < size; i++)
            {
                var rAverage = rMin + (rMax - rMin) * i / size;
                var gAverage = gMin + (gMax - gMin) * i / size;
                var bAverage = bMin + (bMax - bMin) * i / size;
                colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }
            return colorList[numberColor];
        }
    }
}
