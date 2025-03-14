using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance_oops
{


    interface Shape
    {
        double GetArea();
    }


    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }


    class Rectangle : Shape
    {
        private double length, width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }
    }

    class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double GetArea()
        {
            return side * side;
        }
    }


    class Program
    {
        static void Main()
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Shape square = new Square(3);

            Console.WriteLine("Area of Circle: " + circle.GetArea());
            Console.WriteLine("Area of Rectangle: " + rectangle.GetArea());
            Console.WriteLine("Area of Square: " + square.GetArea());
        }
    }

}
