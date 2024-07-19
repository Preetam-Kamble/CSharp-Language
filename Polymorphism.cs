using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{

    /// <summary>
    /// This Compile Time Polymorphism - achieved by Method Overloading.
    /// Method Overloading - a class have more than one method with same name but different formal argument.
    /// </summary>
  
    internal class Polymorphism
    {
        
        void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        void Sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }

        void Sum(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        void Sum(float a, float b, float c)
        {
            Console.WriteLine(a + b + c);
        }

        public static void Main(string[] args)
        {
            Polymorphism p = new Polymorphism();
            p.Sum(10, 20);
            p.Sum(15.34f, 23.34f);
            p.Sum(5, 10, 15);
            p.Sum(12.22f, 13.23f, 14.24f);
        }
    }
}
