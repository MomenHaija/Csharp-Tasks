using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        int j=0;
        static void Main(string[] args)
        {

            Console.WriteLine("Foreach Loop on Arrays ");
            int j= 0;
            string[] Names = {"Momen","odai","Qaiz", "Asharaf", "Hassan"};
            foreach (string i in Names)
            {
                if (Names[j] == "Asharaf") { break; }
                Console.WriteLine(Names[j]);
                j++;

            }

            Console.WriteLine("\n");
            
            Console.WriteLine("For Loop on Arrays ");
            string[] objects = {  "Volvo", "BMW", "Ford", "Mazda" };
            for(int i=0;i<objects.Length;i++)
            {
                
                    Console.WriteLine(objects[i]);
                
            }



        }
    }
}
