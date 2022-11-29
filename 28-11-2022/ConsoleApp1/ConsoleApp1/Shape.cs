using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    public class Shape
    {
        private double x;
        public double X { get; set; }
        private double y;
        public double Y { get; set; }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public String ToString() => $"Location:X:{x}  &  Y{y}";
        public double Area() => this.x * this.y;
        public string pararmeter() => $"X={x}and Y={y}";
        public void PrintArea(double Area)
        {
            Console.WriteLine("The Area of Shape is " + Area);
        }
    }

    public class Rectangle:Shape
    
    {
        private double side1;

        private double side2;
        private double area;
        public double Area { get; set; }
        public Rectangle(double length,double width):base(length,width)
        {
            side1= length;
            side2= width;
            Area=Area();
            PrintArea(Area);
        }
     
    } 

    public class Circle:Shape
    {
        private double radius;
        private double area;
        public double Area { get; set; }
        
        public Circle(double radius):base(radius, radius)
        {
            this.radius = radius;
            Area =Math.PI* Area();
            PrintArea(Area);
        }
    }
}
