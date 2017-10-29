using System;

namespace DistanceCalculator
{
    using Point3D;
    public static class DistanceCalculator
    {
        
        public static void CalculateTheDistance(double x, double y, double z)
        {
            Point3D points = new Point3D(x, y, z);
            double deltaX = points.X - Point3D.StartingPoints[0];
            double deltaY = points.Y - Point3D.StartingPoints[1];
            double deltaZ = points.Z - Point3D.StartingPoints[2];
            //float distance = (float) Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            Console.WriteLine("Distance betwen 2 points in 3D Space is: {0}", result);
        }
    }
}
