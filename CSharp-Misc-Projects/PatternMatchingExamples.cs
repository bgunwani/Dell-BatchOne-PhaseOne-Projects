/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Misc_Projects
{
    class Shape
    {
        public const float PI = 3.14F;
    }

    class Circle: Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    class Rectangle: Shape
    {
        public double Length { get; }
        public double Height { get; }
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }

    class Triangle: Shape
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }


    class PatternMatchingExamples
    {
        public static void Calculate(Shape shape)
        {
            switch (shape)
            {
                case Circle circle:
                    Console.WriteLine("Area of Circle : " + (circle.Radius * circle.Radius * Shape.PI));
                    break;
                case Rectangle rectangle:
                    Console.WriteLine("Area of Rectangle : " + (rectangle.Length * rectangle.Height));
                    break;
                case Triangle triangle:
                    Console.WriteLine("Area of Triangle : " + (0.5 * triangle.Base * triangle.Height));
                    break;
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }

        }

        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Calculate(circle);
            Rectangle rectangle = new Rectangle(10, 5);
            Calculate(rectangle);
            Triangle triangle = new Triangle(10, 5);
            Calculate(triangle);
            Console.ReadKey();
        }
    }
}
*/