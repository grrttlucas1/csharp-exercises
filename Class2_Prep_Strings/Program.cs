using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class2_Prep_Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> myWords = new List<string>()
            {
                "Bob", "Alice", "Jerry", "Jim", "Timothy" 
            };

            foreach (string word in myWords)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }

            Console.ReadLine();
        }
    }
}
