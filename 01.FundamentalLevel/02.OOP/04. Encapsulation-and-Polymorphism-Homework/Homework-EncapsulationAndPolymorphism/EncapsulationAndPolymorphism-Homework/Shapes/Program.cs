using System;
using System.Collections.Generic;
using Shapes.Interface;
using Shapes.Models;

namespace Shapes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Triangle(6, 8),
                new Triangle(2, 5.8),
                new Rectangle(5, 8),
                new Rectangle(4.7, 7),
                new Circle(2.5),
                new Circle(5.6)
            };

            foreach (var shape in shapes)
            {
                double area = shape.CalculateArea();
                double perimeter = shape.CalculatePerimeter();
                Console.WriteLine("{0} Perimeter is:{1:F2} | Area is: {2:F2}\n", shape.GetType().Name, perimeter, area);
            }
        }
    }
}