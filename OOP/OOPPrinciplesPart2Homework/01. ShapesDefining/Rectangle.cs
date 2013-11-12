using System;
using System.Linq;

namespace ShapesDefining
{
    class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateSurface()
        {
            double rectangleSurface = Height * Width;
            return rectangleSurface;
        }
    }
}