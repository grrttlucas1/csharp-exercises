using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("What's your name?");
            input = Console.ReadLine();
            Console.WriteLine("Hello, " + input);
            Console.ReadLine();
        }
    }
}
