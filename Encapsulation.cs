using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Encapsulation
    {
        private string studentName;
        private int studentAge;

        public string name
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int age
        {
            get { return studentAge; }
            set { studentAge = value; }
        }
    }

    class DriverEncp
    {
        static public void Main(string[] args)
        {
            Encapsulation encp = new Encapsulation();
            encp.name = "Pritam";
            encp.age = 22;
            Console.WriteLine("Name :" + encp.name);
            Console.WriteLine("Age :" + encp.age);
        }
    }
}
