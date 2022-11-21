using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string greeting2 = "Nice To Meet You!";
            Console.WriteLine("Length of String 1 is:" + greeting.Length);
            Console.WriteLine(greeting2.Length);
            Console.WriteLine(greeting.ToUpper());//returns a copy of the string converted to uppercase
            Console.WriteLine(greeting2.ToLower());//returns a copy of the string converted to lowercase:

            //String Concatenation
            string firstName = "Momen";
            string LastName = "Abu Alhaija";
            string name = firstName + " " + LastName;//The + operator can be used between strings to combine them. This is called concatenation
            Console.WriteLine("Name: " + name);


            //You can also use the string.Concat() method to concatenate two strings:
            string nameOtherMethod = String.Concat(firstName, " ", LastName);
            Console.WriteLine("Name: " + nameOtherMethod);

            //If you add two numbers, the result will be a number:
            int x = 5;
            int y = 6;
            int z = x + y;
            Console.WriteLine("summation of Two Numbets is:" + z);

            // If you add two strings, the result will be a string concatenation:
            string ui = "5";
            string op = "6";
            Console.WriteLine(5 + ui + op);


            //String Interpolation
            string secondname = $"My full name is: {firstName} {LastName}";
            Console.WriteLine("using intetrpolation:  " + secondname);


            string myString = "Hello";
            Console.WriteLine(" first characte in String is: " + myString[0]);
            Console.WriteLine(" second characte in String is: " + myString[1]);
            Console.WriteLine("index of e is:" + myString.IndexOf("e"));


            // string txt = "We are the so-called "Vikings" from the north."; Error
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);

            string text = "We are the so-called \'Vikings\' from the north.";
            Console.WriteLine(text);

            // string itscorrect= string txt = ;
            string itscorrect = "It\\\'s alright.";
            Console.WriteLine(itscorrect);

            Console.WriteLine("hello" + "\n" + "World");

            Console.WriteLine("hello" + "\t" + "world");

            Console.WriteLine("hello" + "\b" + "world");


            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
               case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("thersday");
                    break;
                default:
                    Console.WriteLine("friday");
                    break;

            }

            Console.WriteLine("Mohammad\b\b\bff");



        }
    }
}
