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
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine("elemnt - " + i + ":" + myarray[i]);
            }



            int[] secondArray ={2, 5, 8};
            int sum = 0;
            Console.Write("Sum:")
            for(int i = 0; i < secondArray.Length; i++)
            {
                sum+= secondArray[i];
            }
            Console.WriteLine(sum);


        }
    }
}
