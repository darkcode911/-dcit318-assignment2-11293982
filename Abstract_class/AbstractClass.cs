using System;

namespace AbstractClass
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle:Shape
    {
        private double radius;

        //constructor to set radius 

        public Circle(double r)
        {
            radius= r;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle:Shape
    {
        private double width;
        private double height;


        public Rectangle(double w , double h)
        {
            width = w;
            height = h;
        }

        public override double GetArea()
        {
            return width * height;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(5);

            Shape myRectangle = new Rectangle(10,19);


            Console.WriteLine($"Area of the Circle:{myCircle.GetArea()}");
            Console.WriteLine($"Area of the Rectangle:{myRectangle.GetArea()}");
        }
    }
}