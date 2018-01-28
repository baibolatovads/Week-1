using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1___Prime_numbers
{
    class Program
    {
        /// <summary>
        /// Function for finding prime numbers from string[] args
        /// </summary>
        /// <param name="x">a number from the array</param>
        /// <returns>prime number</returns>
        
        static bool IsPrime(int x)
        {
            bool res = true;

            if (x == 1) return false;

            for (int i = 2; i <= Math.Sqrt(x); ++i)
            {
                if (x % i == 0)
                {
                    res = false;
                    break;
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (IsPrime(int.Parse(s)))
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
