using System;
using System.Collections.Generic;

namespace TempConv
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double fahrenheit;
            double celcius;
            string input;

            Console.WriteLine("Temperature in F: ");
            input      = Console.ReadLine();
            fahrenheit = double.Parse(input);

            celcius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The Temp in C is: " + celcius);
            Console.ReadLine();
        }
    }
}