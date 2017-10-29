using System;
using Shapes.Interface;

namespace Shapes.Models
{
    internal class Triangle : BasicShape, IShape
    {
        public Triangle(double width, double height) :
            base(width, height)
        {
        }

        public override double CalculateArea()
        {
            double area = (Width*Height)/2;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
            double perimeter = Height + Width + hypotenuse;
            return perimeter;
        }
    }
}