using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_day
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1

            Console.WriteLine("please Enter two Numbr to find Smaller");
            string firstNumUser = Console.ReadLine();
            int firstNum = Convert.ToInt32(firstNumUser);
            string secondNumUser = Console.ReadLine();
            int secondNum = Convert.ToInt32(secondNumUser);
            Console.Write("Smaller Number :     ");
            int smaller = (firstNum < secondNum) ? firstNum : secondNum;
            Console.Write(smaller + "\n");


            //task2
            Console.WriteLine("Please Enter Number to check the sign");
            string assignuser = Console.ReadLine();
            int assignchar = Convert.ToInt32(assignuser);
            char assign = (assignchar < 0) ? '-' : '+';
            Console.Write("The sign is " + assign + "\n");



            //task3
            Console.WriteLine("please Enter Three Numbr to sort");
            string num1fromuser = Console.ReadLine();
            int num1 = Convert.ToInt32(num1fromuser);

            string num2fromuser = Console.ReadLine();
            int num2 = Convert.ToInt32(num2fromuser);

            string num3fromuser = Console.ReadLine();
            int num3 = Convert.ToInt32(num3fromuser);

            int max = 0;
            int min = 0;
            int middle = 0;

            if (num1 > num2 && num1 > num3) { max = num1; }
            else
            {
                if (num1 > num2 || num1 > num3)
                {
                    middle = num1;
                }
                else
                {
                    min = num1;
                }

            }

            if (num2 > num1 && num2 > num3) { max = num2; }
            else
            {
                if (num2 > num1 || num2 > num3)
                {
                    middle = num2;
                }
                else
                {
                    min = num2;
                }

            }

            if (num3 > num1 && num3 > num1) { max = num3; }
            else
            {
                if (num3 > num1 || num3 > num2)
                {
                    middle = num3;
                }
                else
                {
                    min = num3;
                }

            }

            Console.Write(max + " ");
            Console.Write(middle + " ");
            Console.WriteLine(min + " ");


            //Task4
            Console.WriteLine("please Enter  Numbrs to find the Max");
            string num1user = Console.ReadLine();
            int num1max = Convert.ToInt32(num1user);

            string num2user = Console.ReadLine();
            int num2max = Convert.ToInt32(num2user);

            string num3user = Console.ReadLine();
            int num3max = Convert.ToInt32(num3user);

            string num4user = Console.ReadLine();
            int num4max = Convert.ToInt32(num4user);

            string num5user = Console.ReadLine();
            int num5max = Convert.ToInt32(num5user);

            int maxNumber = num1max;
            if (num2max > num1max)
            {
                maxNumber = num2max;
            }
            if (num3max > maxNumber)
            {
                maxNumber = num3max;
            }
            if (num4max > maxNumber)
            {
                maxNumber = num4max;
            }
            if (num5max > maxNumber)
            {
                maxNumber = num5max;
            }
            Console.WriteLine("Maximmum Number is: " + maxNumber);

            //task5
            double ratio = 0.621371;
            Console.WriteLine("Please Enter The Speed in kilometers per hour");
            string inputinkilometer = Console.ReadLine();
            double kilometer = Convert.ToDouble(inputinkilometer);
            double mile = ratio * kilometer;
            Console.WriteLine(mile + " miles per hour");


            //task6
            Console.WriteLine("please Enter The Number of Hour");
            string inputnumberofhours = Console.ReadLine();
            int numberofhour = Convert.ToInt32(inputnumberofhours);
            Console.WriteLine("please Enter The Number of minutes");
            string inputnumberofminutes = Console.ReadLine();
            int numberofminutes = Convert.ToInt32(inputnumberofminutes);
            int totalnumberofminutes = numberofhour * 60 + numberofminutes;
            Console.WriteLine("Total of minutes is:" + totalnumberofminutes);

            //task7
            Console.WriteLine("please Enter The Number of minutes");
            string inputTotalOfMinutes = Console.ReadLine();
            int numberofminutesfromuser = Convert.ToInt32(inputTotalOfMinutes);
            int numberofMinute = numberofminutesfromuser % 60;
            int numberoghours = numberofminutesfromuser / 60;

            Console.WriteLine(numberoghours + "hours ," + numberofMinute + "  minutes");


            //task8
            string[] names = { "Momen", "Amer", "Quaiz", "odai", "Ashraf" };
            Console.WriteLine(names[0].Substring(0, 4));
            Console.WriteLine(names[1].Substring(0, 4));
            Console.WriteLine(names[2].Substring(0, 4));
            Console.WriteLine(names[3].Substring(0, 4));
            Console.WriteLine(names[4].Substring(0, 4));








        }
    }
}
