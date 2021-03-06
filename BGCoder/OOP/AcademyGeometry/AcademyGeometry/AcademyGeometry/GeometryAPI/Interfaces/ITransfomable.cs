﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryAPI;

namespace GeometryAPI
{
    public interface ITransformable
    {
        void Translate(Vector3D translationVector);
        void Scale(Vector3D scaleCenter, double scaleFactor);
        void RotateInXY(Vector3D rotCenter, double angleDegrees);
    }
}