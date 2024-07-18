using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    internal class StringEx
    {
        static void SimpleStr()
        {
            string name = "pritam";
            Console.WriteLine(name); // pritam
            Console.WriteLine(name.Length); // size of the characters are 6
        }

        static void EqualChar()
        {
            string str1 = "pritam", str2 = "rohit", str3 = "pritam";
            Console.WriteLine(str1.Equals(str2)); //False - because characters size doesn't match
            Console.WriteLine(str1.Equals(str3)); //True - bacause characters match
        }

        static void LowerCase()
        {
            string name = "PRITAM";
            Console.WriteLine(name.ToLower()); // ToLower - used to convert UpperCase letters to LowerCase
        }

        static void UpperCase()
        {
            string name = "pritam";
            Console.WriteLine(name.ToUpper()); // ToUpper - used to convert LowerCase letters to UpperCase
        }

        public static void Main(string[] args)
        {
            SimpleStr();
            EqualChar();
            LowerCase();
            UpperCase();
        }
    }
}
