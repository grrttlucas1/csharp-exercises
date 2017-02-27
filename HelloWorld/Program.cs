using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int    a = 5;
            float  b = 1.2f;
            double c = 3.14159;
            char   d = 'D';
            string e = "Hello";
            bool   f = true;

            string str = "Garrett Bradley Lucas";
            Console.WriteLine(str.Substring(0, 7));
            Console.WriteLine(str.Length);
            Console.WriteLine(str.IndexOf('a'));
            Console.WriteLine(str.Split(' '));

            string str2 = " is shalom.";
            Console.WriteLine(str + str2);

            string str3 = "  Hello  World  ";
            Console.WriteLine(str3.Trim());
            Console.WriteLine(str3.ToLower());
            Console.ReadLine();
        }
    }
}
