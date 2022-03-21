using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                if (command.Contains("Add"))
                {
                    string lessonTitle = command.Split(':')[1];

                    if (!input.Contains(lessonTitle))
                    {
                        input.Add(lessonTitle);
                    }
                }
                else if (command.Contains("Insert"))
                {
                    string lessonTitle = command.Split(':')[1];
                    int index = int.Parse(command.Split(':')[2]);

                    if (!input.Contains(lessonTitle))
                    {
                        input.Insert(index, lessonTitle);
                    }
                }
                else if (command.Contains("Remove"))
                {
                    string lessonTitle = command.Split(':')[1];

                    input.Remove(lessonTitle);
                }
                else if (command.Contains("Swap"))
                {
                    string lessonTitle1 = command.Split(':')[1];
                    string lessonTitle2 = command.Split(':')[2];

                    if (input.Contains(lessonTitle1) && input.Contains(lessonTitle2))
                    {
                        int firstLessonIndex = input.IndexOf(lessonTitle1);
                        int secondLessonIndex = input.IndexOf(lessonTitle2);

                        input.RemoveAt(firstLessonIndex);
                        input.Insert(firstLessonIndex, lessonTitle2);

                        input.RemoveAt(secondLessonIndex);
                        input.Insert(secondLessonIndex, lessonTitle1);

                        if (input.Contains($"{lessonTitle1}-Exercise"))
                        {
                            string exersice = input.Single(x => x.Contains($"{lessonTitle1}-Exercise"));
                            int exersiceIndex = input.IndexOf(input.Single(x => x.Contains($"{lessonTitle1}-Exercise")));

                            input.RemoveAt(exersiceIndex);
                            input.Insert(input.IndexOf(lessonTitle1) + 1, exersice);
                        }

                        if (input.Contains($"{lessonTitle2}-Exercise"))
                        {
                            string exersice = input.Single(x => x.Contains($"{lessonTitle2}-Exercise"));
                            int exersiceIndex = input.IndexOf(input.Single(x => x.Contains($"{lessonTitle2}-Exercise")));

                            input.RemoveAt(exersiceIndex);
                            input.Insert(input.IndexOf(lessonTitle2) + 1, exersice);
                        }
                    }
                }
                else if (command.Contains("Exercise"))
                {
                    string lessonTitle = command.Split(':')[1];

                    if (input.Contains(lessonTitle))
                    {
                        if (!input.Contains($"{lessonTitle}-Exercise"))
                        {
                            input.Insert(input.IndexOf(lessonTitle) + 1, $"{lessonTitle}-Exercise");
                        }
                    }
                    else
                    {
                        input.Add(lessonTitle);
                        input.Add($"{lessonTitle}-Exercise");
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
    }
}
