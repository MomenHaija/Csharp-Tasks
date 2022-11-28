using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string make = "BWM";
            int year = 2022;
            string type = "GAS";
            double price = 50451.24;
            string model = "3-series debuts";
            String palletno = "XMY-1260";
            string color = "White";

            CAR car=new CAR(make,year,type,price,model,palletno,color);
            Console.WriteLine(car.Print());

            BWM car1 = new BWM("KIA", 2006, "Banzen", 5045.25, "Sportage", "17-49913", "brown");
            car1.Print();

            Console.WriteLine("Please Enter The Numbers of Letter");
            double numberofletter = Convert.ToDouble(Console.ReadLine());
            car.NumberOfLetter=numberofletter;


            car.displayenough(numberofletter);

          Console.ReadKey();
        }

    }
}
