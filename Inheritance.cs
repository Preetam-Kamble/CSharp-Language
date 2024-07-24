using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Parent
    {
        public int salary = 40000;
    }

    public class Child:Parent
    {
        public int childsal = 15000;
    }

    public class GrandChild:Child
    {
        public int grandchildsal = 10000;
    }

    class Driver1
    {
        public static void Main(string[] args)
        {
            GrandChild gc = new GrandChild();
            Console.WriteLine("Salary:" + gc.salary); //40000
            Console.WriteLine("Bonus:" + gc.childsal); //15000
            Console.WriteLine("Increment:" + gc.grandchildsal); //10000
        }
    }
}
