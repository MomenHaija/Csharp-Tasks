using Day_Task;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day_Task
{
    public class CAR
    {
        protected string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        protected int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        protected string type;
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }
        protected double price;
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        protected string model;
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
            }
        }
        protected String PalletNo;
        public String palletNo
        {
            get { return palletNo; }
            set
            {
                palletNo = value;
            }
        }
        protected string color;
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }

        public double LetterPerKillo { get; set; } = 8.5;
        

        public double NumberOfLetter { get;  set;  }


        public void  displayenough(double numberleteer)
        {
            Console.Write("The letter will enough you for:\t");
            Console.WriteLine(NumberOfLetter * LetterPerKillo + " KM");
        }

        public CAR(string make,int year,string type,double price,string model,String pallteno,string color)
        {
            this.make = make;
            this.year = year;   
            this.type = type;   
            this.price = price;
            this.model = model;
            this.color = color;
            this.PalletNo= pallteno; 
        }
        public void EngineOn() {

            Console.WriteLine("The Engine Is ON");
        }
        public void EngineOff() {
            Console.WriteLine("The Engine IS OFF");
        }
        public String Print()
        {
            return $"Car Name\t{make}\n" +
                $"car Model:\t{model}\n" +
                $"Car Year:\t{year}\n" +
                $"Car Type:\t{type}\n" +
                $"Car Price:\t{price}\n" +
                $"Car Color:\t{color} \n" +
                $"Car Pallet NUmber:\t{PalletNo}\n";
        } 
    }
    public class BWM : CAR
    {
        public BWM(string make, int year, string type, double price, string model, String pallteno, string color) : base(make, year, type, price, model, pallteno, color)
        {}
            public void Print()
            {
                Console.WriteLine( $"Car Name:\t{make}\n" +
                $"car Model:\t{model}\n" +
                $"Car Year:\t{year}\n" +
                $"Car Type:\t{type}\n" +
                $"Car Price:\t{price}\n" +
                $"Car Color:\t{color}\n" +
                $"Car Pallet Number:\t{PalletNo}\n");

            }
    }
}
