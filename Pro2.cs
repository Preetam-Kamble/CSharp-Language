using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 14;
            int mul = x * y;
            int add = x + y;
            int sub = y - x;
            Console.WriteLine("The result of this mul is:" + mul);
            Console.WriteLine("The result of this add is: {0}", add);
            Console.WriteLine($"The result of this sub is:{sub}");
        }
    }
}
