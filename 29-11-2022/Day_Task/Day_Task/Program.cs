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

          

            var dateTime= new DateTime(1999,10,27);

            Manager m1 = new Manager("Momen", dateTime, 20);
            m1.Print();
            m1.Salary(500.45, 0.03);

        }
    }
}
