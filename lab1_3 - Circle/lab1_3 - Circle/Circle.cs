using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3___Circle
{
    class Circle
    {
        double r;

        public Circle()
        {
            r = 0;
        }

        public Circle (double r)
        {
            this.r = r;
        }

        /// <summary>
        /// Area of the circle
        /// </summary>
        /// <returns>The answer</returns>
        
        double Area()
        {
            return (double)Math.PI * r * r;
        }

        /// <summary>
        /// Diameter of the circle
        /// </summary>
        /// <returns>The answer</returns>

        double Diam()
        {
            return 2 * r;
        }

        /// <summary>
        /// Circumference of the circle
        /// </summary>
        /// <returns>The answer</returns>

        double Circum()
        {
            return (double)2 * Math.PI * r;
        }

        /// <summary>
        /// Prints the answers
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine("Radius of a circle is: {0:F2}", r);
            Console.WriteLine("Area of a circle is {0:F2}", Area());
            Console.WriteLine("Diameter of a circle is {0:F2}", Diam());
            Console.WriteLine("Circumference of a circle is {0:F2}", Circum());
        }
    }
}
