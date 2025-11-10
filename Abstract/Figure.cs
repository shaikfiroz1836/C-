using System;

namespace Abstract
{
    public abstract class Figure
    {
        public double height, width, radius;
        public const float pi = 3.14f;
        public abstract double GetArea();
    }
    class Rectangle : Figure
    {
        public Rectangle(double height,double width)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return width*height;
        }
    }
    class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * radius * radius;
        }
    }
    class Triangle : Figure
    {
        public Triangle(double height, double width)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return 0.5*(height*width);
        }
    }
    class Cone : Figure
    {
        public Cone(double height, double radius)
        {
            this.radius = radius;
            this.height = height;
        }
        public override double GetArea()
        {
            return pi * radius * (radius + Math.Sqrt(height * height + radius * radius));
        }
    }
    class TestFigure
    {
        static void Main()
        {
            Rectangle r = new Rectangle(5.0, 4.0);
            Circle c = new Circle(5);
            Triangle t = new Triangle(4.0, 6.0);
            Cone co = new Cone(7.0, 3.0);

            Console.WriteLine("Area of Rectangle: " + r.GetArea());
            Console.WriteLine("Area of Circle: " + c.GetArea());
            Console.WriteLine("Area of Triangle: " + t.GetArea());
            Console.WriteLine("Area of Cone: " + co.GetArea());
        }
    }
}