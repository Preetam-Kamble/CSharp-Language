using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueBreakEx
{
    internal class Program
    {
        public static void BreakEx()
        {
            for (int i = 1; i <= 10; i++)
            {
                if(i == 5)
                {
                    break;
                }
                Console.WriteLine(i); // Here execution will stop once i reaches at 5
            }
        }

        public static void ContinueEx()
        {
            for(int i=1; i <= 10; i++)
            {
                if(i == 5 || i == 7)
                {
                    continue;
                }
                Console.WriteLine(i); // Here execute all values except 5 and 7
            }
        }

        static void Main(string[] args)
        {
            BreakEx(); // O/P - 1 2 3 4
            Console.WriteLine("---------------------");
            ContinueEx(); // O/P - 1 2 3 4 6 8 9 10
        }
    }
}
