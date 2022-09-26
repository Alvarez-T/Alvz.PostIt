using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alvz.PostIt.Model
{
    public record WindowPosition(double X, double Y);
    public record class PostItWindowConfig
    {
        public Color Color { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
