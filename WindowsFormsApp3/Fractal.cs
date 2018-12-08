using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    abstract class Fractal
    {
        /// <summary>
        /// a current level of recursion
        /// </summary>
        public static int DepthInt { get; set; }
        /// <summary>
        /// the color which will be used on the first level of recursion
        /// </summary>
        public static Color StartColor { get; set; } = Color.Yellow;
        /// <summary>
        /// the color which will be used on the latest level of recursion
        /// </summary>
        public static Color EndColor { get; set; } = Color.Blue;
        /// <summary>
        /// the length of a side
        /// </summary>
        public abstract float SideF { get; set; }
        /// <summary>
        /// max depth of recursion
        /// </summary>
        public virtual int MaxDepthInt { get; set; }        
        public abstract void Draw(Graphics graphics);
    }
}