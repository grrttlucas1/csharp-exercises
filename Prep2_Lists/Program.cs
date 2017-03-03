using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prep2_Lists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> myIntegers = new List<int>()
            {
                1,2,3,4,5,
                6,7,8,9,10
            };
            List<int> myEvenInts = new List<int>();
            
            foreach (int myInt in myIntegers)
            {
                if (myInt % 2 == 0)
                {
                    myEvenInts.Add(myInt);
                }
            }

            int mySum = myEvenInts.Sum();
            Console.WriteLine(mySum);
            Console.ReadLine();






        }
    }
}
