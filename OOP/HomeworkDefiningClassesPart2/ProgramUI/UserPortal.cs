namespace ProgramUI
{
    using System;
    using System.Collections;
    using System.Linq;
    using UsableClasses;

    class UserPortal
    {
        static void Main()
        {
            //Point3D pointOne = new Point3D(2,3,3);
            //Point3D pointTwo = new Point3D(2,2,2);
            //double dist = Distance3D.CalculateDistance(pointOne, pointTwo);
            //Console.WriteLine(dist);
            
            //int[] arr = new int[3];

            var test = new { L = 3, M = 5 };
            test.L = 6;
            Console.WriteLine(test.L);
        }
    }
}
