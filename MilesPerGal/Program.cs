using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGal
{
    class Program
    {
        static void Main(string[] args)
        {
            float miles;
            int   gallons;
            float mpg;

            Console.WriteLine("How many miles have you driven?");
            miles = float.Parse(Console.ReadLine());

            Console.WriteLine("How many gallons of gas have you used?");
            gallons = int.Parse(Console.ReadLine());

            mpg = miles / gallons;

            Console.WriteLine("Gas Mileage: " + mpg + "mpg");
            Console.ReadLine();
        }
    }
}
