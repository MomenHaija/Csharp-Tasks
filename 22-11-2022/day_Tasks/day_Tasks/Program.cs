using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Tak 1 \n");
            int[] ARR = { 1, 7, 9, 45, };
            string[] arr2 = { "Str", "alex", "moh" };
            string arr3 = "the fox over lazy dog";

            Console.WriteLine("\n Tak 2 \n");
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine("index of Banana is: " + Array.IndexOf(fruits, "Banana"));
            Console.WriteLine("index of Watermelon is: " + Array.IndexOf(fruits, "Watermelon"));

            Console.WriteLine("\n Tak 3 \n");
            string[] Favorite_Food = { "Checken Tenders", "Pizza", "french fries", "Donuts", "Potato Chips" };
            Console.WriteLine("\nMy Favorite Food");
            foreach (string i in Favorite_Food) { Console.WriteLine(i); };
            for (int i = 0; i < Favorite_Food.Length; i++)
            {
                Console.WriteLine(Favorite_Food[i]);
            }
            string[] Favorite_Sport = { "Football", "Tennis", "Baseball", "Golf", "Volleyball" };
            Console.WriteLine("\nMy Favorite Sports");
            foreach (string i in Favorite_Sport) { Console.WriteLine(i); };
            for (int i = 0; i < Favorite_Sport.Length; i++)
            {
                Console.WriteLine(Favorite_Sport[i]);
            }

            string[] Favorit_Movie = { "Breaking Bad", "Osman Kurulus", "Ertugrul", "Prison Break", "Bab Al-Hara" };
            Console.WriteLine("\nMy Favorit Movies");
            foreach (string i in Favorit_Movie) { Console.WriteLine(i); };
            for (int i = 0; i < Favorit_Movie.Length; i++)
            {
                Console.WriteLine(Favorit_Movie[i]);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tak 4");
            Console.WriteLine("Enter the Numbers");
            string str = Console.ReadLine();
            string[] str_arr = str.Split(',');
            int[] Numarr = new int[3];
            for (int i = 0; i < str_arr.Length; i++)
            {
                Numarr[i] = Convert.ToInt32(str_arr[i]);
                Console.WriteLine(Numarr[i]);

            }
            int sumNum = 0;
            for (int i = 0; i < str_arr.Length; i++)
            {
                sumNum += Numarr[i];
            }
            Console.WriteLine("Summation" + sumNum);





            Console.WriteLine("\n Tak 5 \n");
            int sum = 0;
            Console.WriteLine("the odd Numbers:");
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("Sum odd Numbers from 0 to 100 is:" + sum);



            Console.WriteLine("\n Tak 6 \n");
            for (int i = 1; i < 5; i++)
            {
                for (int z = 4; z > i; z--)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*' + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n Tak 7 \n");
            int count = 1;
            for (int i = 1; i < 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count++);
                }
                Console.WriteLine();
            }





        }
    }
}