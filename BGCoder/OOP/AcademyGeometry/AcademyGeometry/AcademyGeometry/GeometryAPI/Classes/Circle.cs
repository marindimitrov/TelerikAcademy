using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryAPI;

namespace GeometryAPI
{
    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        private double circleRadius;

        public double CircleRadius
        {
            get { return this.circleRadius; }
        }

        public Vector3D circleCenter
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        public Circle(Vector3D circleCenter, double circleRadius)
            : base(circleCenter)
        {
            this.circleRadius = circleRadius;
        }

        public override double GetPrimaryMeasure()
        {
            return GetArea();
        }

        public double GetArea()
        {
            return Math.PI * circleRadius * circleRadius;
        }

        public Vector3D GetNormal()
        {
            Vector3D normal = circleCenter;
            normal.Normalize();
            return normal;
        }
    }
}