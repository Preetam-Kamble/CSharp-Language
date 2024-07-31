using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalSwitch
{
    internal class CalculatorSwitch
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.Write("Enter a value :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus division");
            Console.Write("Enter case no here :");
            c = Convert.ToInt32(Console.ReadLine());

            switch(c)
            {
                case 1:
                    Console.Write(a + b);
                    break;
                case 2:
                    Console.Write(a - b);
                    break;
                case 3:
                    Console.Write(a * b);
                    break;
                case 4:
                    Console.Write(a / b);
                    break;
                case 5:
                    Console.Write(a % b);
                    break;    
            }
            Console.ReadLine();
        }
    }
}
