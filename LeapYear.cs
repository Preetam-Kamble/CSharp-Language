using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Rules for Leap Year
            /// 1:- The year is directly divisible by 400, it's a leap year
            /// 2:- The year is divisible by 4, and year should not divisible by 100, it's not a leap year
            /// </summary>
            
            int year;
            Console.Write("Enter any year:");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0 || year % 4 == 0 && !(year % 100 == 0))
            {
                Console.WriteLine(year + " " + "It's a leap year");
            }
            else
            {
                Console.WriteLine(year + " " + "It's not a leap year");
            }
        }
    }
}
