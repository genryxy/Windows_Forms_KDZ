using System.Collections.Generic;
using System.Drawing;

namespace DrawingFractals
{
    static class SCountGradient
    {
        /// <summary>
        /// Creating a gradient
        /// </summary>
        /// <param name="startColor">the color of the first iteration</param>
        /// <param name="endColor">the color of the last iteration</param>
        /// <param name="size">the number of colors in the gradient</param>
        /// <param name="colorNumber"> the number of the returned color from the gradient</param>
        /// <returns></returns>
        static public Color FormGradient(Color startColor, Color endColor, int size, int colorNumber)
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
            return colorList[colorNumber];
        }
    }
}