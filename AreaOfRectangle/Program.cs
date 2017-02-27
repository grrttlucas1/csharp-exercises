using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            float  length;
            float  height;
            float  area;

            Console.WriteLine("Enter Length:");
            input  = Console.ReadLine();
            length = float.Parse(input);

            Console.WriteLine("Enter Height:");
            input  = Console.ReadLine();
            height = float.Parse(input);

            area = length * height;
            Console.WriteLine("Rectangle Area: " + area);
            Console.ReadLine();
        }
    }
}
