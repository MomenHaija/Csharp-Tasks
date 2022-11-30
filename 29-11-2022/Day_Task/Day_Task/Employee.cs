using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

 namespace Day_Task
{
    abstract public class Employee
    {
        protected string employeename;
        public string EmployeeName { get; set; }

        protected DateTime birthofdate;
        public DateTime BirthOfDate { get; set; }

        protected int employeeid;
        public int EmployeeID { get; set; }


        public Employee(string name,DateTime birth,int id)
        {
            this.employeeid = id;
            this.birthofdate = birth;
            this.employeename = name;
                
        }
  
        public String Age()
        {

            var DateYear = DateTime.Now.Year - birthofdate.Year;
            var DateMonth = DateTime.Now.Month - birthofdate.Month;
            var DateDay = DateTime.Now.Day - birthofdate.Day;
            return $"{DateYear}year,{DateMonth}month,{DateDay}day";
                
       }

        public abstract double Salary(double slaray, double tax);

        public void PrintSalary(int salary)
        {
            Console.WriteLine("The Salary for Employee is" + salary);

        }
        public void PrintSalary(double salary)
        {
            Console.WriteLine("The Salary for Employee is: " + salary);
        }


    }
    public class Manager:Employee
    {
        public Manager(string name, DateTime birth, int id):base(name,birth,id)
        {
                
        }
        public void Print()
        {
            Console.WriteLine(
                $"Manger Name:{this.employeename}\n"+
                $"Manager Birth Date:{this.birthofdate}\n"+
                $"Manager ID:{this.employeeid}\n"+
                $"Manager Age:{Age()}"
                );
        }

        public override double Salary(double slaray, double tax)
        {

           double NetSalary = slaray - slaray * tax;
            PrintSalary(slaray);
            return slaray;

        }
        
    }
}
