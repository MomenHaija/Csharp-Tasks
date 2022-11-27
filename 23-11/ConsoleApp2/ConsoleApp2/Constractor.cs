using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Date
    {
                                                    // 0  1  2  3  4  5  6  7  8  9 10 11 12                   
        private static readonly int[] DaysToMonth365 ={0,31,28,31,30,31,30,31,31,30,31,30,31};
        private static readonly int[] DaysToMonth366 ={0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        protected int Year = 01;
        protected int Month = 01;
        protected int Day = 01;

        public Date(int day,int month,int year)
        {
            var Leap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (year > -1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = Leap ? DaysToMonth366 : DaysToMonth365;
                if (day >= 1 && day <= days[month])
                {
                    this.Day = day;
                    this.Month = month;
                    this.Year = year;
                }
            }
        }
        public Date(int year) : this(01, 01, year) { }
        public Date(int month, int year) : this(01, month, year) { }

        

        public string GetDate() => 
                $"{this.Day.ToString().PadLeft(2, '0')} /" +
                $" {this.Month.ToString().PadLeft(2, '0')}/ " +
                $"{this.Year.ToString().PadLeft(4, '0')}";



    }
}