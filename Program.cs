using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        int num;
        Program() // default constructor
        {
            num = 10;
        }

        public void show()
        {
            Console.WriteLine(num);
        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            p.show();
        }
    }
}
