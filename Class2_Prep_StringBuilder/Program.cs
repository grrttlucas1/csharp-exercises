using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.Write("grade: ");
                    double newGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, newGrade);
                }
            }
            while (newStudent != "");

            // Print class roster
            //Console.WriteLine("\nClass roster:");
            //foreach (KeyValuePair<string, double> student in students)
            //{
            //    Console.WriteLine(student.Key + " (" + student.Value + ")");
            //}

            // Print Class roster
            Console.WriteLine("\nClass roster:");
            
            foreach (KeyValuePair<string, double> student in students)
            {
                StringBuilder line = new StringBuilder();
                line.Append(student.Key);
                line.Append(" (");
                line.Append(student.Value);
                line.Append(")");
                Console.WriteLine(line);
            }


            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
