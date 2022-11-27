using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public static double tax = 0.03;

        public string FName;
        public string LName;
        public double wage;
        public double loggeHours;


        private double calculate() => wage * loggeHours;
        private double calculateTax() => calculate() * tax;
        private double calculateNet() => calculate() - calculateTax();

        public string printslip()
        {
            return $"\n First Name is {FName} " +
                $"\n and The Scond Name is {LName}" +
                $"\n Wage is {wage}" +
                $"\n Salary is {calculate()}" +
                $"\n and The Tax is {calculateTax()}" +
                $"\n Net Salary is  is {calculateNet()}";
        }

    }
}