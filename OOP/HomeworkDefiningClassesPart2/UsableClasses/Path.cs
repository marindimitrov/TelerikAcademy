namespace UsableClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //Create a class Path to hold a sequence of points in the 3D space.

    class Path
    {
        public static List<Point3D> pointsSequence = new List<Point3D>();

        public static void AddPointToSequence(Point3D newPoint)
        {
            pointsSequence.Add(newPoint);
        }
    }
}