using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Person
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
       public string ToString()
       {
            return $"Name:{name} Person  at Location{address}";
       }
    }
    internal class Student:Person
    {

        private string program;
        public string Program
        {
            get { return program; }
            set { program = value; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double fee;
        public double Fee
        {
            get { return fee; }
            set { fee = value; }

        }
        public Student(string name,string address,string program,int year,double fee):base(name,address) 
        {
            this.fee = fee;
            this.year = year;
            this.program = program;
       
           
        }
        public string Tostring()
        {
            return $"Student Name:{name} \n" +
                   $"Address:{address}\n" +
                   $"Program:{program} \n" +
                   $"Year:{year} \n" +
                   $"Fee{fee} \n";

        }
       
    }
    internal class Staff:Person
    {
        private string school;
        public string School
        {
            get { return school; }
            set { school = value; }
        }
        private double pay;
        public double Pay
        {
            get { return pay; }
            set { pay = value; }
        }

        public Staff(string name, string address, string school,double pay):base(name,address)
        {
            
            this.school = school;
            this.pay = pay;
        
        }
        public string ToString()
        {
            return $"Staff Name:{name}\n" +
                   $"Staff Address:{address}\n" +
                   $"School:{school}\n" +
                   $"Pay:{pay}\n";
        }
    }
}