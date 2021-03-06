﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = String.Join(
                " ",
                "Alice was beginning to get very tired of sitting by",
                "her sister on the bank, and of having nothing to do:",
                "once or twice she had peeped into the book her sister",
                "was reading, but it had no pictures or conversations ",
                "in it, `and what is the use of a book,' thought Alice ",
                "`without pictures or conversation?'");

            Console.WriteLine(sentence);
            Console.WriteLine();
            Console.WriteLine("Enter a search string: ");
            string searchString = Console.ReadLine();

            sentence     = sentence.ToLower();
            searchString = searchString.ToLower();

            if (sentence.Contains(searchString))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
