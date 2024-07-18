using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class DefaultConstructor
    {
        int num;
        DefaultConstructor() // default constructor
        {
            num = 10;
        }

        public void show()
        {
            Console.WriteLine(num);
        }

        public static void Main(string[] args)
        {
            DefaultConstructor p = new DefaultConstructor();
            p.show();
        }
    }
}
