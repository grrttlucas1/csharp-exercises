using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double area;
            
            Console.Write("Enter a radius: ");
            radius = Double.Parse(Console.ReadLine());

            while (radius < 0)
            {
                Console.Write("Negatives not allowed. Try again: ");
                radius = Double.Parse(Console.ReadLine());
            }

            area = Math.PI * radius * radius;

            Console.WriteLine(string.Format("Area of a Circle: {0}", area));
            Console.ReadLine();

        }
    }
}
