using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace day_Task
{
    internal class Person
    {
        private int Age;
        private string Gender;
        private string Name;
        private string Email;
        private double Id;
        private string Phone;

        public Person(int age, string gender, string name, String email, double id, String phone)
        {
            this.Age = ValidationAge(age);
            this.Email = email;
            this.Gender = gender;
            this.Name = name;
            this.Id = id;
            this.Phone = ValidationNumber(phone);

        }
        public void print()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Gender: {Gender}\n" +
                $"Email: {Email}\n" +
                $"Id: {Id}\n" +
                $"Phone: {Phone}\n"+
                $"Age:{Age}"
                );
        }
        private int  ValidationAge(int age)
        {
            int r_age;
            if (age >= 18 && age <= 60)
            {
                return age;
            }
            else
            {
                Console.WriteLine("you'r age not between the 18 and 60 please reEnter Your age");
                r_age= Convert.ToInt32(Console.ReadLine());
                return ValidationAge(r_age);
            }

        }
        public string ValidationNumber(string phone)
        {
            string str = phone.Substring(0, 3);
            if ((str == "079" || str == "078" || str == "077")&&phone.Length==10)
            {
               return phone;
            }
            else
            {
                Console.WriteLine("The Number is invalid Please again Enter  you'r phone Number");
                phone=Console.ReadLine();
                return ValidationNumber(phone); 
            }

        }

    }
}
