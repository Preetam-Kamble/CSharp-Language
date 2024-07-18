using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class ConditionalStatement
    {
        public static void IfEx()
        {
            int num;
            Console.Write("Enter any even number:");
            num = Convert.ToInt16(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine(num + " " + " is an Even number"); // Only true value will get execute
            }
        }

        public static void IfElseEx()
        {
            int num;
            Console.Write("Enter any number:");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine(num + " " + "is an Even number"); // it executes the value either it is true or false
            }
            else
            {
                Console.WriteLine(num + " " + "is an Odd number");
            }
        }

        public static void IfElseLadder()
        {
            int marks;
            Console.Write("Enter your marks:");
            marks = Convert.ToInt32(Console.ReadLine());
            if(marks >= 80 && marks <= 100)
            {
                Console.WriteLine("Candidate pass with distinction");
            }
            else if(marks >= 60 && marks <= 80)
            {
                Console.WriteLine("Candidate pass with first class");
            }
            else if(marks >= 35 && marks <= 60)
            {
                Console.WriteLine("Candidate pass");
            }
            else
            {
                Console.WriteLine("Candidate failed");
            }
        }

        public static void SwitchEx()
        {
            string day;
            Console.Write("Enter any day:");
            day = Console.ReadLine();
            switch(day)
            {
                case "monday":
                case "saturday":
                    {
                        Console.WriteLine("Day to study C#");
                    }
                    break;

                case "tuesday":
                case "thursday":
                    {
                        Console.WriteLine("Day to study Python");
                    }
                    break;

                case "wednesday":
                case "friday":
                    {
                        Console.WriteLine("Day to study Web Technologies");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("It's a revision day");
                    }
                    break;
            }
        }

        static void Main(string[] args)
        {
            IfEx();
            IfElseEx();
            IfElseLadder();
            SwitchEx();
        }
    }
}
