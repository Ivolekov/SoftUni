using System;
using Shapes.Interface;

namespace Shapes.Models
{
    internal abstract class BasicShape : IShape
    {
        private double height;
        private double width;

        public BasicShape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get
            { return width; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("width", "The width cannot be a negative number!");
                }

                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("height", "The height cannot be a negative number!");
                }

                height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}