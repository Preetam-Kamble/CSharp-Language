using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            IInterface1 interface1;
            interface1 = new InterfaceDemo();
            interface1.Id = 1234;
            interface1.Name = "Pritam";
            interface1.Display();
            IInterface2 interface2;
            interface2 = new InterfaceDemo();
            interface2.Age = 24;
            interface2.Designation = "Engineer";
            interface2.Display();
        }
    }

    interface IInterface1
    {
        int Id { get; set; }
        string Name { get; set; }
        void Display();
    }

    interface IInterface2
    {
        int Age { get; set; }
        string Designation { get; set; }
        void Display();
    }

    internal class InterfaceDemo : IInterface1, IInterface2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        void IInterface1.Display()
        {
            Console.WriteLine($"The Id is:{Id} & Name is:{Name}");
        }
        void IInterface2.Display()
        {
            Console.WriteLine($"The Age is:{Age} & Designation is:{Designation}");
        }
    }
}
