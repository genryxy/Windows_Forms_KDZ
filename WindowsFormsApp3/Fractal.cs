using System.Drawing;

namespace DrawingFractals
{
    abstract class Fractal
    {
        /// <summary>
        /// A current level of recursion
        /// </summary>
        public static int DepthInt { get; set; }
        /// <summary>
        /// The color which will be used on the first level of recursion
        /// </summary>
        public static Color StartColor { get; set; } = Color.Yellow;
        /// <summary>
        /// The color which will be used on the latest level of recursion
        /// </summary>
        public static Color EndColor { get; set; } = Color.Blue;
        /// <summary>
        /// Maximum recursion depth
        /// </summary>
        public virtual int MaxDepthInt { get; set; }
        /// <summary>
        /// Side length
        /// </summary>
        public abstract float SideF { get; set; }
        /// <summary>
        /// The method that will be overridden in the base classes
        /// </summary>
        /// <param name="graphics"></param>
        public abstract void Draw(Graphics graphics);
    }
}