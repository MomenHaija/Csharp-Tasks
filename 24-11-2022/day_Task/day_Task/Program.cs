using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace day_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string gender, name, email, phone;
            double id;

            Console.WriteLine("Please Enter You'r name");
            name = Console.ReadLine();


            Console.WriteLine("Please Enter You'r Age");
            age=Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Please Enter You'r Gender ");
            gender =Console.ReadLine();


            Console.WriteLine("Please Enter You'r Id");
            id = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please Enter You'r Email");
            email = Console.ReadLine();


            Console.WriteLine("Please Enter You'r Phone");
            phone = Console.ReadLine();


          

            Person p1 = new Person(age, gender, name, email, id, phone);
            p1.print();

        }
    }
}
