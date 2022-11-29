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
            Circle c1 = new Circle(3.457);
            Rectangle r1 = new Rectangle(2.12,3.45);

            Invoice inv1 = new Invoice(2520,"Momen",200);
            inv1.Print();

            Player p1 = new Player(5,3,7,2);
            Console.WriteLine(p1.ToString());   
            p1.Jump();

            Console.WriteLine(p1.Near());

            string name = "Momen", address = "Irbid", school = "industrial Irbid High School";
            double pay = 550.25;
            Staff s1 = new Staff(name,address,school,pay);
            Console.WriteLine(s1.ToString());

        }
    }
}
