using System;
using Shapes.Interface;

namespace Shapes.Models
{
    internal class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("radius", "The radius can not be negative!");
                }

                radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI*Math.Pow(radius, 2);
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2*Math.PI*Math.Pow(radius, 2);
            return perimeter;
        }
    }
}