using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class Looings
    {
        static void ForLoop()
        {
            int start;
            Console.Write("Enter start number:");
            start = Convert.ToInt32(Console.ReadLine());

            int end;
            Console.Write("Enter end number:");
            end = Convert.ToInt32(Console.ReadLine());

            for(int i=start; start<=end; start++)
            {
                Console.WriteLine(start);
            }
        }

        static void WhileLoop()
        {
            int a = 1;
            int b = 10;
            while(a<=b)
            {
                if(a%2==0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }
        }

        static void DoWhile()
        {
            int a = 1;
            int b = 5;
            int iteration = 0;

            do
            {
                iteration++;
            }
            while (a >= b);
                Console.WriteLine(iteration);
        }

        public static void Main(string[] args)
        {
            ForLoop();
            Console.WriteLine("-----------");
            WhileLoop();
            Console.WriteLine("-----------");
            DoWhile();
        }
    }
}
