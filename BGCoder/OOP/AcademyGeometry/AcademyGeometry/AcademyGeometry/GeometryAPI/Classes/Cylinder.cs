using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryAPI;

namespace GeometryAPI
{
    public class Cylinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        private double cylinderRadius;
        private double cylinderHeight;

        public double CylinderRadius
        {
            get { return this.cylinderRadius; }
        }

        public Vector3D cylinderBottomCircleCenter
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        public Vector3D cylinderTopCircleCenter
        {
            get { return this.vertices[1]; }
            set { this.vertices[1] = value; }
        }

        public Cylinder(Vector3D cylinderBottomCircleCenter, Vector3D cylinderTopCircleCenter, double cylinderRadius)
            : base(cylinderBottomCircleCenter, cylinderTopCircleCenter)
        {
            this.cylinderRadius = cylinderRadius;
            this.cylinderHeight = new LineSegment(cylinderBottomCircleCenter, cylinderTopCircleCenter).GetLength();
        }

        public override double GetPrimaryMeasure()
        {
            return GetVolume();
        }

        public double GetArea()
        {
            return 2 * Math.PI * this.cylinderRadius * this.cylinderRadius +
                   2 * Math.PI * this.cylinderRadius * cylinderHeight;
        }

        public double GetVolume()
        {
            return Math.PI * this.cylinderRadius * this.cylinderRadius * cylinderHeight;
        }
    }
}