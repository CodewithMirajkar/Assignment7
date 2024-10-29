//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//using static Assignment7.Circle;

//namespace Assignment7
//{
 
//    abstract class Shape
//    {
        
//        public abstract double CalculateArea();
//    }

//    interface IColorable
//    {
        
//        string GetColor();
//    }

//    class Rectangle : Shape, IColorable
//    {
//        public double Width { get; }
//        public double Height { get; }

//        public Rectangle(double width, double height)
//        {
//            Width = width;
//            Height = height;
//        }

        
//        public override double CalculateArea()
//        {
//            return Width * Height;
//        }

        
//        public string GetColor()
//        {
//            return "Red"; 
//        }
//    }

//    class Circle : Shape, IColorable
//    {
//        public double Radius { get; }

//        public Circle(double radius)
//        {
//            Radius = radius;
//        }

        
//        public override double CalculateArea()
//        {
//            return Math.PI * Radius * Radius;
//        }

        
//        public string GetColor()
//        {
//            return "Blue"; 
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Shape rectangle = new Rectangle(5, 10);
//            Shape circle = new Circle(7);

//            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
//            Console.WriteLine($"Rectangle Color: {(rectangle as IColorable)?.GetColor()}");

//            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
//            Console.WriteLine($"Circle Color: {(circle as IColorable)?.GetColor()}");
//            Console.ReadLine();
//        }
//    }
//}