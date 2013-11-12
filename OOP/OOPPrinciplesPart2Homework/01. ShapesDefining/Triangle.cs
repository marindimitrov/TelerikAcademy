using System;
using System.Linq;

namespace ShapesDefining
{
    class Triangle : Shape
    {
        public Triangle()
        {

        }

        public Triangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateSurface()
        {
            double triangleSurface = Height * Width / 2;
            return triangleSurface;
        }
    }
}