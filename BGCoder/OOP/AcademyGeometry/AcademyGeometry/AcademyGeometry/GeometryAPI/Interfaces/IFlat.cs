﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryAPI;

namespace GeometryAPI
{
    public interface IFlat
    {
        Vector3D GetNormal();
    }
}