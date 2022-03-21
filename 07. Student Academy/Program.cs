using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(grade);
                }
                else
                {
                    students.Add(studentName, new List<double> { grade });
                }
            }

            List<string> studentsToBeRemoved = new List<string>();

            foreach (var student in students)
            {
                if ((student.Value.Sum() / student.Value.Count) < 4.50)
                {
                    studentsToBeRemoved.Add(student.Key);
                }
            }

            foreach (var item in studentsToBeRemoved)
            {
                students.Remove(item);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Sum() / student.Value.Count:f2}");
            }
        }
    }
}
