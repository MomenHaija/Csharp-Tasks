using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            emp1.Tax = 0.03;
            emp1.wage = 8.5;
            emp1.loggedHours = 8.5;


            Console.WriteLine(emp1.salary());
            Console.WriteLine(emp1.Net_Salary());
            emp1.print();


            Employee emp2 = new Employee
            {
                Tax = 0.05,
                wage = 10,
                loggedHours = 9
            };

            emp2.print();


        }
       public class Employee
        {
            public double wage = 7;
            public double Tax = 0.03;
            public double loggedHours = 8;


            public double salary()
            {
                return wage*loggedHours;
            }    
            
            
            public double Net_Salary() 
            {
                    
                return salary()-salary()*Tax;
            }
            
            public void print()
            {
                Console.WriteLine($"\nwage {wage} \nloggedHours {loggedHours} \n" +
                    $"Salary: {salary()} " +
                    $"\nNetSalary: {Net_Salary()} ");
            }


       }


    }
}
