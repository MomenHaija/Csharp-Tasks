using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        
        public int Id{get;set;}
        public string Name { get; set; }
        public int Discount { get; set; }

        public Employee(int id, string name, int discount)
        {
            this.Id = id;
            this.Name= name;
            this.Discount = discount;
        }
        public void Print()
        {
            Console.WriteLine($"Name:{Name}\nID:{Id}\nDisacount Amount: {Discount}$");
        }

    }
    internal class Invoice: Employee
    {
   
        public double Id { get; set; }
        public String Customer { get; set; }
        public int Amount { get; set; }
        public Invoice(int id, string customer, int amount) : base(id,customer,amount)
        {
            this.Id = id;
            this.Customer = customer;
            this.Amount = amount;
        }

    }
}
