using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] cmd = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("InsertSpace"))
                {
                    int index = int.Parse(cmd[1]);

                    input = input.Insert(index, " ");

                    Console.WriteLine($"{input}");
                }
                else if (command.Contains("Reverse"))
                {
                    string substring = cmd[1];

                    if (input.Contains(substring))
                    {
                        int startIndex = input.IndexOf(substring);
                        input = input.Remove(startIndex, substring.Length);
                        substring = new string(substring.Reverse().ToArray());
                        input = input.Insert(input.Length, substring);

                        Console.WriteLine($"{input}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (command.Contains("ChangeAll"))
                {
                    string substring = cmd[1];
                    string replacement = cmd[2];

                    while (input.Contains(substring))
                    {
                        int index = input.IndexOf(substring);
                        input = input.Remove(index, substring.Length);
                        input = input.Insert(index, replacement);
                    }

                    Console.WriteLine($"{input}");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
