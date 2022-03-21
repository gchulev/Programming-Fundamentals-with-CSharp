using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string courseName = command.Split(" : ")[0];
                string studentName = command.Split(" : ")[1];

                if (courses.Any(x => x.Key == courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string> { studentName });
                }

                command = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.WriteLine(string.Join(Environment.NewLine, course.Value.Select(x => $"-- {x}")));
            }
        }
    }
}
