﻿// 3. Implement the  IComparable<Student> interface to compare students by names 
// (as first criteria, in lexicographic order) and by social security number 
// (as second criteria, in increasing order).

using System;
using System.Linq;

namespace ClassStudent
{
    interface ICloneable
    {
        Student Clone();
    }
}