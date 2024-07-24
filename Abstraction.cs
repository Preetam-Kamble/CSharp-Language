using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Abstraction
    {
        static void Main(string[] args)
        {
            AbstractDemo1 abstractDemo1;
            abstractDemo1 = new AbstractDemo2();
            abstractDemo1.Display1();
            abstractDemo1 = new AbstractDemo3();
            abstractDemo1.Display1();
        }
    }

    internal abstract class AbstractDemo1 // This is Abstract Class
    {
        public abstract void Display1(); // This is Abstract Method which has no Method Body and declared inside Abstract Class.
        public void Display2()
        {
            Console.WriteLine("Abstract class");
        }
    }

    internal class AbstractDemo2 : AbstractDemo1 // AbstractDemo1 is inherited by AbstractDemo2
    {
        public override void Display1() // With the help of Method Overriding(Runtime Polymorphism) we can make implementation.
        {
            Console.WriteLine("Display1() method is overriden in AbstractDemo2");
        }
    }

    internal class AbstractDemo3 : AbstractDemo1
    {
        public override void Display1() // With the help of Method Overriding(Runtime polymorphism) we can make implementation.
        {
            Console.WriteLine("Display1() method is overriden in AbstractDemo3");
        }
    }
}
