using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("ID: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Convert newStudent value to int
                    int newID = int.Parse(newStudent);

                    // Get the student's grade
                    Console.Write("name: ");
                    string newName = Console.ReadLine();

                    students.Add(newID, newName);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            Console.ReadLine();
        }
    }
}
