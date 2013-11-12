namespace UsableClasses
{
    using System;
    using System.Linq;
    using System.Text;

    //Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
    //Implement the ToString() to enable printing a 3D point.

    public struct Point3D
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return this.x; }
        }
        public int Y
        {
            get { return this.y; }
        }
        public int Z
        {
            get { return this.z; }
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            StringBuilder coordinates = new StringBuilder();
            coordinates.Append("\nX: " + X);
            coordinates.Append("\nY: " + Y);
            coordinates.Append("\nZ: " + Z);
            return coordinates.ToString();
        }

        //Add a private static read-only field to hold the start of the coordinate system – 
        //the point O{0, 0, 0}. Add a static property to return the point O.

        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public static Point3D PointO
        {
            get { return pointO; }
        }
    }
}