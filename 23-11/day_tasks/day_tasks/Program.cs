using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace day_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            task10();

        }
        static void task1()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("please enter the number of ");
                Console.WriteLine(+i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j= 1;
            foreach(int u in arr)
            {
                Console.Write("element -");
                Console.Write(j++);
                Console.Write("=");
                Console.Write(u+"\n");
            }
            Console.WriteLine("The sum of Numbers:\t"+avg(arr).Item1);
            Console.WriteLine("The Average is:\t" + avg(arr).Item2);




        }
        static Tuple<float,float> avg(int[] arr)
        {
            float sum = 0;
            float average = 0;
            int n = arr.Length;
            foreach (int y in arr)
            {
                
                sum += y;

            }
            average = sum / n;
            return Tuple.Create(sum, average);
           
        }

        static void task2()
        {
            Console.WriteLine("Please Enter The Numbers of terms");
            cube(Convert.ToInt32(Console.ReadLine()));
        }
        static void cube(int nTerm)
        {
            for(int i = 1; i <= nTerm; i++)
            {
                int pow = i *i*i;
                Console.WriteLine(" Numbers is:"+i+" and cube of The "+i+" is: "+pow);
            }
        }

        static void task3()
        {
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            modern_years(years);


        }
        static void modern_years(int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 1950)
                {
                    Console.WriteLine(number[i]);   
                }
            }
        }

        static void task4()
        {
            Console.WriteLine("please Enter Your age in Years");
           double yourageindays=ageindays(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(yourageindays);


        }
        static double ageindays(int age)
        {
            
            return age * 362;
        }

        static void task5()
        {
            Console.WriteLine("Please Enter The Number of Chicken ");
            int numberofchicken=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please Enter The Number of Cows ");
            int numberofCows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Number of Pigs ");
            int numberofPigs = Convert.ToInt32(Console.ReadLine());

            int numberoflegs= animals(numberofchicken,numberofCows,numberofPigs);
            Console.WriteLine(numberoflegs);

        }
        static int animals(int chickens, int cows, int pigs)
        {

            int numberof_Legs= chickens*2+ cows*4+pigs*4;
            return numberof_Legs;
        }


        static void task6()
        {
            string[] users = { "Momen", "Amer", "Ahmad", "Mohammad", "Asharsf", "Hassan" };
            Console.WriteLine("Please Enter your name");
            string name=Console.ReadLine();
         Console.WriteLine(logIn(users, name));
          
        }
        static string logIn(string[] arr,string name) 
        {
            bool flaf = false;
            foreach(string s in arr)
            {
                if (name == s)
                {
                    flaf = true;
                }
            }
            if(flaf==true)
            {
                return "Pass";
            }
            else
            {
                return "faill";
            }

        }


        static void task7()
        {
            Console.WriteLine("Pleas Enter The Number");
            double num =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The Exponential");
            double exp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(exponent(num, exp));
        }
        static double exponent(double n,double e)
        {
            double p = n;
            for(int i = 1; i < e; i++)
            {
                n *= p;

            }
            return n;   
        }

        static void task8()
        {
            Console.WriteLine("Enter The Year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yearisLeap(year));
        }
        static string yearisLeap(int year)
        {
            if (year >= 1900 && year <= 2024)
            {
                if (year % 4 == 0)
                {
                    return "yes It IS Leap Year";
                }
                else
                {
                    return "it is not leap";
                }
            }
            else
            {
                return "The Year Not Between the 1900 and 2024";
            }

        }


        static void task9()
        {
            Console.WriteLine("Please Enter The Number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isprime = primeNumber(num);
            if (isprime == true)
            {
                Console.WriteLine("yes 'its a prime Number");

            }
            else
            {
                Console.WriteLine("No is not a prime Number");
            }
        }
        static bool primeNumber(int num)
        {
            if (num == 1 || num == 2 || num == 3) 
            {
                return true;
            }
            else if (num % 2 != 0) 
            {
                if (num % 3 == 0 || num % 5 == 0 || num % 7 == 0 || num % 9 == 0)
                { return false; }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        static void task10()
        {
            Console.WriteLine("Enter You text");
            string str = Console.ReadLine();
            int numWord = numberOfWord(str);
            Console.WriteLine("The Number of Word is: " + numWord);
        }
        static int numberOfWord(string str)
        {
            int num_word = 1;
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    num_word++;
                }
            }
            return num_word;
        }


    }
}