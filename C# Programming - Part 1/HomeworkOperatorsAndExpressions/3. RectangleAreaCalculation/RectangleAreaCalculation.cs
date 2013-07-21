//Write an expression that calculates rectangle’s area 
//by given width and height.

using System;

class RectangleAreaCalculation
{
    static void Main()
    {
        Console.WriteLine("This program will calculate rectangle's area by given height and width.");
        Console.Write("Enter the rectangle's height: ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Enter the rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("The rectangle's area is: {0}", height * width);
    }
}
