using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        int num1;
        int num2;
        int result;

        void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void Sub()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void Mul()
        {
            result = num1 * num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void Div()
        {
            result = num1 / num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.num1 = 15;
            c.num2 = 5;

            c.Add(); //20
            c.Sub(); //10
            c.Mul(); //75
            c.Div(); //3
        }
    }
}