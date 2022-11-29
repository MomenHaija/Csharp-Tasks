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
            Manager m1 = new Manager("Momen",1999,23);
            m1.Print();
            m1.Salary(500.45, 0.03);
        }
    }
}
