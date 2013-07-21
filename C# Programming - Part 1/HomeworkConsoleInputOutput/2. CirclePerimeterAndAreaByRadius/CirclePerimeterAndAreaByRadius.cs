//Write a program that reads the radius r of a circle 
//and prints its perimeter and area.

using System;

class CirclePerimeterAndAreaByRadius
{
    static void Main()
    {
        Console.Write("Please enter circle's radius: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The circle's perimeter with radius {0:0.00} is: {1:0.00}", radius, perimeter);
        Console.WriteLine("The circle's area with radius {0:0.00} is: {1:0.00}", radius, area);
    }
}