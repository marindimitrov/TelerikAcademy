﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryAPI;

namespace GeometryAPI
{
    public class Vertex : Figure
    {
        public Vector3D Location
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        public Vertex(Vector3D location)
            : base(location)
        {
        }

        public override double GetPrimaryMeasure()
        {
            return 0;
        }
    }
}