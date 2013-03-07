using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBox
{
    public class Box
    {
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Length, Width, Height);
        }
    }
}
