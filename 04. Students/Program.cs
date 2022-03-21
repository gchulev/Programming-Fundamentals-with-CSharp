using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                Student student = new Student()
                {
                    FirstName = command[0],
                    SecondName = command[1],
                    Grade = float.Parse(command[2]),
                };
                studentsList.Add(student);
            }

            var orderedList = studentsList.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in orderedList)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public float Grade { get; set; }
    }
}
