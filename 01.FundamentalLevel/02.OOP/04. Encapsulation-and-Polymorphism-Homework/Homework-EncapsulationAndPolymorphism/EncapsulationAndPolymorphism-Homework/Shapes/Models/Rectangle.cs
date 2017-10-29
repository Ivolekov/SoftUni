using Shapes.Interface;

namespace Shapes.Models
{
    internal class Rectangle : BasicShape, IShape
    {
        public Rectangle(double width, double height) :
            base(width, height)
        {
        }

        public override double CalculateArea()
        {
            double area = Height*Width;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2*(Height + Width);
            return perimeter;
        }
    }
}