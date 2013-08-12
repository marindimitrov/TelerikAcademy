//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class SurfaceOfATriangle
{
    static void Main()
    {
        SideAndAltitude();
        ThreeSides();
        TwoSidesAndAngle();
    }
    public static void SideAndAltitude()
    {
        Console.Write("Please enter size of triangle side: ");
        double triangleSide = double.Parse(Console.ReadLine());
        Console.Write("Please enter size of triangle altitude: ");
        double triangleAltitude = double.Parse(Console.ReadLine());

        double triangleSurface = (double)(triangleSide * triangleAltitude / 2);
        Console.WriteLine("The surface of triangle with side {0} and altitude {1} is {2}.",
                          triangleSide, triangleAltitude, triangleSurface);
    }
    public static void ThreeSides()
    {
        Console.Write("Enter size of side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter size of side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter size of side C: ");
        double sideC = double.Parse(Console.ReadLine());

        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double triangleSurface = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) *
                                 (halfPerimeter - sideB) * (halfPerimeter - sideC));
        Console.WriteLine("The surface of triangle with sides A = {0}, B = {1} and C = {2} is {3}",
                          sideA, sideB, sideC, triangleSurface);
    }
    public static void TwoSidesAndAngle()
    {
        Console.Write("Enter size of side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter size of side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter size of the angle between the sides in degrees: ");
        double angleInDegrees = double.Parse(Console.ReadLine());
        double angleInRadians = angleInDegrees * Math.PI / 180;

        double triangleSurface = (sideA * sideB * Math.Sin(angleInRadians)) / 2;
        Console.WriteLine("The surface of a triangle with sides A = {0}, B = {1} and angle {2} is {3}.",
                          sideA, sideB, angleInDegrees, triangleSurface);
    }
}