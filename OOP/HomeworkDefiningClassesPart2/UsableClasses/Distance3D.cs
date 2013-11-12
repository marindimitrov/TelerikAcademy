namespace UsableClasses
{
    using System;
    using System.Linq;

    //Write a static class with a static method to calculate the 
    //distance between two points in the 3D space.

    public static class Distance3D
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + 
                                        Math.Pow(firstPoint.Y - secondPoint.Y, 2) + 
                                        Math.Pow(firstPoint.Z - secondPoint.Z, 2));
            return distance;
        }
    }
}