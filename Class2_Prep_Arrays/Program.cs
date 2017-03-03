using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class2_Prep_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach ( int myInt in myArray)
            {
                Console.WriteLine(myInt);
            }
            Console.ReadLine();
        }
    }
}
