using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3___Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Circle c = new Circle(r);
            c.PrintInfo();
        }
    }
}
