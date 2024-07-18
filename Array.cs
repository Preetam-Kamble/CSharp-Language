using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Array
    {
        public static void StrArr()
        {
            string[] cars = { "Ford", "Volvo", "Hyundai", "BMW", "Audi" };
            foreach(string str in cars)
            {
                Console.WriteLine(str);
            }
        }

        public static void IntArr()
        {
            int[] nums = { 1, 3, 44, 55, 34, 23, 76 };
            for(int i=1;i<nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static void EvenArr()
        {
            int[] nums = { 12, 43, 56, 76, 66, 77, 45, 57, 32, 14, 56, 59 };
            for(int i=1;i<nums.Length;i++)
            {
                if (nums[i]%2==0)
                {
                    Console.WriteLine(nums[i]); //Only Even numbers will display
                }
            }
        }

        static void Main(string[] args)
        {
            StrArr();
            Console.WriteLine("----------------");
            IntArr();
            Console.WriteLine("----------------");
            EvenArr();
        }
    }
}
