using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter You'r Name");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            double firstNum = 5.524;
            string Myname = "Momen";
            char firstlatter = 'A';
            int secondNum = 2;
            const int thiredNum = 3;

            string[] car = { "BWM", "HONDA", "KIA" };



            Console.WriteLine("Please Enter You'r first Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter You'r  SureName");
            string sureName = Console.ReadLine();

            Console.WriteLine("Please Enter year your birth");
            string birth = Console.ReadLine();


            Console.WriteLine(firstName + sureName + birth);


            int[] myarray = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Console.WriteLine("elemnt - " + 0 + ":" + myarray[0]);
            Console.WriteLine("elemnt - " + 1 + ":" + myarray[1]);
            Console.WriteLine("elemnt - " + 2 + ":" + myarray[2]);
            Console.WriteLine("elemnt - " + 3 + ":" + myarray[3]);
            Console.WriteLine("elemnt - " + 4 + ":" + myarray[4]);
            Console.WriteLine("elemnt - " + 5 + ":" + myarray[5]);
            Console.WriteLine("elemnt - " + 6 + ":" + myarray[6]);
            Console.WriteLine("elemnt - " + 7 + ":" + myarray[7]);
            Console.WriteLine("elemnt - " + 8 + ":" + myarray[8]);
            Console.WriteLine("elemnt - " + 9 + ":" + myarray[9]);





            int[] secondArray ={2, 5, 8};
            int sum = 0;
            Console.Write("Sum:");
            sum = secondArray[0] + secondArray[1] + secondArray[2];
            Console.Write(sum);
            Console.WriteLine();

        }
    }
}
