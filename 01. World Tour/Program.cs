using System;
using System.Text;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] cmd = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("Add"))
                {
                    int index = int.Parse(cmd[1]);
                    string text = cmd[2];

                    if (index >= 0 && index <= input.Length - 1)
                    {
                        input.Insert(index, text);
                    }

                    Console.WriteLine(input);
                }
                else if (command.Contains("Remove"))
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);

                    if ((startIndex >= 0 && startIndex <= input.Length - 1) && endIndex >= 0 && endIndex <= input.Length - 1)
                    {
                        int removeLength = Math.Abs(endIndex - startIndex);
                        input.Remove(startIndex, removeLength + 1);
                    }

                    Console.WriteLine(input);
                }
                else if (command.Contains("Switch"))
                {
                    string oldString = cmd[1];
                    string newString = cmd[2];

                    input.Replace(oldString, newString);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
