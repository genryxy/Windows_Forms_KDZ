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
        internal float sideF;
        public virtual void Draw() { }
    }
}
