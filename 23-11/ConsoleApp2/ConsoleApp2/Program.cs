using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(5, 5, 2005);
            Console.WriteLine(d.GetDate());

            //Employee emp = new Employee
            //{
            //    Id = 1000,
            //    FName = "Momen",
            //    LName = "Abu Alhaija",
            //};

            //Employee emp3 = new Employee(107890)
            //{

            //    FName = "Momen",
            //    LName = "Abu Alhaija",
            //};

            //Console.WriteLine(emp3.DisplayName());

            Employee emp = Employee.Greate(12521, "Momen", "Abu Al-Haija");
            Console.Write(emp.DisplayName());

            Console.ReadKey();
        }
    }
   public class Employee
    {
        private int Id;
        private string FName;    
        private string LName;
        private Employee() { }
        public   Employee(int id, string fname, string lname){
            this.Id = id;
            this.FName= fname;
            this.LName= lname;
                
        }
        public static Employee  Greate(int id,string fname,string lname) =>new Employee(id,fname,lname);

        private Employee(int id) => this.Id = id;

        public string DisplayName() => $"id: {Id} Name: {FName} {LName} \n";
    }
}
