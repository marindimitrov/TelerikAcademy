﻿using System;
using System.Linq;

namespace ShapesDefining
{
    abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape()
        {

        }

        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public abstract double CalculateSurface();
    }
}