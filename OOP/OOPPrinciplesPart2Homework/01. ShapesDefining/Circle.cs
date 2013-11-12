using System;
using System.Linq;

namespace ShapesDefining
{
    class Circle : Shape
    {
        public Circle()
        {

        }

        public Circle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
            if (Height != Width)
            {
                throw new ArgumentException("Circle's width and height should be equal"); 
            }
        }

        public override double CalculateSurface()
        {
            double circleSurface = (Height / 2) * Math.Pow(Math.PI, 2);
            return circleSurface;
        }
    }
}