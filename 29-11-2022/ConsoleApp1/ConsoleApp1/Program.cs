using MyNAmeSpace;
using SecondMyNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            RectangleArea r1=new RectangleArea();
            double infa= r1.Area(3.2, 2.25);
            Console.WriteLine(infa);

        }
    }

}
namespace MyNAmeSpace
{
    public class Animal
    {
        public virtual void Move() {

            Console.WriteLine("The Animal is Moving");
        }
       
    }
    public class Falcon:Animal
    {
        public  override  void Move()
        { 
            //base.Move();
            Console.WriteLine("The Falcon is Fly");
        }

    }
    public class AmericanFalcon :Falcon {

        public override void Move()
        {      
            Console.WriteLine("High Speed");
        }
    
    }
}
namespace SecondMyNameSpace
{ 
    interface Shape
    {
        void print(); //empty Body
    }
    interface Rectangle
    {
        double Area(double x,double y);
    }
    class RectangleArea : Rectangle,Shape
    {
        public double Area(double x, double y) { 
            return x * y; 
        }
        public void print()
        {
            Console.WriteLine("Shape Rectangle");
        }
    }
}
