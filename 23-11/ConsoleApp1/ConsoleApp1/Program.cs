using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Employee emp= new Employee();
            Console.WriteLine("Pleae Enter The First Name");
            emp.FName=Convert.ToString(Console.ReadLine());

            Console.WriteLine("Pleae Enter The Last Name");
            emp.LName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Pleae Enter The amount of Wage");
            emp.wage= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pleae Enter The Number of Logged Hour");
            emp.loggeHours= Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Pleae Enter The TAX amount");
            Employee.tax= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(emp.printslip());
                














            int[]  arr = { 5,4,8,4,1}; 
            Demo d2=new Demo();
            Demo d1=new Demo();
            d1.something();
            int age = 23;
            Console.WriteLine(d1.DoSomething(ref age));
            Console.WriteLine(age);

            d1.promationIncrease(100,"Amman","7star");

            d1.print(arr);

            Console.ReadKey();
          

        }
        public  class Demo
        {
            public void something()
            {
                Console.WriteLine("Do Somethig");
            }
            public int DoSomething(ref int age)
            {

                age = age + 2;
                return 
                    age;
            }
          
           public void promationIncrease(double amount)
            {
                Console.WriteLine($"You've got a pormotion of {amount}");

            }
            public void promationIncrease(int amount,string ticket)
            {
                Console.WriteLine($"You've got a pormotion of {amount} and {ticket}");

            }
            public void promationIncrease(int amount, string ticket,string hotel)
            {
                Console.WriteLine($"You've got a pormotion of {amount} and {ticket} and {hotel}");

            }

          

            public void print(int[] arr) {

                foreach (var i in arr)
                {
                    Console.Write(i);
                }
                Console.WriteLine();


               bool isEven(int num) => (num % 2 == 0);
            }

        }

    }
}
